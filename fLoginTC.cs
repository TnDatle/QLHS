using _12;

namespace QLHS
{
    public partial class fLoginTC : Form
    {
        public fLoginTC()
        {
            InitializeComponent();
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Hide();
        }

        private void ckShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ckShow.Checked)
            {
                // Hiển thị mật khẩu
                txtTeacherPW.UseSystemPasswordChar = false;
            }
            else
            {
                // Ẩn mật khẩu
                txtTeacherPW.UseSystemPasswordChar = true;
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            CheckLogin(txtTeacherID.Text, txtTeacherPW.Text);
        }

        private void CheckLogin(string teacherIDString, string teacherPW)
        {
            try
            {
                using (var db = new EFDbContext())
                {
                    if (long.TryParse(teacherIDString, out long teacherID))
                    {
                        var user = db.LoginTC
                                      .FirstOrDefault(u => u.TeacherID == teacherID && u.TeacherPW == teacherPW);


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

                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Định dạng mã giáo viên không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

