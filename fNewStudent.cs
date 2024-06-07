using System;
using System.Windows.Forms;
using System.Xml.Linq;
using System.ComponentModel;
using System.Text.RegularExpressions;
using QLHS.Models;

namespace QLHS
{
    public partial class fNewStudent : Form
    {
        public fNewStudent()
        {
            InitializeComponent();
        }

        internal Student Student { get; private set; }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các trường bắt buộc
                if (string.IsNullOrWhiteSpace(txtStudentName.Text) ||
                    string.IsNullOrWhiteSpace(txtAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra xem giới tính đã được chọn hay chưa
                if (!rbMale.Checked && !rbFemale.Checked)
                {
                    MessageBox.Show("Vui lòng chọn giới tính của sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng Student mới và gán các thuộc tính
                Student student = new Student
                {
                    StudentID = string.IsNullOrWhiteSpace(txtStudentID.Text) ? 0 : Convert.ToInt64(txtStudentID.Text), // Chuyển đổi từ string sang long
                    StudentName = txtStudentName.Text,
                    Address = txtAddress.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Email = txtEmail.Text,
                    DayOfBirth = dtBirthday.Value.Date,
                };

                // Gán giới tính cho Student
                if (rbMale.Checked)
                {
                    student.Gender = "Nam";
                }
                else if (rbFemale.Checked)
                {
                    student.Gender = "Nữ";
                }

                // Thêm sinh viên vào DbContext và lưu vào cơ sở dữ liệu
                using (var db = new EFDbContext())
                {
                    db.Student.Add(student); // Thêm sinh viên vào bối cảnh mô hình
                    db.SaveChanges(); // Lưu các thay đổi vào cơ sở dữ liệu
                }

                // Xóa trống và thiết lập lại các điều khiển
                txtStudentName.Text = null;
                txtAddress.Text = null;
                txtPhoneNumber.Text = null;
                txtEmail.Text = null;
                rbMale.Checked = false;
                rbFemale.Checked = false;

                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu thất bại: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtStudentID_Validating(object sender, CancelEventArgs e)
        {
            // Kiểm tra xem TextBox có trống không
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                toolTip1.Show("Hãy nhập mã số sinh viên", txtStudentID, 0, 0, 1000);
                e.Cancel = false;
                return;
            }
            // Kiểm tra xem giá trị nhập vào có đúng 10 chữ số không
            if (txtStudentID.Text.Length != 10)
            {
                toolTip1.Show("Mã số sinh viên phải có 10 chữ số", txtStudentID, 0, 0, 1000);
                e.Cancel = false;
                return;
            }
            // Chuyển đổi txtStudentID.Text sang kiểu long để so sánh với StudentID trong cơ sở dữ liệu
            long studentID;
            if (!long.TryParse(txtStudentID.Text, out studentID))
            {
                e.Cancel = false;
                return;
            }
            // Kiểm tra xem StudentID đã tồn tại trong cơ sở dữ liệu chưa
            using (var db = new EFDbContext())
            {
                if (db.Student.Any(s => s.StudentID == studentID))
                {
                    toolTip1.Show("Mã số sinh viên đã bị trùng", txtStudentID, 0, 0, 1000);
                    e.Cancel = false;
                    return;
                }
            }

            // Nếu không có vấn đề gì, hủy sự kiện Validating
            e.Cancel = false;
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (!Regex.IsMatch(txtEmail.Text, @"^\d{10}@vaa\.edu\.vn$"))
                {
                    toolTip1.Show("Địa chỉ email phải có định dạng là mã số sinh viên và đuôi là @vaa.edu.vn", txtEmail, 0, 0, 1000);
                    e.Cancel = true;
                    return;
                }
                else if (txtEmail.Text.Length > 100)
                {
                    toolTip1.Show("Địa chỉ email không được vượt quá 100 ký tự", txtEmail, 0, 0, 1000);
                    e.Cancel = true;
                    return;
                }
                else
                {
                    using (var db = new EFDbContext())
                    {
                        if (db.Student.Any(s => s.Email == txtEmail.Text))
                        {
                            toolTip1.Show("Email đã tồn tại!", txtEmail, 0, 0, 1000);
                            e.Cancel = true;
                            return;
                        }
                    }
                }
            }
        }


    }
}
