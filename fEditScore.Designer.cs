namespace QLHS
{
    partial class fEditScore
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
            label4 = new Label();
            cbSemester = new ComboBox();
            label3 = new Label();
            cbCourseName = new ComboBox();
            label2 = new Label();
            txtStudentID = new TextBox();
            txtStudentName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtMidScores = new TextBox();
            label7 = new Label();
            txtFinalScore = new TextBox();
            btEdit = new Button();
            btCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label1.Location = new Point(383, 24);
            label1.Name = "label1";
            label1.Size = new Size(364, 35);
            label1.TabIndex = 2;
            label1.Text = "Quản Lí Điểm Số Sinh Viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(325, 82);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 48;
            label4.Text = "Học Kỳ:";
            // 
            // cbSemester
            // 
            cbSemester.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSemester.FormattingEnabled = true;
            cbSemester.Location = new Point(408, 86);
            cbSemester.Name = "cbSemester";
            cbSemester.Size = new Size(282, 28);
            cbSemester.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(266, 144);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.TabIndex = 50;
            label3.Text = "Tên học phần :";
            // 
            // cbCourseName
            // 
            cbCourseName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCourseName.FormattingEnabled = true;
            cbCourseName.Location = new Point(408, 148);
            cbCourseName.Name = "cbCourseName";
            cbCourseName.Size = new Size(282, 28);
            cbCourseName.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(277, 213);
            label2.Name = "label2";
            label2.Size = new Size(125, 28);
            label2.TabIndex = 52;
            label2.Text = "Mã sinh viên:";
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Segoe UI", 12F);
            txtStudentID.Location = new Point(408, 207);
            txtStudentID.Margin = new Padding(3, 4, 3, 4);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(285, 34);
            txtStudentID.TabIndex = 53;
            // 
            // txtStudentName
            // 
            txtStudentName.Font = new Font("Segoe UI", 12F);
            txtStudentName.Location = new Point(408, 278);
            txtStudentName.Margin = new Padding(3, 4, 3, 4);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(285, 34);
            txtStudentName.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(276, 281);
            label5.Name = "label5";
            label5.Size = new Size(126, 28);
            label5.TabIndex = 55;
            label5.Text = "Tên sinh viên:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(182, 369);
            label6.Name = "label6";
            label6.Size = new Size(82, 28);
            label6.TabIndex = 56;
            label6.Text = "Giữa kỳ:";
            // 
            // txtMidScores
            // 
            txtMidScores.Font = new Font("Segoe UI", 12F);
            txtMidScores.Location = new Point(285, 363);
            txtMidScores.Margin = new Padding(3, 4, 3, 4);
            txtMidScores.Name = "txtMidScores";
            txtMidScores.Size = new Size(117, 34);
            txtMidScores.TabIndex = 57;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(531, 363);
            label7.Name = "label7";
            label7.Size = new Size(81, 28);
            label7.TabIndex = 58;
            label7.Text = "Cuối kỳ:";
            // 
            // txtFinalScore
            // 
            txtFinalScore.Font = new Font("Segoe UI", 12F);
            txtFinalScore.Location = new Point(618, 360);
            txtFinalScore.Margin = new Padding(3, 4, 3, 4);
            txtFinalScore.Name = "txtFinalScore";
            txtFinalScore.Size = new Size(117, 34);
            txtFinalScore.TabIndex = 59;
            // 
            // btEdit
            // 
            btEdit.BackColor = Color.DarkCyan;
            btEdit.Font = new Font("Microsoft Sans Serif", 24F);
            btEdit.ForeColor = SystemColors.InactiveBorder;
            btEdit.Location = new Point(893, 148);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(225, 65);
            btEdit.TabIndex = 60;
            btEdit.Text = "Thêm";
            btEdit.UseVisualStyleBackColor = false;
            btEdit.Click += btEdit_Click;
            // 
            // btCancel
            // 
            btCancel.BackColor = Color.DarkCyan;
            btCancel.Font = new Font("Microsoft Sans Serif", 24F);
            btCancel.ForeColor = SystemColors.InactiveBorder;
            btCancel.Location = new Point(893, 369);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(172, 56);
            btCancel.TabIndex = 61;
            btCancel.Text = "Hủy";
            btCancel.UseVisualStyleBackColor = false;
            btCancel.Click += btCancel_Click;
            // 
            // fEditScore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 501);
            Controls.Add(btCancel);
            Controls.Add(btEdit);
            Controls.Add(txtFinalScore);
            Controls.Add(label7);
            Controls.Add(txtMidScores);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtStudentName);
            Controls.Add(txtStudentID);
            Controls.Add(label2);
            Controls.Add(cbCourseName);
            Controls.Add(label3);
            Controls.Add(cbSemester);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "fEditScore";
            Text = "Sửa điểm";
            Load += fEditScore_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private ComboBox cbSemester;
        private Label label3;
        private ComboBox cbCourseName;
        private Label label2;
        private TextBox txtStudentID;
        private TextBox txtStudentName;
        private Label label5;
        private Label label6;
        private TextBox txtMidScores;
        private Label label7;
        private TextBox txtFinalScore;
        private Button btEdit;
        private Button btCancel;
    }
}