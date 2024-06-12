using _12;
using FormQLMonHoc;

namespace QLHS
{
    public partial class fMain : Form
    {
        private string userRole;

        public fMain(string role)
        {
            InitializeComponent();
            userRole = role;
            ApplyUserPermissions();
        }

        private void ApplyUserPermissions()
        {
            if (userRole == "Teacher")
            {
                // Giáo viên có quyền quản lý
                quảnLýToolStripMenuItem.Enabled = true;
                quảnLýHọcPhầnToolStripMenuItem.Enabled = true;
            }
            else if (userRole == "Student")
            {
                // Học sinh không có quyền quản lý
                quảnLýToolStripMenuItem.Enabled = true;
                quảnLýHọcPhầnToolStripMenuItem.Enabled = true;
            }
        }

        // Các phương thức và sự kiện khác của fMain

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageStudent"))
                return;
            fManageStudent f = new fManageStudent();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void quảnLýHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageCourse"))
                return;
            fManageCourse f = new fManageCourse();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void lkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng xác nhận muốn đăng xuất
            if (result == DialogResult.Yes)
            {
                // Đóng form hiện tại
                this.Close();

                // Tạo một thể hiện mới của fLogin
                fLogin loginForm = new fLogin();

                // Hiển thị form đăng nhập
                loginForm.Show();
            }
        }

        private void bảngĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageScore"))
                return;
            fManageScore f = new fManageScore();
            f.MdiParent = this.MdiParent;
            f.Show();
        }
    }

}
