using System.Xml.Linq;
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
            using (var db = new EFDbContext())
            {
                // Load the customer data from the database using the CustomerID
                student = db.Student.SingleOrDefault(p => p.StudentID == StudentID);
                // Set the form title with the  StudentID
                txtStudentID.Text +=     student.StudentID.ToString();
                // Populate the text boxes with the customer data
                txtStudentName.Text = student.StudentName;
                txtClass.Text = student.Class;
                txtAddress.Text = student.Address;
                txtPhoneNumber.Text = student.PhoneNumber;
                txtEmail.Text = student.Email;
                dtBirthday.Value = student.DayOfBirth;
                if (student.Gender != null)
                {
                    if (student.Gender.ToLower() == "Nam")
                    {
                        rbMale.Checked = true;
                    }
                    else if (student.Gender.ToLower() == "Nữ")
                    {
                        rbFemale.Checked = true;
                    }
                }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                student = db.Student.SingleOrDefault(p => p.StudentID == StudentID);
                if (student != null)
                {
                    student.StudentName = txtStudentName.Text;
                    student.Class = txtClass.Text;
                    student.Address = txtAddress.Text;
                    student.PhoneNumber = txtPhoneNumber.Text;
                    student.Email = txtEmail.Text;
                    student.DayOfBirth = dtBirthday.Value;

                    // Lấy giá trị từ radio button và lưu vào cơ sở dữ liệu
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
                    MessageBox.Show("Lưu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
