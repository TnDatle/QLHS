namespace FormQLMonHoc
{
    partial class fManageScore
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
            label1 = new Label();
            button1 = new Button();
            cbSemester = new ComboBox();
            textBox1 = new TextBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            GradeID = new DataGridViewTextBoxColumn();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            CourseID = new DataGridViewTextBoxColumn();
            CourseName = new DataGridViewTextBoxColumn();
            MidScore = new DataGridViewTextBoxColumn();
            FinalScore = new DataGridViewTextBoxColumn();
            TotalScore = new DataGridViewTextBoxColumn();
            Classification = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 37);
            label1.Name = "label1";
            label1.Size = new Size(486, 45);
            label1.TabIndex = 0;
            label1.Text = "Quản Lí Điểm Số Sinh Viên";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(14, 107);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(103, 44);
            button1.TabIndex = 1;
            button1.Text = "Nhập Mới";
            button1.UseVisualStyleBackColor = true;
            // 
            // cbSemester
            // 
            cbSemester.FormattingEnabled = true;
            cbSemester.Location = new Point(269, 115);
            cbSemester.Margin = new Padding(3, 4, 3, 4);
            cbSemester.Name = "cbSemester";
            cbSemester.Size = new Size(138, 28);
            cbSemester.TabIndex = 2;
            cbSemester.SelectedIndexChanged += cbSemester_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(601, 115);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(798, 115);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 4;
            button2.Text = "Tìm";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { GradeID, StudentID, StudentName, CourseID, CourseName, MidScore, FinalScore, TotalScore, Classification, Edit, Delete });
            dataGridView1.Location = new Point(14, 209);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(1377, 570);
            dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(507, 120);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 6;
            label2.Text = "Mã Sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 120);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 7;
            label3.Text = "Học Kì";
            // 
            // GradeID
            // 
            GradeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GradeID.DataPropertyName = "GradeID";
            GradeID.HeaderText = "Mã điểm";
            GradeID.MinimumWidth = 6;
            GradeID.Name = "GradeID";
            GradeID.Width = 97;
            // 
            // StudentID
            // 
            StudentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StudentID.DataPropertyName = "StudentID";
            StudentID.HeaderText = "MSSV";
            StudentID.MinimumWidth = 6;
            StudentID.Name = "StudentID";
            StudentID.Width = 76;
            // 
            // StudentName
            // 
            StudentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StudentName.DataPropertyName = "StudentName";
            StudentName.HeaderText = "Tên";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            StudentName.Width = 61;
            // 
            // CourseID
            // 
            CourseID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CourseID.DataPropertyName = "CourseID";
            CourseID.HeaderText = "Mã học phần";
            CourseID.MinimumWidth = 6;
            CourseID.Name = "CourseID";
            CourseID.Width = 124;
            // 
            // CourseName
            // 
            CourseName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CourseName.DataPropertyName = "CourseName";
            CourseName.HeaderText = "Tên học phần";
            CourseName.MinimumWidth = 6;
            CourseName.Name = "CourseName";
            CourseName.Width = 126;
            // 
            // MidScore
            // 
            MidScore.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MidScore.DataPropertyName = "MidScores";
            MidScore.HeaderText = "Giữa Kỳ";
            MidScore.MinimumWidth = 6;
            MidScore.Name = "MidScore";
            MidScore.Width = 88;
            // 
            // FinalScore
            // 
            FinalScore.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FinalScore.DataPropertyName = "FinalScores";
            FinalScore.HeaderText = "Cuối Kỳ";
            FinalScore.MinimumWidth = 6;
            FinalScore.Name = "FinalScore";
            FinalScore.Width = 87;
            // 
            // TotalScore
            // 
            TotalScore.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TotalScore.DataPropertyName = "TotalScore";
            TotalScore.HeaderText = "Tổng Kết";
            TotalScore.MinimumWidth = 6;
            TotalScore.Name = "TotalScore";
            TotalScore.Width = 98;
            // 
            // Classification
            // 
            Classification.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Classification.DataPropertyName = "StudentCategory";
            Classification.HeaderText = "Xếp Loại";
            Classification.MinimumWidth = 6;
            Classification.Name = "Classification";
            Classification.Width = 96;
            // 
            // Edit
            // 
            Edit.HeaderText = "Sửa";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 125;
            // 
            // Delete
            // 
            Delete.HeaderText = "Xóa";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 125;
            // 
            // fManageScore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 780);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(cbSemester);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fManageScore";
            Text = "Quản Lí Điểm Số Sinh Viên";
            WindowState = FormWindowState.Maximized;
            Activated += fManageScore_Activated;
            Load += fManageScore_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private ComboBox cbSemester;
        private TextBox textBox1;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn GradeID;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn CourseID;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn MidScore;
        private DataGridViewTextBoxColumn FinalScore;
        private DataGridViewTextBoxColumn TotalScore;
        private DataGridViewTextBoxColumn Classification;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}
