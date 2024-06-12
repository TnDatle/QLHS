using System.ComponentModel.DataAnnotations;

namespace QLHS.Models
{
    internal class Grades
    {
        [Key]
        public long GradeID { get; set; }  //Mã điểm
        [StringLength(100)]
        public double MidScores { get; set; } //Điểm giữa kỳ
        public double FinalScores { get; set; }   //Điểm cuối kỳ
        public long StudentID { get; set; } //Mã học sinh
        public string StudentName { get; set; } //Tên học sinh
        public long CourseID { get; set; }  //Mã môn
        public string CourseName { get; set; } //Tên môn
        public long SemesterID { get; set; } //Học Kỳ
        public double TotalScore  { get; set; }


    }
}
