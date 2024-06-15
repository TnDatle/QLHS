using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QLHS;
using QLHS.Models;

namespace _12
{
    public partial class fEditStudent : Form
    {
        private Student student;
        private long StudentID;
        private EFDbContext db = new EFDbContext();

        public fEditStudent(string studentID)
        {
            InitializeComponent();
            this.StudentID = Convert.ToInt64(studentID);
        }

        private void fEditStudent_Load(object sender, EventArgs e)
        {
            // Disable editing of txtStudentID and txtEmail initially
            txtStudentID.Enabled = false;
            txtEmail.Enabled = false;

            // Load student data from database
            LoadStudentData();

            // Enable editing of txtStudentID and txtEmail after loading data
            txtStudentID.Enabled = false;
            txtEmail.Enabled = false;
        }

        private void LoadStudentData()
        {
            using (var db = new EFDbContext())
            {
                student = db.Student.SingleOrDefault(p => p.StudentID == StudentID);
                if (student != null)
                {
                    txtStudentID.Text = student.StudentID.ToString();
                    txtStudentName.Text = student.StudentName;
                    txtClass.Text = student.Class;
                    txtAddress.Text = student.Address;
                    txtPhoneNumber.Text = student.PhoneNumber;
                    txtEmail.Text = student.Email;
                    dtBirthday.Value = student.DayOfBirth;

                    if (student.Gender != null)
                    {
                        if (student.Gender.ToLower() == "nam")
                        {
                            rbMale.Checked = true;
                        }
                        else if (student.Gender.ToLower() == "nữ")
                        {
                            rbFemale.Checked = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!IsValidInput())
                return;

            using (var db = new EFDbContext())
            {
                student = db.Student.SingleOrDefault(p => p.StudentID == StudentID);
                if (student != null)
                {
                    student.StudentName = txtStudentName.Text;
                    student.Class = txtClass.Text;
                    student.Address = txtAddress.Text;
                    student.PhoneNumber = txtPhoneNumber.Text;
                    student.DayOfBirth = dtBirthday.Value;

                    if (rbMale.Checked)
                    {
                        student.Gender = "Nam";
                    }
                    else if (rbFemale.Checked)
                    {
                        student.Gender = "Nữ";
                    }

                    db.SaveChanges();
                    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lưu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsValidInput()
        {
            if (string.IsNullOrWhiteSpace(txtStudentName.Text) ||
                string.IsNullOrWhiteSpace(txtClass.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!rbMale.Checked && !rbFemale.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính của sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            long studentID;
            if (!long.TryParse(txtStudentID.Text, out studentID))
            {
                MessageBox.Show("Mã sinh viên không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (IsStudentIDDuplicate(studentID)) // Check for duplicate only if studentID is not 0
            {
                MessageBox.Show("Mã sinh viên đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtPhoneNumber.Text.Length != 10 || !IsPhoneNumberValid(txtPhoneNumber.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool IsStudentIDDuplicate(long StudentID)
        {
            using (var db = new EFDbContext())
            {
                return db.Student.Any(s => s.StudentID == StudentID && s.StudentID != this.StudentID);
            }
        }

        private bool IsPhoneNumberValid(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }
        private void txtPhoneNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                // Allow empty phone number if desired
                e.Cancel = false;
                return;
            }

            if (txtPhoneNumber.Text.Length != 10 || !IsPhoneNumberValid(txtPhoneNumber.Text))
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }

            e.Cancel = false;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
