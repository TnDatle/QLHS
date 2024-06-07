using _12;

namespace QLHS
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

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
    }
}
