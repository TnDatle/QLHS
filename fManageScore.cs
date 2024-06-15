using System;
using System.Linq;
using System.Windows.Forms;
using _12;
using QLHS;
using QLHS.Models;

namespace FormQLMonHoc
{
    public partial class fManageScore : Form
    {
        private long SemesterID;
        private string selectedCourseName;


        public fManageScore()
        {
            InitializeComponent();
        }

        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSemester.SelectedValue != null)
            {
                SemesterID = Convert.ToInt64(cbSemester.SelectedValue);
                LoadCourseNames(); // Load lại danh sách môn học khi học kỳ thay đổi
                UpdateDataGridView();
            }
        }

        private void cbCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCourseName.SelectedValue != null)
            {
                selectedCourseName = cbCourseName.SelectedValue.ToString();
                UpdateDataGridView();
            }
        }


        private void fManageScore_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            cbSemester.SelectedIndexChanged += cbSemester_SelectedIndexChanged;
            cbCourseName.SelectedIndexChanged += cbCourseName_SelectedIndexChanged;

            if (cbSemester.Items.Count > 0)
            {
                cbSemester.SelectedIndex = 0; // Chọn mục đầu tiên mặc định
                SemesterID = Convert.ToInt64(cbSemester.SelectedValue);
                UpdateDataGridView();
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tự động điều chỉnh cột
        }

        private void LoadComboBoxes()
        {
            try
            {
                using (var db = new EFDbContext())
                {
                    var semesters = db.Semester.OrderBy(s => s.SemesterName).ToList();
                    cbSemester.DisplayMember = "SemesterName";
                    cbSemester.ValueMember = "SemesterID";
                    cbSemester.DataSource = semesters;

                    // Load danh sách môn học vào ComboBox cbCourseName
                    LoadCourseNames();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách học kỳ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCourseNames()
        {
            try
            {
                using (var db = new EFDbContext())
                {
                    // Lấy danh sách môn học dựa trên SemesterID đã chọn
                    var courses = db.Course.Where(c => c.SemesterID == SemesterID).OrderBy(c => c.CourseName).ToList();
                    cbCourseName.DisplayMember = "CourseName";
                    cbCourseName.ValueMember = "CourseName"; // Giả sử CourseName là một trường string trong Course model
                    cbCourseName.DataSource = courses;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách môn học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateDataGridView()
        {
            try
            {
                using (var db = new EFDbContext())
                {
                    var grades = db.Grades
                        .Where(g => g.SemesterID == SemesterID && g.CourseName == selectedCourseName)
                        .Select(g => new
                        {
                            g.GradeID,
                            g.StudentID,
                            g.StudentName,
                            g.CourseID,
                            g.CourseName,
                            g.MidScores,
                            g.FinalScores,
                            TotalScore = (g.MidScores.HasValue && g.FinalScores.HasValue)
                                         ? (Convert.ToDouble(g.MidScores.Value) + Convert.ToDouble(g.FinalScores.Value)) / 2
                                         : (double?)null,
                            StudentCategory = CategoryCalculator.CalculateStudentCategory((g.MidScores.HasValue && g.FinalScores.HasValue)
                                                ? (Convert.ToDouble(g.MidScores.Value) + Convert.ToDouble(g.FinalScores.Value)) / 2
                                                : (double?)null)

                        })
                        .ToList();

                    if (grades.Any())
                    {
                        var processedData = grades.Select(g => new
                        {
                            g.GradeID,
                            g.StudentID,
                            g.StudentName,
                            g.CourseID,
                            g.CourseName,
                            g.MidScores,
                            g.FinalScores,
                            g.TotalScore,
                            g.StudentCategory
                        }).ToList();

                        // Ẩn cột GradeID trong DataGridView
                        dataGridView1.Columns["GradeID"].Visible = false;

                        // Gán dữ liệu vào DataGridView
                        dataGridView1.DataSource = processedData;
                    }
                    else
                    {
                        dataGridView1.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            if (UserManager.CurrentUserRole == UserRole.Student)
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Utility.IsOpeningForm("fNewScore"))
                return;

            fNewScore f = new fNewScore();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void fManageScore_Activated(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            // Lấy StudentID từ TextBox txtSearchStudentID
            string studentIDText = txtStudentID.Text.Trim();

            // Kiểm tra xem người dùng đã nhập StudentID hay chưa
            if (string.IsNullOrEmpty(studentIDText))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra xem StudentID có phải là số nguyên không
            if (!long.TryParse(studentIDText, out long studentID))
            {
                MessageBox.Show("Mã sinh viên phải là một số nguyên hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var db = new EFDbContext())
                {
                    var grades = db.Grades
                        .Where(g => g.StudentID == studentID && g.SemesterID == SemesterID)
                        .Select(g => new
                        {
                            g.GradeID,
                            g.StudentID,
                            g.StudentName,
                            g.CourseID,
                            g.CourseName,
                            g.MidScores,
                            g.FinalScores,
                            TotalScore = (g.MidScores.HasValue && g.FinalScores.HasValue)
                                         ? (Convert.ToDouble(g.MidScores.Value) + Convert.ToDouble(g.FinalScores.Value)) / 2
                                         : (double?)null,
                            StudentCategory = CategoryCalculator.CalculateStudentCategory((g.MidScores.HasValue && g.FinalScores.HasValue)
                                                ? (Convert.ToDouble(g.MidScores.Value) + Convert.ToDouble(g.FinalScores.Value)) / 2
                                                : (double?)null)
                        })
                        .ToList();

                    if (grades.Any())
                    {
                        var processedData = grades.Select(g => new
                        {
                            g.GradeID,
                            g.StudentID,
                            g.StudentName,
                            g.CourseID,
                            g.CourseName,
                            g.MidScores,
                            g.FinalScores,
                            g.TotalScore,
                            g.StudentCategory
                        }).ToList();

                        dataGridView1.DataSource = processedData;
                    }
                    else
                    {
                        dataGridView1.DataSource = null;
                        MessageBox.Show($"Không tìm thấy thông tin điểm của sinh viên có mã {studentID} trong học kỳ này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IsUserTeacher())
            {
                // Kiểm tra xem người dùng nhấn vào cột nào và nút DELETE ở dòng nào
                if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
                {
                    // Lấy GradeID từ dòng hiện tại
                    long gradeID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["GradeID"].Value);

                    // Xác nhận xóa bản ghi
                    DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa điểm của sinh viên có GradeID {gradeID}?",
                                                           "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // Xóa bản ghi từ cơ sở dữ liệu
                            using (var db = new EFDbContext())
                            {
                                var gradeToDelete = db.Grades.FirstOrDefault(g => g.GradeID == gradeID);
                                if (gradeToDelete != null)
                                {
                                    db.Grades.Remove(gradeToDelete);
                                    db.SaveChanges();

                                    // Cập nhật lại DataGridView sau khi xóa thành công
                                    UpdateDataGridView();
                                    MessageBox.Show("Xóa điểm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show($"Không tìm thấy điểm có GradeID {gradeID} để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi xóa điểm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
                {
                    if (Utility.IsOpeningForm("fEditScore"))
                        return;

                    // Lấy GradeID từ dòng hiện tại
                    long gradeID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["GradeID"].Value);

                    // Mở form sửa điểm
                    fEditScore f = new fEditScore(gradeID);
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
            }
            else
            {
                // Hiển thị thông báo khi không có quyền
                ShowPermissionDeniedMessage();
            }
        }

        private bool IsUserTeacher()
        {
            // Thực hiện kiểm tra vai trò của người dùng ở đây
            // Ví dụ: Kiểm tra nếu người dùng là giáo viên
            return UserManager.CurrentUserRole == UserRole.Teacher;
        }

        private void ShowPermissionDeniedMessage()
        {
            MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public static class CategoryCalculator
    {
        public static string CalculateStudentCategory(double? totalScore)
        {
            if (totalScore.HasValue)
            {
                double score = totalScore.Value;
                if (score >= 9)
                    return "Xuất sắc";
                else if (score >= 7)
                    return "Giỏi";
                else if (score >= 5)
                    return "Trung bình";
                else
                    return "Yếu";
            }
            else
            {
                return "Chưa có điểm";
            }
        }
    }
}
