using System;
using System.Linq;
using System.Windows.Forms;
using QLHS;
using _12;
using QLHS.Models;
using System.Text;

namespace FormQLMonHoc
{
    public partial class fManageScore : Form
    {
        private long SemesterID;


        public fManageScore()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Your code here
        }

        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSemester.SelectedValue != null)
            {
                SemesterID = Convert.ToInt64(cbSemester.SelectedValue);
                UpdateDataGridView();
            }
        }

        public void UpdateDataGridView()
        {
            try
            {
                using (var db = new EFDbContext())
                {
                     var data = db.Grades
                       .Where(p => p.SemesterID != 0 && p.SemesterID == SemesterID)
                       .Select(p => new
                       {
                           p.GradeID,
                           p.StudentID,
                           p.StudentName,
                           p.CourseID,
                           p.CourseName,
                           p.MidScores,
                           p.FinalScores,
                           TotalScore = (p.MidScores + p.FinalScores) / 2,
                           StudentCategory =CalculateStudentCategory((p.MidScores + p.FinalScores) / 2)
           })
           .ToList();

                    if (data.Count == 0)
                    {
                        StringBuilder errorMessage = new StringBuilder();
                        errorMessage.AppendLine("Không có dữ liệu được trả về từ cơ sở dữ liệu.");
                        errorMessage.AppendLine("Vấn đề có thể xuất phát từ các nguyên nhân sau:");
                        errorMessage.AppendLine("- Cơ sở dữ liệu không có dữ liệu phù hợp.");
                        errorMessage.AppendLine("- Có lỗi xảy ra khi thực hiện truy vấn dữ liệu.");

                        MessageBox.Show(errorMessage.ToString());
                        return;
                    }
                    else
                    {
                        dataGridView1.DataSource = data;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra khi cố gắng cập nhật dữ liệu: " + ex.ToString());
            }
        }

        // Phương thức tính toán phân loại học sinh dựa trên điểm tổng
        private static string CalculateStudentCategory(double totalScore)
        {
            if (totalScore < 4.00)
            {
                return "Kém";
            }
            else if (totalScore >= 4.00 && totalScore <= 4.90)
            {
                return "Yếu";
            }
            else if (totalScore >= 5.00 && totalScore <= 6.90)
            {
                return "Trung bình";
            }
            else if (totalScore >= 7.00 && totalScore <= 8.40)
            {
                return "Khá";
            }
            else if (totalScore >= 8.50 && totalScore <= 8.90)
            {
                return "Giỏi";
            }
            else
            {
                return "Xuất sắc";
            }
        }


        private void LoadComboBoxes()
        {
            using (var db = new EFDbContext())
            {
                cbSemester.DisplayMember = "SemesterName";
                cbSemester.ValueMember = "SemesterID";
                cbSemester.DataSource = db.Semester.OrderBy(s => s.SemesterName).ToList();
            }
        }

        private void fManageScore_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            cbSemester.SelectedIndexChanged += cbSemester_SelectedIndexChanged; // Gắn sự kiện cho combobox
            if (cbSemester.Items.Count > 0)
            {
                cbSemester.SelectedIndex = 0; // Đặt mục được chọn ban đầu là mục đầu tiên
                SemesterID = Convert.ToInt64(cbSemester.SelectedValue); // Khởi tạo SemesterID với giá trị của mục đầu tiên
                UpdateDataGridView();
            }
            dataGridView1.Width = ClientSize.Width - 10;
        }

        private void fManageScore_Activated(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }
    }
}
