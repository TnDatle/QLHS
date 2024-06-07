using System.ComponentModel.DataAnnotations;

namespace QLHS.Models
{
    internal class Course
    {
        [Key]
        public long CourseID { get; set; }  //Mã môn
        [StringLength(100)]
        public string CourseName { get; set; } //nvarchar(100), not null
        public string Credits { get; set; } //Số tín chỉ
        public string DepartmentName { get; set; } //Khoa
        public string SemesterName { get; set; } //Học kỳ
        public long SemesterID { get; set; } 
        public long DepartmentID { get; set; }
    }
}
