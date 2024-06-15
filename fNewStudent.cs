using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QLHS.Models;

namespace QLHS
{
    public partial class fNewStudent : Form
    {
        public fNewStudent()
        {
            InitializeComponent();
        }

        private void fNewStudent_Load(object sender, EventArgs e)
        {
            // Khởi tạo sự kiện validating cho các TextBox
            txtStudentID.Validating += txtStudentID_Validating;

            // Vô hiệu hóa txtEmail từ khi form được tải lên
            txtEmail.Enabled = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!IsValidInput())
                return;

            try
            {
                using (var db = new EFDbContext())
                {
                    Student student = CreateStudentObject();
                    db.Student.Add(student);
                    db.SaveChanges();
                }

                ResetControls();

                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lưu thất bại: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidInput()
        {
            if (string.IsNullOrWhiteSpace(txtStudentName.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtClass.Text) ||
                string.IsNullOrWhiteSpace(txtStudentID.Text))
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

            if (studentID != 0 && IsStudentIDDuplicate(studentID))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private Student CreateStudentObject()
        {
            return new Student
            {
                StudentID = long.Parse(txtStudentID.Text),
                StudentName = txtStudentName.Text,
                Address = txtAddress.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Class = txtClass.Text,
                Email = txtEmail.Text,
                DayOfBirth = dtBirthday.Value.Date,
                Gender = rbMale.Checked ? "Nam" : "Nữ"
            };
        }

        private void ResetControls()
        {
            txtStudentName.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            txtClass.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
        }

        private bool IsStudentIDDuplicate(long studentID)
        {
            using (var db = new EFDbContext())
            {
                return db.Student.Any(s => s.StudentID == studentID);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtStudentID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                toolTip1.Show("Hãy nhập mã số sinh viên", txtStudentID, 0, 0, 1000);
                e.Cancel = false;
                return;
            }

            if (txtStudentID.Text.Length != 10 || !Regex.IsMatch(txtStudentID.Text, @"^\d{10}$"))
            {
                toolTip1.Show("Mã số sinh viên phải có đúng 10 chữ số", txtStudentID, 0, 0, 1000);
                e.Cancel = false;
                return;
            }

            long studentID;
            if (!long.TryParse(txtStudentID.Text, out studentID))
            {
                e.Cancel = false;
                return;
            }

            using (var db = new EFDbContext())
            {
                if (db.Student.Any(s => s.StudentID == studentID))
                {
                    toolTip1.Show("Mã số sinh viên đã tồn tại", txtStudentID, 0, 0, 1000);
                    e.Cancel = false;
                    return;
                }
            }

            // Nếu không có vấn đề gì, hủy sự kiện Validating
            e.Cancel = false;

            // Cập nhật email dựa trên mã số sinh viên và vô hiệu hóa trường email
            txtEmail.Text = $"{txtStudentID.Text}@vaa.edu.vn";
            txtEmail.Enabled = false;
        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            // Kiểm tra xem giá trị nhập vào có đúng 10 chữ số không
            if (txtPhoneNumber.Text.Length != 10 || !Regex.IsMatch(txtPhoneNumber.Text, @"^\d{10}$"))
            {
                toolTip1.Show("Số điện thoại phải có đúng 10 chữ số", txtPhoneNumber, 0, 0, 1000);
                e.Cancel = true;
                return;
            }

            // Nếu không có vấn đề gì, hủy sự kiện Validating
            e.Cancel = false;
        }
    }
}
