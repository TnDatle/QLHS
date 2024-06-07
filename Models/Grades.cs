using System.ComponentModel.DataAnnotations;

namespace QLHS.Models
{
    internal class Grades
    {
        [Key]
        public long GradeID { get; set; }  //Mã điểm
        [StringLength(100)]
        public long MidScores { get; set; } //Điểm giữa kỳ
        public long FinalScores { get; set; }   //Điểm cuối kỳ
        public string StudentCategory { get; set; } //Phân loại học sinh
        public long StudentID { get; set; }
        public long CourseID { get; set; }
    }
}
