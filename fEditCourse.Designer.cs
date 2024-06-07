namespace QLHS
{
    partial class fEditCourse
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
            label9 = new Label();
            label1 = new Label();
            txtCourseID = new TextBox();
            txtCourseName = new TextBox();
            label2 = new Label();
            label5 = new Label();
            txtCredits = new TextBox();
            label3 = new Label();
            cbDepartment = new ComboBox();
            label4 = new Label();
            cbSemester = new ComboBox();
            btSave = new Button();
            btClose = new Button();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(245, 45);
            label9.Name = "label9";
            label9.Size = new Size(423, 46);
            label9.TabIndex = 38;
            label9.Text = "SỬA ĐỔI HỌC PHẦN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(214, 128);
            label1.Name = "label1";
            label1.Size = new Size(135, 28);
            label1.TabIndex = 39;
            label1.Text = "Mã học phần :";
            // 
            // txtCourseID
            // 
            txtCourseID.Font = new Font("Segoe UI", 12F);
            txtCourseID.Location = new Point(355, 128);
            txtCourseID.Margin = new Padding(3, 4, 3, 4);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(533, 34);
            txtCourseID.TabIndex = 40;
            // 
            // txtCourseName
            // 
            txtCourseName.Font = new Font("Segoe UI", 12F);
            txtCourseName.Location = new Point(355, 200);
            txtCourseName.Margin = new Padding(3, 4, 3, 4);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(533, 34);
            txtCourseName.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(213, 200);
            label2.Name = "label2";
            label2.Size = new Size(136, 28);
            label2.TabIndex = 42;
            label2.Text = "Tên học phần :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(245, 268);
            label5.Name = "label5";
            label5.Size = new Size(97, 28);
            label5.TabIndex = 48;
            label5.Text = "Số tín chỉ:";
            // 
            // txtCredits
            // 
            txtCredits.Font = new Font("Segoe UI", 12F);
            txtCredits.Location = new Point(355, 262);
            txtCredits.Margin = new Padding(3, 4, 3, 4);
            txtCredits.Name = "txtCredits";
            txtCredits.Size = new Size(87, 34);
            txtCredits.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(276, 320);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 50;
            label3.Text = "Khoa :";
            // 
            // cbDepartment
            // 
            cbDepartment.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(355, 320);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(282, 28);
            cbDepartment.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(265, 379);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 52;
            label4.Text = "Học Kỳ:";
            // 
            // cbSemester
            // 
            cbSemester.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSemester.FormattingEnabled = true;
            cbSemester.Location = new Point(355, 379);
            cbSemester.Name = "cbSemester";
            cbSemester.Size = new Size(282, 28);
            cbSemester.TabIndex = 53;
            // 
            // btSave
            // 
            btSave.BackColor = Color.DarkCyan;
            btSave.Font = new Font("Microsoft Sans Serif", 24F);
            btSave.ForeColor = SystemColors.InactiveBorder;
            btSave.Location = new Point(190, 440);
            btSave.Name = "btSave";
            btSave.Size = new Size(225, 65);
            btSave.TabIndex = 54;
            btSave.Text = "Sửa";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.BackColor = Color.DarkCyan;
            btClose.Font = new Font("Microsoft Sans Serif", 24F);
            btClose.ForeColor = SystemColors.InactiveBorder;
            btClose.Location = new Point(556, 440);
            btClose.Name = "btClose";
            btClose.Size = new Size(225, 65);
            btClose.TabIndex = 55;
            btClose.Text = "Hủy";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // fEditCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 540);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(cbSemester);
            Controls.Add(label4);
            Controls.Add(cbDepartment);
            Controls.Add(label3);
            Controls.Add(txtCredits);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(txtCourseName);
            Controls.Add(txtCourseID);
            Controls.Add(label1);
            Controls.Add(label9);
            Name = "fEditCourse";
            Text = "Sửa Học Phần";
            Load += fEditCourse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label1;
        private TextBox txtCourseID;
        private TextBox txtCourseName;
        private Label label2;
        private Label label5;
        private TextBox txtCredits;
        private Label label3;
        private ComboBox cbDepartment;
        private Label label4;
        private ComboBox cbSemester;
        private Button btSave;
        private Button btClose;
    }
}