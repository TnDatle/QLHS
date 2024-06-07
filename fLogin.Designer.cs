namespace QLHS
{
    partial class fLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtStudentID = new TextBox();
            txtStudentPW = new TextBox();
            lkfLoginTC = new LinkLabel();
            btLogin = new Button();
            ckShow = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(291, 25);
            label1.Name = "label1";
            label1.Size = new Size(194, 46);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(36, 110);
            label2.Name = "label2";
            label2.Size = new Size(139, 30);
            label2.TabIndex = 1;
            label2.Text = "Mã sinh viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(36, 170);
            label3.Name = "label3";
            label3.Size = new Size(108, 30);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu:";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(198, 115);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(487, 27);
            txtStudentID.TabIndex = 3;
            // 
            // txtStudentPW
            // 
            txtStudentPW.Location = new Point(198, 173);
            txtStudentPW.Name = "txtStudentPW";
            txtStudentPW.Size = new Size(487, 27);
            txtStudentPW.TabIndex = 4;
            // 
            // lkfLoginTC
            // 
            lkfLoginTC.AutoSize = true;
            lkfLoginTC.Font = new Font("Segoe UI", 12F);
            lkfLoginTC.Location = new Point(36, 238);
            lkfLoginTC.Name = "lkfLoginTC";
            lkfLoginTC.Size = new Size(263, 28);
            lkfLoginTC.TabIndex = 5;
            lkfLoginTC.TabStop = true;
            lkfLoginTC.Text = "Giáo viên đăng nhập tại đây!";
            lkfLoginTC.LinkClicked += lkfLoginTC_LinkClicked;
            // 
            // btLogin
            // 
            btLogin.Font = new Font("Segoe UI", 15F);
            btLogin.Location = new Point(309, 293);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(246, 54);
            btLogin.TabIndex = 6;
            btLogin.Text = "Đăng nhập";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // ckShow
            // 
            ckShow.AutoSize = true;
            ckShow.Checked = true;
            ckShow.CheckState = CheckState.Checked;
            ckShow.Location = new Point(606, 220);
            ckShow.Name = "ckShow";
            ckShow.Size = new Size(126, 24);
            ckShow.TabIndex = 7;
            ckShow.Text = "Xem mật khẩu";
            ckShow.UseVisualStyleBackColor = true;
            ckShow.CheckedChanged += ckShow_CheckedChanged;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 407);
            Controls.Add(ckShow);
            Controls.Add(btLogin);
            Controls.Add(lkfLoginTC);
            Controls.Add(txtStudentPW);
            Controls.Add(txtStudentID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fLogin";
            Text = "Đăng nhập ";
            Load += fLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtStudentID;
        private TextBox txtStudentPW;
        private LinkLabel lkfLoginTC;
        private Button btLogin;
        private CheckBox ckShow;
    }
}