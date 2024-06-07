using QLHS;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QLHS.Models;

namespace _12
{
    public partial class fManageStudent : Form
    {
        private TextBox txtStudentID;


        public fManageStudent()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long StudentID = Convert.ToInt64(dataGridView1
                    .Rows[e.RowIndex].Cells["StudentID"].Value);
                    using (var db = new EFDbContext())
                    {
                        Student student = db.Student.Single(c => c.StudentID == StudentID);
                        if (MessageBox.Show("Bạn muốn xóa sinh viên " + student.StudentName, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Student.Remove(student);
                            db.SaveChanges();
                            fManageStudent_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Utility.IsOpeningForm("fEditStudent"))
                    return;
                long studentID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["StudentID"].Value);
                string studentIDString = studentID.ToString();
                fEditStudent f = new fEditStudent(studentIDString)
                {
                    MdiParent = this.MdiParent
                };
                f.Show();
            }
        }


        private void btNew_Click(object sender, EventArgs e)
        {
            fNewStudent f = new fNewStudent
            {
                MdiParent = this.MdiParent
            };
            f.Show();
        }

        private void fManageStudent_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.Student.ToList();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new EFDbContext())
                {
                    var searchTerm = txtName.Text;

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        var results = db.Student
                                        .Where(c => c.StudentName.Contains(searchTerm))
                                        .ToList();
                        if (results.Count > 0)
                        {
                            dataGridView1.DataSource = results;
                        }
                        else
                        {
                            MessageBox.Show("Sinh viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập tên sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

