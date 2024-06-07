using System;
using System.Linq;
using System.Windows.Forms;
using QLHS.Models;

namespace QLHS
{
    public partial class fManageCourse : Form
    {
        public fManageCourse()
        {
            InitializeComponent();
        }

        private long SemesterID;
        private long DepartmentID;

        public void UpdateDataGridView()
        {
            try
            {
                using (var db = new EFDbContext())
                {
                    var query = db.Course.AsQueryable();

                    if (SemesterID != 0)
                    {
                        query = query.Where(p => p.SemesterID == SemesterID);
                    }

                    if (DepartmentID != 1)
                    {
                        query = query.Where(p => p.DepartmentID == DepartmentID);
                    }

                    dataGridView1.DataSource = query.Select(p => new { p.CourseID, p.CourseName, p.Credits, p.DepartmentName, p.SemesterName }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }


        private void LoadComboBoxes()
        {
            using (var db = new EFDbContext())
            {
                cbSemester.DisplayMember = "SemesterName";
                cbSemester.ValueMember = "SemesterID";
                cbSemester.DataSource = db.Semester.OrderBy(s => s.SemesterName).ToList();

                cbDepartment.DisplayMember = "DepartmentName";
                cbDepartment.ValueMember = "DepartmentID";
                cbDepartment.DataSource = db.Department.OrderBy(d => d.DepartmentName).ToList();
            }
        }

        private void fManageCourse_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            UpdateDataGridView();
            dataGridView1.Width = ClientSize.Width - 10;
        }

        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            SemesterID = Convert.ToInt64(cbSemester.SelectedValue);
            UpdateDataGridView();
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            DepartmentID = Convert.ToInt64(cbDepartment.SelectedValue);
            UpdateDataGridView();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                var query = db.Course.AsQueryable();

                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    query = query.Where(c => c.CourseName.Contains(txtName.Text));
                }

                dataGridView1.DataSource = query.Select(c => new { c.CourseID, c.CourseName, c.Credits, c.DepartmentName, c.SemesterName }).ToList();
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewCourse"))
                return;
            fNewCourse f = new fNewCourse();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    using (var db = new EFDbContext())
                    {
                        long CourseID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["CourseID"].Value);
                        var course = db.Course.FirstOrDefault(c => c.CourseID == CourseID);

                        if (course != null && MessageBox.Show("Bạn muốn xóa sản phẩm " + course.CourseName, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Course.Remove(course);
                            db.SaveChanges();
                            //Cập nhật datagridview
                            UpdateDataGridView();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được. Error: " + ex.Message);
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Utility.IsOpeningForm("fEditCourse"))
                    return;
                long courseId = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["CourseID"].Value);
                fEditCourse f = new fEditCourse(courseId);
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }
    }
}
