namespace QLHS
{
    partial class fLoginTC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtTeacherID = new TextBox();
            txtTeacherPW = new TextBox();
            btLogin = new Button();
            ckShow = new CheckBox();
            btReturn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(47, 101);
            label2.Name = "label2";
            label2.Size = new Size(143, 30);
            label2.TabIndex = 2;
            label2.Text = "Mã giáo viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(294, 27);
            label1.Name = "label1";
            label1.Size = new Size(194, 46);
            label1.TabIndex = 3;
            label1.Text = "Đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(47, 175);
            label3.Name = "label3";
            label3.Size = new Size(108, 30);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu:";
            // 
            // txtTeacherID
            // 
            txtTeacherID.Location = new Point(197, 104);
            txtTeacherID.Name = "txtTeacherID";
            txtTeacherID.Size = new Size(487, 27);
            txtTeacherID.TabIndex = 5;
            // 
            // txtTeacherPW
            // 
            txtTeacherPW.Location = new Point(197, 175);
            txtTeacherPW.Name = "txtTeacherPW";
            txtTeacherPW.Size = new Size(487, 27);
            txtTeacherPW.TabIndex = 6;
            // 
            // btLogin
            // 
            btLogin.Font = new Font("Segoe UI", 15F);
            btLogin.Location = new Point(415, 256);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(246, 54);
            btLogin.TabIndex = 7;
            btLogin.Text = "Đăng nhập";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // ckShow
            // 
            ckShow.AutoSize = true;
            ckShow.Checked = true;
            ckShow.CheckState = CheckState.Checked;
            ckShow.Location = new Point(584, 220);
            ckShow.Name = "ckShow";
            ckShow.Size = new Size(126, 24);
            ckShow.TabIndex = 8;
            ckShow.Text = "Xem mật khẩu";
            ckShow.UseVisualStyleBackColor = true;
            ckShow.CheckedChanged += ckShow_CheckedChanged;
            // 
            // btReturn
            // 
            btReturn.Font = new Font("Segoe UI", 15F);
            btReturn.Location = new Point(92, 256);
            btReturn.Name = "btReturn";
            btReturn.Size = new Size(243, 54);
            btReturn.TabIndex = 9;
            btReturn.Text = "Quay lại";
            btReturn.UseVisualStyleBackColor = true;
            btReturn.Click += btReturn_Click;
            // 
            // fLoginTC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 384);
            Controls.Add(btReturn);
            Controls.Add(ckShow);
            Controls.Add(btLogin);
            Controls.Add(txtTeacherPW);
            Controls.Add(txtTeacherID);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "fLoginTC";
            Text = "Đăng nhập [Giảng Viên]";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtTeacherID;
        private TextBox txtTeacherPW;
        private Button btLogin;
        private CheckBox ckShow;
        private Button btReturn;
    }
}