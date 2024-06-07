namespace QLHS
{
    partial class fManageCourse
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
            btNew = new Button();
            label2 = new Label();
            txtName = new TextBox();
            btFind = new Button();
            cbSemester = new ComboBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            CourseID = new DataGridViewTextBoxColumn();
            CourseName = new DataGridViewTextBoxColumn();
            Credits = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            Semester = new DataGridViewTextBoxColumn();
            Details = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbDepartment = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(301, 44);
            label1.Name = "label1";
            label1.Size = new Size(434, 46);
            label1.TabIndex = 3;
            label1.Text = "QUẢN LÝ HỌC PHẦN";
            // 
            // btNew
            // 
            btNew.BackColor = Color.DarkCyan;
            btNew.Font = new Font("Microsoft Sans Serif", 10F);
            btNew.ForeColor = SystemColors.InactiveBorder;
            btNew.Location = new Point(54, 44);
            btNew.Name = "btNew";
            btNew.Size = new Size(106, 40);
            btNew.TabIndex = 7;
            btNew.Text = "Nhập mới";
            btNew.UseVisualStyleBackColor = false;
            btNew.Click += btNew_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(827, 44);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 9;
            label2.Text = "Nhập tên học phần";
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 10F);
            txtName.ForeColor = SystemColors.GrayText;
            txtName.Location = new Point(999, 44);
            txtName.Name = "txtName";
            txtName.Size = new Size(237, 26);
            txtName.TabIndex = 10;
            // 
            // btFind
            // 
            btFind.BackColor = Color.DarkCyan;
            btFind.Font = new Font("Microsoft Sans Serif", 10F);
            btFind.ForeColor = SystemColors.InactiveBorder;
            btFind.Location = new Point(1268, 37);
            btFind.Name = "btFind";
            btFind.Size = new Size(82, 40);
            btFind.TabIndex = 11;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = false;
            btFind.Click += btFind_Click;
            // 
            // cbSemester
            // 
            cbSemester.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSemester.FormattingEnabled = true;
            cbSemester.Location = new Point(91, 118);
            cbSemester.Name = "cbSemester";
            cbSemester.Size = new Size(181, 28);
            cbSemester.TabIndex = 12;
            cbSemester.SelectedIndexChanged += cbSemester_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 13;
            label3.Text = "Học Kỳ";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CourseID, CourseName, Credits, Department, Semester, Details, Edit, Delete });
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(12, 190);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1396, 566);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CourseID
            // 
            CourseID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CourseID.DataPropertyName = "CourseID";
            CourseID.HeaderText = "Mã Học Phần";
            CourseID.MinimumWidth = 6;
            CourseID.Name = "CourseID";
            CourseID.Width = 126;
            // 
            // CourseName
            // 
            CourseName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CourseName.DataPropertyName = "CourseName";
            CourseName.HeaderText = "Tên Học Phần";
            CourseName.MinimumWidth = 6;
            CourseName.Name = "CourseName";
            CourseName.Width = 128;
            // 
            // Credits
            // 
            Credits.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Credits.DataPropertyName = "Credits";
            Credits.HeaderText = "Số Tín Chỉ";
            Credits.MinimumWidth = 6;
            Credits.Name = "Credits";
            Credits.Width = 104;
            // 
            // Department
            // 
            Department.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Department.DataPropertyName = "DepartmentName";
            Department.HeaderText = "Khoa";
            Department.MinimumWidth = 6;
            Department.Name = "Department";
            Department.Width = 72;
            // 
            // Semester
            // 
            Semester.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Semester.DataPropertyName = "SemesterName";
            Semester.HeaderText = "Học Kỳ";
            Semester.MinimumWidth = 6;
            Semester.Name = "Semester";
            Semester.Width = 84;
            // 
            // Details
            // 
            Details.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Details.HeaderText = "Chi Tiết";
            Details.MinimumWidth = 6;
            Details.Name = "Details";
            Details.Text = "Chi Tiết";
            Details.UseColumnTextForButtonValue = true;
            Details.Width = 65;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "Sửa";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 40;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(783, 109);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(827, 109);
            label5.Name = "label5";
            label5.Size = new Size(554, 20);
            label5.TabIndex = 18;
            label5.Text = "Những môn học/Học phần có dấu * không được tính vào Trung bình chung tích lũy";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(827, 143);
            label6.Name = "label6";
            label6.Size = new Size(399, 20);
            label6.TabIndex = 19;
            label6.Text = "Những môn học/Học phần có dấu + là những môn tự chọn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(352, 114);
            label7.Name = "label7";
            label7.Size = new Size(57, 28);
            label7.TabIndex = 20;
            label7.Text = "Khoa";
            // 
            // cbDepartment
            // 
            cbDepartment.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(431, 118);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(304, 28);
            cbDepartment.TabIndex = 21;
            cbDepartment.SelectedIndexChanged += cbDepartment_SelectedIndexChanged;
            // 
            // fManageCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 768);
            Controls.Add(cbDepartment);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(cbSemester);
            Controls.Add(btFind);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(btNew);
            Controls.Add(label1);
            Name = "fManageCourse";
            Text = "Quản Lý Học Phần";
            Load += fManageCourse_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btNew;
        private Label label2;
        private TextBox txtName;
        private Button btFind;
        private ComboBox cbSemester;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CourseID;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn Credits;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn Semester;
        private DataGridViewButtonColumn Details;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cbDepartment;
    }
}