using System;
using System.Linq;
using System.Windows.Forms;
using QLHS.Models;

namespace QLHS
{
    public partial class fEditScore : Form
    {
        private long GradeID;
        private long CourseID;
        private long StudentID;

        public fEditScore(long gradeID)
        {
            InitializeComponent();
            GradeID = gradeID;
        }

        private void fEditScore_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new EFDbContext())
                {
                    // Load the grade information
                    var grade = db.Grades.FirstOrDefault(g => g.GradeID == GradeID);
                    if (grade != null)
                    {
                        StudentID = grade.StudentID ?? 0; // Handle nullable long
                        CourseID = grade.CourseID ?? 0;

                        // Load data for cbSemester
                        cbSemester.DisplayMember = "SemesterName";
                        cbSemester.ValueMember = "SemesterID";
                        cbSemester.DataSource = db.Semester.OrderBy(s => s.SemesterName).ToList();
                        cbSemester.SelectedValue = db.Course.FirstOrDefault(c => c.CourseID == CourseID)?.SemesterID;

                        // Load data for cbCourseName based on selected Semester
                        cbSemester.SelectedIndexChanged += (s, ev) => LoadCoursesBasedOnSemester();
                        LoadCoursesBasedOnSemester();

                        // Load student information
                        txtStudentID.Text = StudentID.ToString();
                        txtStudentName.Text = grade.StudentName;
                        txtMidScores.Text = grade.MidScores?.ToString();
                        txtFinalScore.Text = grade.FinalScores?.ToString();

                        // Set the course name in the ComboBox
                        cbCourseName.SelectedValue = grade.CourseID;
                    }
                    cbSemester.Enabled = false;
                    cbCourseName.Enabled = false;
                    txtStudentID.Enabled = false;
                    txtStudentName.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCoursesBasedOnSemester()
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
        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string midScoresText = txtMidScores.Text.Trim();
            string finalScoresText = txtFinalScore.Text.Trim();
            if (string.IsNullOrEmpty(midScoresText) || string.IsNullOrEmpty(finalScoresText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin điểm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(midScoresText, out decimal midScores) || !decimal.TryParse(finalScoresText, out decimal finalScores))
            {
                MessageBox.Show("Điểm giữa kỳ và điểm cuối kỳ phải là số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new EFDbContext())
            {
                var grade = db.Grades.FirstOrDefault(g => g.GradeID == GradeID);
                if (grade == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin điểm của sinh viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update the grade information
                grade.MidScores = midScores;
                grade.FinalScores = finalScores;

                db.SaveChanges();
            }

            MessageBox.Show("Lưu thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
