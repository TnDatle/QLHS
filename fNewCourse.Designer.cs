namespace QLHS
{
    partial class fNewCourse
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
            components = new System.ComponentModel.Container();
            label9 = new Label();
            label1 = new Label();
            txtCourseID = new TextBox();
            txtCourseName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbDepartment = new ComboBox();
            cbSemester = new ComboBox();
            btSave = new Button();
            toolTip1 = new ToolTip(components);
            label5 = new Label();
            txtCredits = new TextBox();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(251, 40);
            label9.Name = "label9";
            label9.Size = new Size(457, 46);
            label9.TabIndex = 37;
            label9.Text = "NHẬP MỚI HỌC PHẦN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(210, 122);
            label1.Name = "label1";
            label1.Size = new Size(135, 28);
            label1.TabIndex = 38;
            label1.Text = "Mã học phần :";
            // 
            // txtCourseID
            // 
            txtCourseID.Font = new Font("Segoe UI", 12F);
            txtCourseID.Location = new Point(351, 119);
            txtCourseID.Margin = new Padding(3, 4, 3, 4);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(533, 34);
            txtCourseID.TabIndex = 39;
            // 
            // txtCourseName
            // 
            txtCourseName.Font = new Font("Segoe UI", 12F);
            txtCourseName.Location = new Point(350, 182);
            txtCourseName.Margin = new Padding(3, 4, 3, 4);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(533, 34);
            txtCourseName.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(208, 185);
            label2.Name = "label2";
            label2.Size = new Size(136, 28);
            label2.TabIndex = 41;
            label2.Text = "Tên học phần :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(262, 306);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 42;
            label3.Text = "Khoa :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(251, 372);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 43;
            label4.Text = "Học Kỳ:";
            // 
            // cbDepartment
            // 
            cbDepartment.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(350, 310);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(282, 28);
            cbDepartment.TabIndex = 44;
            // 
            // cbSemester
            // 
            cbSemester.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSemester.FormattingEnabled = true;
            cbSemester.Location = new Point(350, 376);
            cbSemester.Name = "cbSemester";
            cbSemester.Size = new Size(282, 28);
            cbSemester.TabIndex = 45;
            // 
            // btSave
            // 
            btSave.BackColor = Color.DarkCyan;
            btSave.Font = new Font("Microsoft Sans Serif", 24F);
            btSave.ForeColor = SystemColors.InactiveBorder;
            btSave.Location = new Point(366, 422);
            btSave.Name = "btSave";
            btSave.Size = new Size(225, 65);
            btSave.TabIndex = 46;
            btSave.Text = "Thêm";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(247, 246);
            label5.Name = "label5";
            label5.Size = new Size(97, 28);
            label5.TabIndex = 47;
            label5.Text = "Số tín chỉ:";
            // 
            // txtCredits
            // 
            txtCredits.Font = new Font("Segoe UI", 12F);
            txtCredits.Location = new Point(350, 246);
            txtCredits.Margin = new Padding(3, 4, 3, 4);
            txtCredits.Name = "txtCredits";
            txtCredits.Size = new Size(87, 34);
            txtCredits.TabIndex = 48;
            // 
            // fNewCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 519);
            Controls.Add(txtCredits);
            Controls.Add(label5);
            Controls.Add(btSave);
            Controls.Add(cbSemester);
            Controls.Add(cbDepartment);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCourseName);
            Controls.Add(txtCourseID);
            Controls.Add(label1);
            Controls.Add(label9);
            Name = "fNewCourse";
            Text = "Thêm Học Phần";
            Load += fNewCourse_Load;
            Click += fNewCourse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label1;
        private TextBox txtCourseID;
        private TextBox txtCourseName;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbDepartment;
        private ComboBox cbSemester;
        private Button btSave;
        private ToolTip toolTip1;
        private Label label5;
        private TextBox txtCredits;
    }
}