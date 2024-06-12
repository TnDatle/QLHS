using System;
using System.Windows.Forms;
using System.Xml.Linq;
using System.ComponentModel;
using System.Text.RegularExpressions;
using QLHS.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

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
                // Kiểm tra dữ liệu đầu vào
                if (!IsValidInput())
                    return;

                using (var db = new EFDbContext())
                {
                    // Tạo một đối tượng Student từ dữ liệu người dùng
                    Student student = CreateStudentObject();

                    // Thêm đối tượng Student vào DbContext và lưu vào cơ sở dữ liệu
                    db.Student.Add(student);
                    db.SaveChanges();
                }

                // Xóa trống và thiết lập lại các điều khiển
                ResetControls();

                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException ex)
            {
                // Handle database update errors
                MessageBox.Show("Lưu thất bại: Database update error. " + ex.InnerException?.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ValidationException ex)
            {
                // Handle validation errors
                MessageBox.Show("Lưu thất bại: Validation error. " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle other general errors
                MessageBox.Show("Lưu thất bại: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtStudentName.Focus();
        }
        private bool IsValidInput()
        {
            if (string.IsNullOrWhiteSpace(txtStudentName.Text) ||
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

            if (studentID != 0 && IsStudentIDDuplicate(studentID)) // Check for duplicate only if studentID is not 0
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
                StudentID = string.IsNullOrWhiteSpace(txtStudentID.Text) ? 0 : Convert.ToInt64(txtStudentID.Text),
                StudentName = txtStudentName.Text,
                Address = txtAddress.Text,
                PhoneNumber = txtPhoneNumber.Text,
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
            rbMale.Checked = false;
            rbFemale.Checked = false;
        }

        private bool IsStudentIDDuplicate(long StudentID)
        {
            using (var db = new EFDbContext())
            {
                // Kiểm tra xem có sinh viên nào đã tồn tại trong cơ sở dữ liệu với mã đã cho chưa
                return db.Student.Any(s => s.StudentID == StudentID);
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
