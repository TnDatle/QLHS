using System;
using System.Linq;
using System.Windows.Forms;
using QLHS;
using QLHS.Models;

namespace FormQLMonHoc
{
    public partial class fNewScore : Form
    {
        public fNewScore()
        {
            InitializeComponent();

            // Đăng ký sự kiện Validating cho txtStudentID và txtStudentName
            txtStudentID.Validating += new System.ComponentModel.CancelEventHandler(txtStudentID_Validating);
            txtStudentName.Validating += new System.ComponentModel.CancelEventHandler(txtStudentName_Validating);
        }

        private void fNewScore_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            using (var db = new EFDbContext())
            {
                cbSemester.DisplayMember = "SemesterName";
                cbSemester.ValueMember = "SemesterID";
                cbSemester.DataSource = db.Semester.OrderBy(s => s.SemesterName).ToList();
            }

            cbSemester.SelectedIndexChanged += cbSemester_SelectedIndexChanged;
        }

        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCoursesBasedOnSemester();
        }

        private void UpdateCoursesBasedOnSemester()
        {
            if (cbSemester.SelectedValue != null)
            {
                long selectedSemesterID = Convert.ToInt64(cbSemester.SelectedValue);

                using (var db = new EFDbContext())
                {
                    cbCourseName.DisplayMember = "CourseName";
                    cbCourseName.ValueMember = "CourseID";
                    cbCourseName.DataSource = db.Course
                                                .Where(d => d.SemesterID == selectedSemesterID)
                                                .OrderBy(d => d.CourseName)
                                                .ToList();
                }
            }
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            fManageScore f = new fManageScore();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Hide();
        }

        private void txtStudentID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string studentID = txtStudentID.Text.Trim();
            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Mã sinh viên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

            // Kiểm tra xem mã sinh viên có trùng trong cơ sở dữ liệu hay chưa
            using (var db = new EFDbContext())
            {
                bool studentExists = db.Student.Any(s => s.StudentID.ToString() == studentID);
                if (!studentExists)
                {
                    MessageBox.Show("Mã sinh viên không có trong danh sách sinh viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = false;
                }
            }
        }

        private void txtStudentName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string studentName = txtStudentName.Text.Trim();
            if (string.IsNullOrEmpty(studentName))
            {
                MessageBox.Show("Tên sinh viên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = false;
                return;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string studentIDText = txtStudentID.Text.Trim();
            string studentName = txtStudentName.Text.Trim();
            string midScoresText = txtMidScores.Text.Trim();
            string finalScoresText = txtFinalScore.Text.Trim();

            if (string.IsNullOrEmpty(studentIDText) || string.IsNullOrEmpty(studentName) || string.IsNullOrEmpty(midScoresText) || string.IsNullOrEmpty(finalScoresText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(studentIDText, out long studentID))
            {
                MessageBox.Show("Mã sinh viên phải là một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(midScoresText, out double midScores) || !double.TryParse(finalScoresText, out double finalScores))
            {
                MessageBox.Show("Điểm giữa kỳ và điểm cuối kỳ phải là số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra xem có chọn khóa học không
            if (cbCourseName.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khóa học.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new EFDbContext())
            {
                // Lấy thông tin sinh viên từ cơ sở dữ liệu
                var student = db.Student.FirstOrDefault(s => s.StudentID == studentID && s.StudentName == studentName);
                if (student == null)
                {
                    MessageBox.Show("Mã sinh viên và tên sinh viên không khớp hoặc không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy thông tin khóa học từ cơ sở dữ liệu
                var course = db.Course.FirstOrDefault(c => c.CourseID == Convert.ToInt64(cbCourseName.SelectedValue));
                if (course == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin khóa học.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Chuyển đổi giá trị double sang decimal?
                decimal? midScoresDecimal = (decimal?)midScores;
                decimal? finalScoresDecimal = (decimal?)finalScores;

                // Tạo đối tượng Grades mới và lưu vào cơ sở dữ liệu
                var newGrade = new Grades
                {
                    StudentID = studentID,
                    StudentName = studentName,
                    CourseID = course.CourseID,
                    CourseName = course.CourseName,
                    SemesterID = Convert.ToInt64(cbSemester.SelectedValue),
                    MidScores = midScoresDecimal,
                    FinalScores = finalScoresDecimal
                };

                db.Grades.Add(newGrade);
                db.SaveChanges();
            }

            MessageBox.Show("Lưu thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        private void ClearForm()
        {
            txtStudentID.Clear();
            txtStudentName.Clear();
            txtMidScores.Clear();
            txtFinalScore.Clear();
            if (cbSemester.Items.Count > 0)
                cbSemester.SelectedIndex = 0;
            if (cbCourseName.Items.Count > 0)
                cbCourseName.SelectedIndex = 0;
        }
    }
}
