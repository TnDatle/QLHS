using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using QLHS.Models;

namespace QLHS
{
    public partial class fNewCourse : Form
    {
        private long? courseId = null; // Nullable to indicate add or edit mode
        public fNewCourse()
        {
            InitializeComponent();
            this.courseId = courseId;
        }

        private void fNewCourse_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                cbSemester.DisplayMember = "SemesterName";
                cbSemester.ValueMember = "SemesterID";
                cbSemester.DataSource = db.Semester
                                          .OrderBy(s => s.SemesterName)
                                          .Select(s => new { s.SemesterID, s.SemesterName })
                                          .ToList();

                cbDepartment.DisplayMember = "DepartmentName";
                cbDepartment.ValueMember = "DepartmentID";
                cbDepartment.DataSource = db.Department
                                            .OrderBy(d => d.DepartmentName)
                                            .Select(d => new { d.DepartmentID, d.DepartmentName })
                                            .Where(d => d.DepartmentID != 1)
                                            .ToList();

                if (courseId.HasValue)
                {
                    var course = db.Course.Find(courseId.Value);
                    if (course != null)
                    {
                        txtCourseName.Text = course.CourseName;
                        txtCredits.Text = course.Credits;
                        cbSemester.SelectedValue = course.SemesterID;
                        cbDepartment.SelectedValue = course.DepartmentID;
                    }
                }
            }
        }
            private void btSave_Click(object sender, EventArgs e)
                {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (!IsValidInput())
                    return;

                using (var db = new EFDbContext())
                {
                    // Tạo một đối tượng Course từ dữ liệu người dùng
                    Course course = CreateCourseObject();


                    // Thêm đối tượng Course vào DbContext và lưu vào cơ sở dữ liệu
                    db.Course.Add(course);
                    db.SaveChanges();
                }

                // Xóa trống và thiết lập lại các điều khiển
                ResetControls();

                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu thất bại: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtCourseName.Focus();
        }

        private bool IsValidInput()
        {
            if (string.IsNullOrWhiteSpace(txtCourseName.Text) ||
                string.IsNullOrWhiteSpace(txtCredits.Text) ||
                cbSemester.SelectedIndex == -1 ||
                cbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            long courseID;
            if (!long.TryParse(txtCourseID.Text, out courseID))
            {
                MessageBox.Show("Mã môn học không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtCredits.Text, out int parsedCredits))
            {
                MessageBox.Show("Số tín chỉ phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (IsCourseNameDuplicate(txtCourseName.Text))
            {
                MessageBox.Show("Tên môn học đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (IsCourseIDDuplicate(courseID))
            {
                MessageBox.Show("Mã môn học đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }



        private Course CreateCourseObject()
        {
            return new Course
            {
                CourseName = txtCourseName.Text,
                Credits = txtCredits.Text,
                SemesterID = long.TryParse(cbSemester.SelectedValue.ToString(), out long semesterID) ? semesterID : 0,
                DepartmentID = long.TryParse(cbDepartment.SelectedValue.ToString(), out long departmentID) ? departmentID : 0,
                SemesterName = cbSemester.SelectedValue != null ? cbSemester.Text : null,
                DepartmentName = cbDepartment.SelectedValue != null ? cbDepartment.Text : null
            };
        }


        private void ResetControls()
        {
            txtCourseName.Text = "";
            txtCredits.Text = "";
            cbSemester.SelectedIndex = -1;
            cbDepartment.SelectedIndex = -1;
        }
        private bool IsCourseNameDuplicate(string CourseName)
        {
            using (var db = new EFDbContext())
            {
                // Kiểm tra xem có môn học nào đã tồn tại trong cơ sở dữ liệu với tên đã cho chưa
                return db.Course.Any(c => c.CourseName == CourseName);
            }
        }

        private bool IsCourseIDDuplicate(long CourseID)
        {
            using (var db = new EFDbContext())
            {
                // Kiểm tra xem có môn học nào đã tồn tại trong cơ sở dữ liệu với mã đã cho chưa
                return db.Course.Any(c => c.CourseID == CourseID);
            }
        }

    }
}
