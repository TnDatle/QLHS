using System.ComponentModel.DataAnnotations;

namespace QLHS.Models
{
    internal class Teacher
    {
        [Key]
        public long TeacherID { get; set; }  //Mã giáo viên 
        [StringLength(100)]
        public string Name { get; set; } //nvarchar(100), not null
        public string Department { get; set; }  //Khoa
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }

    }
}
