using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLHS.Models
{
    internal class Grades
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long GradeID { get; set; }  // Mã điểm

        [StringLength(100)]
        public decimal? MidScores { get; set; } // Điểm giữa kỳ

        public decimal? FinalScores { get; set; } // Điểm cuối kỳ

        public long? StudentID { get; set; } // Mã học sinh

        [StringLength(100)]
        public string? StudentName { get; set; } // Tên học sinh

        public long? CourseID { get; set; } // Mã môn

        [StringLength(100)]
        public string? CourseName { get; set; } // Tên môn

        public long? SemesterID { get; set; } // Học kỳ

        public decimal? TotalScore { get; set; } // Tổng điểm

        [StringLength(50)]
        public string? StudentCategory { get; set; } // Phân loại học sinh
    }
}
