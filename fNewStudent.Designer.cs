namespace QLHS

{
    partial class fNewStudent
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
            groupBox1 = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            dtBirthday = new DateTimePicker();
            btClose = new Button();
            btSave = new Button();
            label9 = new Label();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            txtStudentName = new TextBox();
            txtClass = new TextBox();
            txtStudentID = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Location = new Point(566, 100);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(207, 53);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(70, 25);
            rbFemale.Margin = new Padding(3, 4, 3, 4);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(50, 24);
            rbFemale.TabIndex = 5;
            rbFemale.TabStop = true;
            rbFemale.Text = "Nữ";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(5, 25);
            rbMale.Margin = new Padding(3, 4, 3, 4);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(62, 24);
            rbMale.TabIndex = 4;
            rbMale.TabStop = true;
            rbMale.Text = "Nam";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // dtBirthday
            // 
            dtBirthday.CustomFormat = "yyyy-MM-dd";
            dtBirthday.Format = DateTimePickerFormat.Custom;
            dtBirthday.Location = new Point(213, 263);
            dtBirthday.Margin = new Padding(3, 4, 3, 4);
            dtBirthday.Name = "dtBirthday";
            dtBirthday.Size = new Size(206, 27);
            dtBirthday.TabIndex = 3;
            // 
            // btClose
            // 
            btClose.BackColor = Color.DarkCyan;
            btClose.Font = new Font("Microsoft Sans Serif", 10F);
            btClose.ForeColor = SystemColors.InactiveBorder;
            btClose.Location = new Point(537, 345);
            btClose.Margin = new Padding(3, 4, 3, 4);
            btClose.Name = "btClose";
            btClose.Size = new Size(121, 53);
            btClose.TabIndex = 10;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.BackColor = Color.DarkCyan;
            btSave.Font = new Font("Microsoft Sans Serif", 10F);
            btSave.ForeColor = SystemColors.InactiveBorder;
            btSave.Location = new Point(245, 345);
            btSave.Margin = new Padding(3, 4, 3, 4);
            btSave.Name = "btSave";
            btSave.Size = new Size(121, 53);
            btSave.TabIndex = 9;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(245, 24);
            label9.Name = "label9";
            label9.Size = new Size(457, 46);
            label9.TabIndex = 36;
            label9.Text = "NHẬP MỚI SINH VIÊN ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(566, 263);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(206, 27);
            txtEmail.TabIndex = 8;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(566, 211);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(206, 27);
            txtPhoneNumber.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(566, 163);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(206, 27);
            txtAddress.TabIndex = 6;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(213, 211);
            txtStudentName.Margin = new Padding(3, 4, 3, 4);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(206, 27);
            txtStudentName.TabIndex = 2;
            // 
            // txtClass
            // 
            txtClass.Location = new Point(213, 169);
            txtClass.Margin = new Padding(3, 4, 3, 4);
            txtClass.Name = "txtClass";
            txtClass.Size = new Size(206, 27);
            txtClass.TabIndex = 1;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(213, 123);
            txtStudentID.Margin = new Padding(3, 4, 3, 4);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(206, 27);
            txtStudentID.TabIndex = 0;
            txtStudentID.Validating += txtStudentID_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(472, 215);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 32;
            label7.Text = "Số điện thoại :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(472, 263);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 30;
            label8.Text = "Email :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(472, 127);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 28;
            label5.Text = "Giới tính :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(472, 173);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 27;
            label6.Text = "Địa chỉ :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 215);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 26;
            label3.Text = "Họ tên :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 263);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 24;
            label4.Text = "Ngày sinh :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 173);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 21;
            label2.Text = "Lớp :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 127);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 19;
            label1.Text = "Mã số sinh viên :";
            // 
            // fNewStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 498);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(dtBirthday);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(label9);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtAddress);
            Controls.Add(txtStudentName);
            Controls.Add(txtClass);
            Controls.Add(txtStudentID);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fNewStudent";
            Text = "Nhập mới sinh viên";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private DateTimePicker dtBirthday;
        private Button btClose;
        private Button btSave;
        private Label label9;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtAddress;
        private TextBox txtStudentName;
        private TextBox txtClass;
        private TextBox txtStudentID;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private ToolTip toolTip1;
    }
}