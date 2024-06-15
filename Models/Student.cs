using System.ComponentModel.DataAnnotations;

public class Student
{
    [Key]
    public long ID { get; set; }
    public long? StudentID { get; set; } // Khiến StudentID có thể là null

    public string? StudentName { get; set; }
    public DateTime DayOfBirth { get; set; }
    public string? Class { get; set; }
    public string? Gender { get; set; }
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
}
