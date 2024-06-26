﻿namespace FormQLMonHoc
{
    partial class fNewScore
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
            label1 = new Label();
            cbCourseName = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cbSemester = new ComboBox();
            label2 = new Label();
            txtStudentID = new TextBox();
            label5 = new Label();
            txtStudentName = new TextBox();
            label6 = new Label();
            txtMidScores = new TextBox();
            label7 = new Label();
            txtFinalScore = new TextBox();
            btSave = new Button();
            btReturn = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label1.Location = new Point(349, 30);
            label1.Name = "label1";
            label1.Size = new Size(364, 35);
            label1.TabIndex = 1;
            label1.Text = "Quản Lí Điểm Số Sinh Viên";
            // 
            // cbCourseName
            // 
            cbCourseName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCourseName.FormattingEnabled = true;
            cbCourseName.Location = new Point(377, 155);
            cbCourseName.Name = "cbCourseName";
            cbCourseName.Size = new Size(282, 28);
            cbCourseName.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(218, 155);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.TabIndex = 46;
            label3.Text = "Tên học phần :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(277, 102);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 47;
            label4.Text = "Học Kỳ:";
            // 
            // cbSemester
            // 
            cbSemester.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSemester.FormattingEnabled = true;
            cbSemester.Location = new Point(377, 102);
            cbSemester.Name = "cbSemester";
            cbSemester.Size = new Size(282, 28);
            cbSemester.TabIndex = 48;
            cbSemester.SelectedIndexChanged += cbSemester_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(229, 216);
            label2.Name = "label2";
            label2.Size = new Size(125, 28);
            label2.TabIndex = 49;
            label2.Text = "Mã sinh viên:";
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Segoe UI", 12F);
            txtStudentID.Location = new Point(377, 216);
            txtStudentID.Margin = new Padding(3, 4, 3, 4);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(285, 34);
            txtStudentID.TabIndex = 50;
            txtStudentID.Validating += txtStudentID_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(229, 279);
            label5.Name = "label5";
            label5.Size = new Size(126, 28);
            label5.TabIndex = 51;
            label5.Text = "Tên sinh viên:";
            // 
            // txtStudentName
            // 
            txtStudentName.Font = new Font("Segoe UI", 12F);
            txtStudentName.Location = new Point(377, 276);
            txtStudentName.Margin = new Padding(3, 4, 3, 4);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(285, 34);
            txtStudentName.TabIndex = 52;
            txtStudentName.Validating += txtStudentName_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(149, 366);
            label6.Name = "label6";
            label6.Size = new Size(82, 28);
            label6.TabIndex = 53;
            label6.Text = "Giữa kỳ:";
            // 
            // txtMidScores
            // 
            txtMidScores.Font = new Font("Segoe UI", 12F);
            txtMidScores.Location = new Point(237, 366);
            txtMidScores.Margin = new Padding(3, 4, 3, 4);
            txtMidScores.Name = "txtMidScores";
            txtMidScores.Size = new Size(117, 34);
            txtMidScores.TabIndex = 54;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(504, 366);
            label7.Name = "label7";
            label7.Size = new Size(81, 28);
            label7.TabIndex = 55;
            label7.Text = "Cuối kỳ:";
            // 
            // txtFinalScore
            // 
            txtFinalScore.Font = new Font("Segoe UI", 12F);
            txtFinalScore.Location = new Point(592, 366);
            txtFinalScore.Margin = new Padding(3, 4, 3, 4);
            txtFinalScore.Name = "txtFinalScore";
            txtFinalScore.Size = new Size(117, 34);
            txtFinalScore.TabIndex = 56;
            // 
            // btSave
            // 
            btSave.BackColor = Color.DarkCyan;
            btSave.Font = new Font("Microsoft Sans Serif", 24F);
            btSave.ForeColor = SystemColors.InactiveBorder;
            btSave.Location = new Point(843, 155);
            btSave.Name = "btSave";
            btSave.Size = new Size(225, 65);
            btSave.TabIndex = 57;
            btSave.Text = "Thêm";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // btReturn
            // 
            btReturn.BackColor = Color.DarkCyan;
            btReturn.Font = new Font("Microsoft Sans Serif", 24F);
            btReturn.ForeColor = SystemColors.InactiveBorder;
            btReturn.Location = new Point(863, 413);
            btReturn.Name = "btReturn";
            btReturn.Size = new Size(172, 56);
            btReturn.TabIndex = 58;
            btReturn.Text = "Hủy";
            btReturn.UseVisualStyleBackColor = false;
            btReturn.Click += btReturn_Click;
            // 
            // fNewScore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 508);
            Controls.Add(btReturn);
            Controls.Add(btSave);
            Controls.Add(txtFinalScore);
            Controls.Add(label7);
            Controls.Add(txtMidScores);
            Controls.Add(label6);
            Controls.Add(txtStudentName);
            Controls.Add(label5);
            Controls.Add(txtStudentID);
            Controls.Add(label2);
            Controls.Add(cbSemester);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbCourseName);
            Controls.Add(label1);
            Name = "fNewScore";
            Text = "Nhập điểm ";
            Load += fNewScore_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbCourseName;
        private Label label3;
        private Label label4;
        private ComboBox cbSemester;
        private Label label2;
        private TextBox txtStudentID;
        private Label label5;
        private TextBox txtStudentName;
        private Label label6;
        private TextBox txtMidScores;
        private Label label7;
        private TextBox txtFinalScore;
        private Button btSave;
        private Button btReturn;
        private ToolTip toolTip1;
    }
}