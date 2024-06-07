namespace QLHS
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            menuStrip1 = new MenuStrip();
            sinhViênToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            họcPhầnToolStripMenuItem = new ToolStripMenuItem();
            quảnLýHọcPhầnToolStripMenuItem = new ToolStripMenuItem();
            điểmSốToolStripMenuItem = new ToolStripMenuItem();
            bảngĐiểmToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sinhViênToolStripMenuItem, họcPhầnToolStripMenuItem, điểmSốToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1209, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sinhViênToolStripMenuItem
            // 
            sinhViênToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýToolStripMenuItem });
            sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            sinhViênToolStripMenuItem.Size = new Size(82, 24);
            sinhViênToolStripMenuItem.Text = "&Sinh viên";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(203, 26);
            quảnLýToolStripMenuItem.Text = "&Quản lý sinh viên";
            quảnLýToolStripMenuItem.Click += quảnLýToolStripMenuItem_Click;
            // 
            // họcPhầnToolStripMenuItem
            // 
            họcPhầnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýHọcPhầnToolStripMenuItem });
            họcPhầnToolStripMenuItem.Name = "họcPhầnToolStripMenuItem";
            họcPhầnToolStripMenuItem.Size = new Size(87, 24);
            họcPhầnToolStripMenuItem.Text = "&Học phần";
            // 
            // quảnLýHọcPhầnToolStripMenuItem
            // 
            quảnLýHọcPhầnToolStripMenuItem.Name = "quảnLýHọcPhầnToolStripMenuItem";
            quảnLýHọcPhầnToolStripMenuItem.Size = new Size(207, 26);
            quảnLýHọcPhầnToolStripMenuItem.Text = "&Quản lý học phần";
            quảnLýHọcPhầnToolStripMenuItem.Click += quảnLýHọcPhầnToolStripMenuItem_Click;
            // 
            // điểmSốToolStripMenuItem
            // 
            điểmSốToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bảngĐiểmToolStripMenuItem });
            điểmSốToolStripMenuItem.Name = "điểmSốToolStripMenuItem";
            điểmSốToolStripMenuItem.Size = new Size(78, 24);
            điểmSốToolStripMenuItem.Text = "&Điểm số";
            // 
            // bảngĐiểmToolStripMenuItem
            // 
            bảngĐiểmToolStripMenuItem.Name = "bảngĐiểmToolStripMenuItem";
            bảngĐiểmToolStripMenuItem.Size = new Size(168, 26);
            bảngĐiểmToolStripMenuItem.Text = "&Bảng điểm ";
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1209, 653);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fMain";
            Text = "Quản lý sinh viên";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sinhViênToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem họcPhầnToolStripMenuItem;
        private ToolStripMenuItem quảnLýHọcPhầnToolStripMenuItem;
        private ToolStripMenuItem điểmSốToolStripMenuItem;
        private ToolStripMenuItem bảngĐiểmToolStripMenuItem;
    }
}
