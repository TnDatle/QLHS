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
            btNew = new Button();
            cbSemester = new ComboBox();
            txtStudentID = new TextBox();
            btFind = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbCourseName = new ComboBox();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            CourseID = new DataGridViewTextBoxColumn();
            CourseName = new DataGridViewTextBoxColumn();
            MidScore = new DataGridViewTextBoxColumn();
            FinalScore = new DataGridViewTextBoxColumn();
            TotalScore = new DataGridViewTextBoxColumn();
            StudentCategory = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            GradeID = new DataGridViewTextBoxColumn();
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
            // 
            // btNew
            // 
            btNew.Location = new Point(12, 94);
            btNew.Margin = new Padding(3, 4, 3, 4);
            btNew.Name = "btNew";
            btNew.Size = new Size(103, 44);
            btNew.TabIndex = 1;
            btNew.Text = "Nhập Mới";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
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
            // txtStudentID
            // 
            txtStudentID.Location = new Point(903, 114);
            txtStudentID.Margin = new Padding(3, 4, 3, 4);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(189, 27);
            txtStudentID.TabIndex = 3;
            // 
            // btFind
            // 
            btFind.Location = new Point(1098, 114);
            btFind.Margin = new Padding(3, 4, 3, 4);
            btFind.Name = "btFind";
            btFind.Size = new Size(86, 31);
            btFind.TabIndex = 4;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { StudentID, StudentName, CourseID, CourseName, MidScore, FinalScore, TotalScore, StudentCategory, Edit, Delete, GradeID });
            dataGridView1.Location = new Point(-3, 151);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(1377, 570);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(804, 119);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 6;
            label2.Text = "Mã Sinh viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 120);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 7;
            label3.Text = "Học Kì:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 118);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 8;
            label4.Text = "Môn Học:";
            // 
            // cbCourseName
            // 
            cbCourseName.FormattingEnabled = true;
            cbCourseName.Location = new Point(540, 115);
            cbCourseName.Margin = new Padding(3, 4, 3, 4);
            cbCourseName.Name = "cbCourseName";
            cbCourseName.Size = new Size(138, 28);
            cbCourseName.TabIndex = 9;
            cbCourseName.SelectedIndexChanged += cbCourseName_SelectedIndexChanged;
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
            // StudentCategory
            // 
            StudentCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StudentCategory.DataPropertyName = "StudentCategory";
            StudentCategory.HeaderText = "Xếp Loại";
            StudentCategory.MinimumWidth = 6;
            StudentCategory.Name = "StudentCategory";
            StudentCategory.Width = 96;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "Sửa";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 63;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "Xóa";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 41;
            // 
            // GradeID
            // 
            GradeID.DataPropertyName = "GradeID";
            GradeID.HeaderText = "Mã điểm";
            GradeID.MinimumWidth = 6;
            GradeID.Name = "GradeID";
            GradeID.Width = 125;
            // 
            // fManageScore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 780);
            Controls.Add(cbCourseName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btFind);
            Controls.Add(txtStudentID);
            Controls.Add(cbSemester);
            Controls.Add(btNew);
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
        private Button btNew;
        private ComboBox cbSemester;
        private TextBox txtStudentID;
        private Button btFind;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbCourseName;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn CourseID;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn MidScore;
        private DataGridViewTextBoxColumn FinalScore;
        private DataGridViewTextBoxColumn TotalScore;
        private DataGridViewTextBoxColumn StudentCategory;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private DataGridViewTextBoxColumn GradeID;
    }
}
