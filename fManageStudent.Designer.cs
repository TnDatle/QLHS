namespace _12
{
    partial class fManageStudent
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnTimKiem = new Button();
            label1 = new Label();
            txtName = new TextBox();
            btNew = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Class = new DataGridViewTextBoxColumn();
            DayOfBirth = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.DarkCyan;
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 10F);
            btnTimKiem.ForeColor = SystemColors.InactiveBorder;
            btnTimKiem.Location = new Point(1259, 42);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(82, 40);
            btnTimKiem.TabIndex = 0;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(316, 36);
            label1.Name = "label1";
            label1.Size = new Size(422, 46);
            label1.TabIndex = 2;
            label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 10F);
            txtName.ForeColor = SystemColors.GrayText;
            txtName.Location = new Point(995, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(237, 26);
            txtName.TabIndex = 5;
            // 
            // btNew
            // 
            btNew.BackColor = Color.DarkCyan;
            btNew.Font = new Font("Microsoft Sans Serif", 10F);
            btNew.ForeColor = SystemColors.InactiveBorder;
            btNew.Location = new Point(12, 33);
            btNew.Name = "btNew";
            btNew.Size = new Size(106, 40);
            btNew.TabIndex = 6;
            btNew.Text = "Nhập mới";
            btNew.UseVisualStyleBackColor = false;
            btNew.Click += btNew_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { StudentID, StudentName, Gender, Class, DayOfBirth, Address, PhoneNumber, Email, Edit, Delete });
            dataGridView1.GridColor = SystemColors.ControlDark;
            dataGridView1.Location = new Point(2, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(2253, 611);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            StudentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StudentID.DataPropertyName = "ID";
            StudentID.HeaderText = "Id";
            StudentID.MinimumWidth = 6;
            StudentID.Name = "ID";
            StudentID.Width = 122;
            // 
            // StudentID
            // 
            StudentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StudentID.DataPropertyName = "StudentID";
            StudentID.HeaderText = "Mã Sinh viên";
            StudentID.MinimumWidth = 6;
            StudentID.Name = "StudentID";
            StudentID.Width = 122;
            // 
            // StudentName
            // 
            StudentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StudentName.DataPropertyName = "StudentName";
            StudentName.HeaderText = "Họ và Tên";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            StudentName.Width = 104;
            // 
            // Gender
            // 
            Gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Giới tính";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.Width = 94;
            // 
            // Class
            // 
            Class.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Class.DataPropertyName = "Class";
            Class.HeaderText = "Lớp";
            Class.MinimumWidth = 6;
            Class.Name = "Class";
            Class.Width = 63;
            // 
            // DayOfBirth
            // 
            DayOfBirth.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DayOfBirth.DataPropertyName = "DayOfBirth";
            DayOfBirth.HeaderText = "Ngày sinh";
            DayOfBirth.MinimumWidth = 6;
            DayOfBirth.Name = "DayOfBirth";
            DayOfBirth.Width = 103;
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Nơi sinh";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 92;
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "SĐT";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Width = 65;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 75;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 41;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(824, 52);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 8;
            label2.Text = "Nhập tên sinh viên";
            // 
            // fManageStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 765);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btNew);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(btnTimKiem);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "fManageStudent";
            Text = "Quản lý sinh viên";
            WindowState = FormWindowState.Maximized;
            Activated += fManageStudent_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource migration1BindingSource;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Class;
        private DataGridViewTextBoxColumn DayOfBirth;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Label label2;
    }
}
