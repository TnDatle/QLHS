using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using QLHS.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLHS
{
    public partial class fEditCourse : Form
    {
        private Course Course;
        private long CourseID;
        public long SemesterID;
        public long DepartmentID;
        private EFDbContext db = new EFDbContext();

        // Constructor with parameter
        public fEditCourse(long courseId)
        {
            InitializeComponent();
            this.CourseID = courseId;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fEditCourse_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new EFDbContext())
                {
                    // Load the course data from the database using the CourseID
                    Course = db.Course.Single(p => p.CourseID == CourseID);
                    // Set the form title with the CourseID
                    Text += " - Mã môn học " + Course.CourseID.ToString();
                    // Populate the text boxes with the course data
                    txtCourseName.Text = Course.CourseName;
                    txtCredits.Text = Course.Credits;

                    // Load data for cbSemester
                    cbSemester.DisplayMember = "SemesterName";
                    cbSemester.ValueMember = "SemesterID";
                    cbSemester.DataSource = db.Semester.OrderBy(s => s.SemesterName).ToList();
                    cbSemester.SelectedValue = Course.SemesterID;

                    // Load data for cbDepartment
                    cbDepartment.DisplayMember = "DepartmentName";
                    cbDepartment.ValueMember = "DepartmentID";
                    cbDepartment.DataSource = db.Department.OrderBy(d => d.DepartmentName).ToList();
                    cbDepartment.SelectedValue = Course.DepartmentID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải thông tin môn học: " + ex.Message);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    // Kiểm tra và chuyển đổi dữ liệu nhập
                    if (!int.TryParse(txtCredits.Text, out int parsedCredits))
                    {
                        MessageBox.Show("Số tín chỉ phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Kiểm tra giá trị của ComboBox Department
                    if (cbDepartment.SelectedValue == null || !long.TryParse(cbDepartment.SelectedValue.ToString(), out long departmentId))
                    {
                        MessageBox.Show("Vui lòng chọn một khoa hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Kiểm tra giá trị của ComboBox Semester
                    if (cbSemester.SelectedValue == null || !long.TryParse(cbSemester.SelectedValue.ToString(), out long semesterId))
                    {
                        MessageBox.Show("Vui lòng chọn một học kỳ hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Lấy đối tượng Course hiện tại từ cơ sở dữ liệu
                    var courseToUpdate = db.Course.Find(Course.CourseID);
                    if (courseToUpdate == null)
                    {
                        MessageBox.Show("Không tìm thấy khóa học để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Cập nhật đối tượng Course với dữ liệu mới
                    courseToUpdate.CourseName = txtCourseName.Text;
                    courseToUpdate.Credits = parsedCredits.ToString(); // Credits là kiểu string, chuyển đổi từ số nguyên
                    courseToUpdate.SemesterID = semesterId;
                    courseToUpdate.DepartmentID = departmentId;

                    // Đánh dấu đối tượng Course là đã bị sửa đổi
                    db.Entry(courseToUpdate).State = EntityState.Modified;

                    // Lưu các thay đổi vào cơ sở dữ liệu
                    db.SaveChanges();

                    // Commit giao dịch
                    dbContextTransaction.Commit();

                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật DataGridView trên form cha (fManageCourse)
                    (this.MdiParent as fManageCourse)?.UpdateDataGridView();

                    btClose.Focus();
                }
                catch (Exception ex)
                {
                    // Rollback giao dịch nếu có ngoại lệ
                    dbContextTransaction.Rollback();
                    MessageBox.Show($"Lưu thất bại! Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}


