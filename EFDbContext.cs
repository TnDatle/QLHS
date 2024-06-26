using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using QLHS.Models;

namespace QLHS
{
    internal class EFDbContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<LoginTC> LoginTC { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Semester> Semester { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Grades> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Đảm bảo rằng optionsBuilder chưa được cấu hình
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cấu hình các thuộc tính cho Student entity
            modelBuilder.Entity<Student>(c =>
            {
                c.Property(b => b.Address) .HasColumnType("nvarchar(250)")  // Thiết lập kiểu dữ liệu của cột trong database
                                           .IsRequired(false);  // Cho phép cột nhận giá trị NULL
                c.Property(b => b.DayOfBirth).HasColumnType("date");
            });

            // Khởi tạo dữ liệu mẫu
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    ID = 1, //Tự cấp khóa chính
                    StudentID = null,
                    StudentName = null,
                    Gender = null,
                    Class = null,
                    DayOfBirth = DateTime.Parse("2004-11-21"),
                    Address = null,
                    PhoneNumber = null,
                    Email = null
                });

            modelBuilder.Entity<Login>().HasData(
                new Login
                {
                    StudentID = 2254810177,
                    StudentPW = "21112004",
                    UserRole = 1,
                },
                new Login
                {
                    StudentID = 2254810159,
                    StudentPW = "01072004",
                    UserRole = 1,
                },
                new Login
                {
                    StudentID = 2254810196,
                    StudentPW = "28022004",
                    UserRole = 1,
                },
                new Login
                {
                    StudentID = 2254810246,
                    StudentPW = "16012004",
                    UserRole = 1,
                },
                new Login
                {
                    StudentID = 2254810192,
                    StudentPW = "10022004",
                    UserRole = 1,
                });

            modelBuilder.Entity<LoginTC>().HasData(
                new LoginTC
                {
                    TeacherID = 1000002024,
                    TeacherPW = "HVHK@2023",
                    UserRole = 2,
                },
                new LoginTC
                {
                    TeacherID = 2000002024,
                    TeacherPW = "HVHK@2024",
                    UserRole = 2,
                },
                new LoginTC
                {
                    TeacherID = 3000002024,
                    TeacherPW = "HVHK@2025",
                    UserRole = 2,
                });

            modelBuilder.Entity<Semester>().HasData(
                new Semester { SemesterID = 1, SemesterName = "Học Kỳ 1" },
                new Semester { SemesterID = 2, SemesterName = "Học Kỳ 2" },
                new Semester { SemesterID = 3, SemesterName = "Học Kỳ 3" },
                new Semester { SemesterID = 4, SemesterName = "Học Kỳ 4" },
                new Semester { SemesterID = 5, SemesterName = "Học Kỳ 5" },
                new Semester { SemesterID = 6, SemesterName = "Học Kỳ 6" },
                new Semester { SemesterID = 7, SemesterName = "Học Kỳ 7" },
                new Semester { SemesterID = 8, SemesterName = "Học Kỳ 8" }
                );

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentID = 1, DepartmentName = "Tất cả" },
                new Department { DepartmentID = 2, DepartmentName = "Khoa Công Nghệ Thông Tin" },
                new Department { DepartmentID = 3, DepartmentName = "Khoa Cơ bản" },
                new Department { DepartmentID = 4, DepartmentName = "Khoa Ngoại Ngữ" });

            modelBuilder.Entity<Course>().HasData(
                //Học Kỳ 1
                new Course
                {
                    CourseID = 0101000001,
                    CourseName = "Tổng quan về Hàng không dân dụng",
                    Credits = "3",
                    DepartmentName = "Khoa Cơ Bản",
                    SemesterName = "Học Kỳ 1",
                    SemesterID = 1,
                    DepartmentID = 3,
                },

                new Course
                {
                    CourseID = 0101000009,
                    CourseName = "Giáo dục thể chất-Sức nhanh *",
                    Credits = "1",
                    DepartmentName = "Khoa Cơ Bản",
                    SemesterName = "Học Kỳ 1",
                    SemesterID = 1,
                    DepartmentID = 3,
                },

                new Course
                {
                    CourseID = 0101000373,
                    CourseName = "Cơ sở dữ liệu",
                    Credits = "3",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 1",
                    SemesterID = 1,
                    DepartmentID = 2,
                },
                new Course
                {
                    CourseID = 0101000517,
                    CourseName = "Toán cơ sở",
                    Credits = "3",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 1",
                    SemesterID = 1,
                    DepartmentID = 2,
                },
                 new Course
                 {
                     CourseID = 0101000525,
                     CourseName = "Nhập môn ngành CNTT",
                     Credits = "3",
                     DepartmentName = "Khoa Công Nghệ Thông Tin",
                     SemesterName = "Học Kỳ 1",
                     SemesterID = 1,
                     DepartmentID = 2,
                 },
                 new Course
                 {
                     CourseID = 0101000746,
                     CourseName = "Triết học Mác-Lênin",
                     Credits = "3",
                     DepartmentName = "Khoa Cơ Bản",
                     SemesterName = "Học Kỳ 1",
                     SemesterID = 1,
                     DepartmentID = 3,
                 },

                 //Học kỳ 2
                 new Course
                 {
                     CourseID = 0101000003,
                     CourseName = "Pháp luật đại cương",
                     Credits = "2",
                     DepartmentName = "Khoa Cơ Bản",
                     SemesterName = "Học Kỳ 2",
                     SemesterID = 2,
                     DepartmentID = 3,
                 },
                 new Course
                 {
                     CourseID = 0101000083,
                     CourseName = "Giáo dục thể chất-Võ Cổ Truyền *",
                     Credits = "1",
                     DepartmentName = "Khoa Cơ Bản",
                     SemesterName = "Học Kỳ 2",
                     SemesterID = 2,
                     DepartmentID = 3,
                 },
                 new Course
                 {
                     CourseID = 0101000087,
                     CourseName = "Toán chuyên đề",
                     Credits = "3",
                     DepartmentName = "Khoa Công Nghệ Thông Tin",
                     SemesterName = "Học Kỳ 2",
                     SemesterID = 2,
                     DepartmentID = 2,
                 },
                 new Course
                 {
                     CourseID = 0101000510,
                     CourseName = "Kiến trúc máy tính",
                     Credits = "2",
                     DepartmentName = "Khoa Công Nghệ Thông Tin",
                     SemesterName = "Học Kỳ 2",
                     SemesterID = 2,
                     DepartmentID = 2,
                 },
                 new Course
                 {
                     CourseID = 0101000747,
                     CourseName = "Kinh tế chính trị Mác Lênin",
                     Credits = "2",
                     DepartmentName = "Khoa Cơ Bản",
                     SemesterName = "Học Kỳ 2",
                     SemesterID = 2,
                     DepartmentID = 3,
                 },
                 new Course
                 {
                     CourseID = 0101000966,
                     CourseName = "Lập trình cơ bản",
                     Credits = "3",
                     DepartmentName = "Khoa Công Nghệ Thông Tin",
                     SemesterName = "Học Kỳ 2",
                     SemesterID = 2,
                     DepartmentID = 2,
                 },

                 new Course
                 {
                     CourseID = 0101001061,
                     CourseName = "Tiếng Anh 1",
                     Credits = "3",
                     DepartmentName = "Khoa Ngoại Ngữ",
                     SemesterName = "Học Kỳ 2",
                     SemesterID = 2,
                     DepartmentID = 4,
                 },

                 //Học kỳ 3
                 new Course
                 {
                     CourseID = 0101000015,
                     CourseName = "Giáo dục quốc phòng- an ninh *",
                     Credits = "8",
                     DepartmentName = "",
                     SemesterName = "Học Kỳ 3",
                     SemesterID = 3,
                 },
                 new Course
                 {
                     CourseID = 0101000017,
                     CourseName = "Cấu trúc dữ liệu và thuật giải",
                     Credits = "3",
                     DepartmentName = "Khoa Công Nghệ Thông Tin",
                     SemesterName = "Học Kỳ 3",
                     SemesterID = 3,
                     DepartmentID = 2,
                 },
                 new Course
                 {
                     CourseID = 0101000233,
                     CourseName = "Giáo dục thể chất-Aerobic ",
                     Credits = "1",
                     DepartmentName = "Khoa Cơ Bản",
                     SemesterName = "Học Kỳ 3",
                     SemesterID = 3,
                     DepartmentID = 3,
                 },
                 new Course
                 {
                     CourseID = 0101000244,
                     CourseName = "Chủ nghĩa xã hội khoa học",
                     Credits = "2",
                     DepartmentName = "Khoa Cơ Bản",
                     SemesterName = "Học Kỳ 3",
                     SemesterID = 3,
                     DepartmentID = 3,
                 },
                 new Course
                 {
                     CourseID = 0101000395,
                     CourseName = "Hệ điều hành",
                     Credits = "3",
                     DepartmentName = "Khoa Công Nghệ Thông Tin",
                     SemesterName = "Học Kỳ 3",
                     SemesterID = 3,
                     DepartmentID = 2,
                 },
                 new Course
                 {
                     CourseID = 0101000846,
                     CourseName = "Toán rời rạc",
                     Credits = "2",
                     DepartmentName = "Khoa Công Nghệ Thông Tin",
                     SemesterName = "Học Kỳ 3",
                     SemesterID = 3,
                     DepartmentID = 2,
                 },
                 new Course
                 {
                     CourseID = 0101000848,
                     CourseName = "Lập trình hướng đối tượng",
                     Credits = "3",
                     DepartmentName = "Khoa Công Nghệ Thông Tin",
                     SemesterName = "Học Kỳ 3",
                     SemesterID = 3,
                     DepartmentID = 2,
                 },
                 new Course
                 {
                     CourseID = 0101001095,
                     CourseName = "Tiếng Anh 2",
                     Credits = "3",
                     DepartmentName = "Khoa Ngoại Ngữ",
                     SemesterName = "Học Kỳ 3",
                     SemesterID = 3,
                     DepartmentID = 4,
                 },

                 //Học kỳ 4

                 new Course
                 {
                     CourseID = 0101000016,
                     CourseName = "Tư tưởng Hồ Chí Minh",
                     Credits = "2",
                     DepartmentName = "Khoa Cơ Bản",
                     SemesterName = "Học Kỳ 4",
                     SemesterID = 3,
                     DepartmentID = 3,
                 },
                 new Course
                 {
                     CourseID = 0101000849,
                     CourseName = "Mạng máy tính",
                     Credits = "3",
                     DepartmentName = "Khoa Công Nghệ Thông Tin",
                     SemesterName = "Học Kỳ 4",
                     SemesterID = 4,
                     DepartmentID = 2,
                 },
                 new Course
                 {
                     CourseID = 0101000850,
                     CourseName = "Phân tích và thiết kế thuật giải",
                     Credits = "2",
                     DepartmentName = "Khoa Công Nghệ Thông Tin",
                     SemesterName = "Học Kỳ 4",
                     SemesterID = 4,
                     DepartmentID = 2,
                 },
                 new Course
                 {
                     CourseID = 0101000854,
                     CourseName = "Lập trình Web",
                     Credits = "3",
                     DepartmentName = "Khoa Công Nghệ Thông Tin",
                     SemesterName = "Học Kỳ 4",
                     SemesterID = 4,
                     DepartmentID = 2,
                 },
                 new Course
                 {
                     CourseID = 0101001119,
                     CourseName = "Tiếng Anh 3",
                     Credits = "3",
                     DepartmentName = "Khoa Ngoại Ngữ",
                     SemesterName = "Học Kỳ 4",
                     SemesterID = 4,
                     DepartmentID = 4,
                 },
                 new Course
                 {
                     CourseID = 0101001317,
                     CourseName = "Lý thuyết đồ thị",
                     Credits = "2",
                     DepartmentName = "Khoa Công Nghệ Thông Tin",
                     SemesterName = "Học Kỳ 4",
                     SemesterID = 4,
                     DepartmentID = 2,
                 },
                 new Course
                 {
                     CourseID = 0101000020,
                     CourseName = "Giáo dục thể chất-bóng rổ *",
                     Credits = "1",
                     DepartmentName = "Khoa Cơ Bản",
                     SemesterName = "Học Kỳ 4",
                     SemesterID = 4,
                     DepartmentID = 3,
                 },

                  //Học Kỳ 5

                  new Course
                  {
                      CourseID = 0101000524,
                      CourseName = "Lịch sử Đảng",
                      Credits = "2",
                      DepartmentName = "Khoa Cơ Bản",
                      SemesterName = "Học Kỳ 5",
                      SemesterID = 5,
                      DepartmentID = 3,
                  },
                  new Course
                  {
                      CourseID = 0101000851,
                      CourseName = "Đồ án cơ sở ngành CNTT",
                      Credits = "3",
                      DepartmentName = "Khoa Công Nghệ Thông Tin",
                      SemesterName = "Học Kỳ 5",
                      SemesterID = 5,
                      DepartmentID = 2,
                  },
                  new Course
                  {
                      CourseID = 0101000856,
                      CourseName = "Công nghệ phần mềm",
                      Credits = "3",
                      DepartmentName = "Khoa Công Nghệ Thông Tin",
                      SemesterName = "Học Kỳ 5",
                      SemesterID = 5,
                      DepartmentID = 2,
                  },
                 new Course
                 {
                     CourseID = 0101000859,
                     CourseName = "Đồ họa máy tính",
                     Credits = "3",
                     DepartmentName = "Khoa Công Nghệ Thông Tin",
                     SemesterName = "Học Kỳ 5",
                     SemesterID = 5,
                     DepartmentID = 2,
                 },
                 new Course
                 {
                     CourseID = 0101000860,
                     CourseName = "Quản trị mạng",
                     Credits = "3",
                     DepartmentName = "Khoa Công Nghệ Thông Tin",
                     SemesterName = "Học Kỳ 5",
                     SemesterID = 5,
                     DepartmentID = 2,
                 },
                 new Course
                 {
                     CourseID = 0101001120,
                     CourseName = "Tiếng Anh 4",
                     Credits = "3",
                     DepartmentName = "Khoa Ngoại Ngữ",
                     SemesterName = "Học Kỳ 5",
                     SemesterID = 5,
                     DepartmentID = 4,
                 },
                 new Course
                 {
                     CourseID = 0101000022,
                     CourseName = "Giáo dục thể chất-bóng chuyền *",
                     Credits = "1",
                     DepartmentName = "Khoa Cơ Bản",
                     SemesterName = "Học Kỳ 5",
                     SemesterID = 5,
                     DepartmentID = 3,
                 },

                 //Học Kỳ 6 

                 new Course
                 {
                     CourseID = 0101000601,
                     CourseName = "Pháp luật hàng không",
                     Credits = "2",
                     DepartmentName = "Khoa Cơ Bản",
                     SemesterName = "Học Kỳ 6",
                     SemesterID = 6,
                     DepartmentID = 3,
                 },
                 new Course
                 {
                     CourseID = 0101000855,
                     CourseName = "Lập trình thiết bị di động",
                     Credits = "3",
                     DepartmentName = "Khoa Công Nghệ Thông Tin",
                     SemesterName = "Học Kỳ 6",
                     SemesterID = 6,
                     DepartmentID = 2,
                 },
                 new Course
                 {
                     CourseID = 0101000858,
                     CourseName = "Trí tuệ nhân tạo",
                     Credits = "3",
                     DepartmentName = "Khoa Công Nghệ Thông Tin",
                     SemesterName = "Học Kỳ 6",
                     SemesterID = 6,
                     DepartmentID = 2,
                 },
                new Course
                {
                    CourseID = 0101000861,
                    CourseName = "Quản trị dự án CNTT",
                    Credits = "3",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 6",
                    SemesterID = 6,
                    DepartmentID = 2,
                },

                new Course
                {
                    CourseID = 0101000853,
                    CourseName = "Lập trình Windows +",
                    Credits = "3",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 6",
                    SemesterID = 6,
                    DepartmentID = 2,
                },
                new Course
                {
                    CourseID = 0101000863,
                    CourseName = "Cơ sở dữ liệu nâng cao +",
                    Credits = "3",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 6",
                    SemesterID = 6,
                    DepartmentID = 2,
                },
                new Course
                {
                    CourseID = 0101000865,
                    CourseName = "Lập trình Game +",
                    Credits = "3",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 6",
                    SemesterID = 6,
                    DepartmentID = 2,
                },
                new Course
                {
                    CourseID = 0101000866,
                    CourseName = "Kiểm chứng phần mềm +",
                    Credits = "3",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 6",
                    SemesterID = 6,
                    DepartmentID = 2,
                },
                new Course
                {
                    CourseID = 0101000875,
                    CourseName = "An toàn và bảo mật thông tin +",
                    Credits = "3",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 6",
                    SemesterID = 7,
                    DepartmentID = 2,
                },

                //Học Kỳ 7

                new Course
                {
                    CourseID = 0101000864,
                    CourseName = "Đồ án chuyên ngành CNTT",
                    Credits = "3",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 7",
                    SemesterID = 7,
                    DepartmentID = 2,
                },
                new Course
                {
                    CourseID = 0101000869,
                    CourseName = "Xử lý ảnh và thị giác máy tính",
                    Credits = "3",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 7",
                    SemesterID = 7,
                    DepartmentID = 2,
                },
                new Course
                {
                    CourseID = 0101000872,
                    CourseName = "Lập trình Python",
                    Credits = "3",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 7",
                    SemesterID = 7,
                    DepartmentID = 2,
                },
                new Course
                {
                    CourseID = 0101000857,
                    CourseName = "Hệ quản trị cơ sở dữ liệu +",
                    Credits = "3",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 7",
                    SemesterID = 7,
                    DepartmentID = 2,
                },
                new Course
                {
                    CourseID = 0101000862,
                    CourseName = "Phân tích thiết kế hệ thống +",
                    Credits = "3",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 7",
                    SemesterID = 7,
                    DepartmentID = 2,
                },
                new Course
                {
                    CourseID = 0101000867,
                    CourseName = "Máy học +",
                    Credits = "3",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 7",
                    SemesterID = 7,
                    DepartmentID = 2,
                },
                new Course
                {
                    CourseID = 0101000868,
                    CourseName = "Lập trình mạng +",
                    Credits = "3",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 7",
                    SemesterID = 7,
                    DepartmentID = 2,
                },
                new Course
                {
                    CourseID = 0101000967,
                    CourseName = "Xây dựng ứng dụng thương mại điện tử +",
                    Credits = "3",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 7",
                    SemesterID = 7,
                    DepartmentID = 2,
                },


                //Học Kỳ 8 
                new Course
                {
                    CourseID = 0101000878,
                    CourseName = "Thực tập tốt nghiệp CNTT",
                    Credits = "4",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 8",
                    SemesterID = 8,
                    DepartmentID = 2,
                },
                new Course
                {
                    CourseID = 0101000870,
                    CourseName = "Internet vạn vật (IoT) +",
                    Credits = "3",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 8",
                    SemesterID = 8,
                    DepartmentID = 2,
                },
                new Course
                {
                    CourseID = 0101000871,
                    CourseName = "Điện toán đám mây +",
                    Credits = "3",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 8",
                    SemesterID = 8,
                    DepartmentID = 2,
                },
                new Course
                {
                    CourseID = 0101000873,
                    CourseName = "Khai thác dữ liệu +",
                    Credits = "3",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 8",
                    SemesterID = 8,
                    DepartmentID = 2,
                },
                new Course
                {
                    CourseID = 0101000874,
                    CourseName = "Dữ liệu lớn +",
                    Credits = "3",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 8",
                    SemesterID = 8,
                    DepartmentID = 2,
                },
                new Course
                {
                    CourseID = 0101000876,
                    CourseName = "Công nghệ chuỗi khối +",
                    Credits = "3",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 8",
                    SemesterID = 8,
                    DepartmentID = 2,
                },
                new Course
                {
                    CourseID = 0101000877,
                    CourseName = "Mạng nơron và ứng dụng +",
                    Credits = "3",
                    DepartmentName = "Khoa Công Nghệ Thông Tin",
                    SemesterName = "Học Kỳ 8",
                    SemesterID = 8,
                    DepartmentID = 2,
                },
                 new Course
                 {
                     CourseID = 0101000879,
                     CourseName = "Khóa luận tốt nghiệp CNTT +",
                     Credits = "6",
                     DepartmentName = "Khoa Công Nghệ Thông Tin",
                     SemesterName = "Học Kỳ 6",
                     SemesterID = 8,
                     DepartmentID = 2,
                 });

            //End Course
            modelBuilder.Entity<Grades>(entity =>
            {
                entity.HasKey(e => e.GradeID);
                entity.Property(e => e.GradeID).ValueGeneratedOnAdd();

                // Các cấu hình khác cho các thuộc tính còn lại[QLHS]
            });

            modelBuilder.Entity<Grades>().HasData(
                new Grades
                {
                    GradeID = 1, // Bạn có thể bỏ qua dòng này nếu không muốn tự đặt giá trị cho GradeID
                    SemesterID = null,
                    StudentID = null,
                    StudentName = null,
                    CourseID = null,
                    CourseName = null,
                    MidScores = null,
                    FinalScores = null,
                    StudentCategory = null
                }
            );
        }
    }
}
