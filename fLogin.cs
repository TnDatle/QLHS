using _12;
using QLHS.Models;

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
            if (ckShow.Checked)
            {
                // Hiển thị mật khẩu
                txtStudentPW.UseSystemPasswordChar = false;
            }
            else
            {
                // Ẩn mật khẩu
                txtStudentPW.UseSystemPasswordChar = true;
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            CheckLogin(txtStudentID.Text, txtStudentPW.Text);
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
                            // Chuyển sang form chính hoặc thực hiện các hành động sau khi đăng nhập thành công
                            fMain f = new fMain();
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
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
