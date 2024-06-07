using System.ComponentModel.DataAnnotations;

namespace QLHS.Models
{
    internal class Student
    {
        [Key]
        public long StudentID { get; set; }
        [StringLength(100)]
        public string StudentName { get; set; } //nvarchar(100), not null
        public DateTime DayOfBirth { get; set; }
        [StringLength(250)]
        public string Class { get; set; }
        public string Gender { get; set; } //bit, null
        public string? Address { get; set; }
        [StringLength(10, MinimumLength = 10)]
        public string? PhoneNumber { get; set; }
        [StringLength(100)]
        public string? Email { get; set; }
      
    }
}
