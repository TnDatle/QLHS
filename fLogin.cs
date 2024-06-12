using _12;
using QLHS.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLHS
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void lkfLoginTC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fLoginTC f = new fLoginTC();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Hide();
        }

        private void ckShow_CheckedChanged(object sender, EventArgs e)
        {
            // Hiển thị hoặc ẩn mật khẩu
            txtStudentPW.UseSystemPasswordChar = !ckShow.Checked;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string studentIDString = txtStudentID.Text.Trim();
            string studentPW = txtStudentPW.Text;

            if (string.IsNullOrEmpty(studentIDString) || string.IsNullOrEmpty(studentPW))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CheckLogin(studentIDString, studentPW);
        }

        private void CheckLogin(string studentIDString, string studentPW)
        {
            try
            {
                using (var db = new EFDbContext())
                {
                    if (long.TryParse(studentIDString, out long studentID))
                    {
                        var user = db.Login
                                     .FirstOrDefault(u => u.StudentID == studentID && u.StudentPW == studentPW);

                        if (user != null)
                        {
                            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Ép kiểu từ int sang UserRole
                            UserRole userRole = (UserRole)user.UserRole;

                            // Thiết lập vai trò hiện tại
                            UserManager.CurrentUserRole = userRole;

                            // Chuyển sang form chính
                            fMain f = new fMain(userRole.ToString());
                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Định dạng mã sinh viên không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            //Viết thuộc tính load nếu cần thiết
        }
    }
}
