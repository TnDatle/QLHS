﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLHS;

#nullable disable

namespace QLHS.Migrations
{
    [DbContext(typeof(EFDbContext))]
    [Migration("20240604055825_migration2")]
    partial class migration2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QLHS.Models.Login", b =>
                {
                    b.Property<long>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("StudentID"));

                    b.Property<string>("StudentPW")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("StudentID");

                    b.ToTable("Login");

                    b.HasData(
                        new
                        {
                            StudentID = 2254810177L,
                            StudentPW = "21112004"
                        },
                        new
                        {
                            StudentID = 2254810159L,
                            StudentPW = "01072004"
                        },
                        new
                        {
                            StudentID = 2254810196L,
                            StudentPW = "28022004"
                        },
                        new
                        {
                            StudentID = 2254810246L,
                            StudentPW = "16012004"
                        },
                        new
                        {
                            StudentID = 2254810192L,
                            StudentPW = "10022004"
                        });
                });

            modelBuilder.Entity("QLHS.Models.LoginTC", b =>
                {
                    b.Property<long>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("TeacherID"));

                    b.Property<string>("TeacherPW")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("TeacherID");

                    b.ToTable("LoginTC");

                    b.HasData(
                        new
                        {
                            TeacherID = 1000002024L,
                            TeacherPW = "HVHK@2023"
                        },
                        new
                        {
                            TeacherID = 2000002024L,
                            TeacherPW = "HVHK@2024"
                        },
                        new
                        {
                            TeacherID = 3000002024L,
                            TeacherPW = "HVHK@2025"
                        });
                });

            modelBuilder.Entity("QLHS.Models.Student", b =>
                {
                    b.Property<long>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("StudentID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("DayOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("StudentID");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            StudentID = 2254810177L,
                            Address = "TP.Hồ Chí Minh",
                            Class = "22ĐHTT04",
                            DayOfBirth = new DateTime(2004, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "2254810177@vaa.edu.vn",
                            Gender = "Nam",
                            PhoneNumber = "0123456789",
                            StudentName = "Lê Tấn Đạt"
                        },
                        new
                        {
                            StudentID = 2254810159L,
                            Address = "TP.Hồ Chí Minh",
                            Class = "22ĐHTT04",
                            DayOfBirth = new DateTime(2004, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "2254810159@vaa.edu.vn",
                            Gender = "Nam",
                            PhoneNumber = "0123456968",
                            StudentName = "Đặng Nhật Hào"
                        },
                        new
                        {
                            StudentID = 2254810196L,
                            Address = "TP.Hồ Chí Minh",
                            Class = "22ĐHTT04",
                            DayOfBirth = new DateTime(2004, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "2254810196@vaa.edu.vn",
                            Gender = "Nam",
                            PhoneNumber = "0123456968",
                            StudentName = "Nguyễn Quốc Trí"
                        },
                        new
                        {
                            StudentID = 2254810246L,
                            Address = "TP.Hồ Chí Minh",
                            Class = "22ĐHTT04",
                            DayOfBirth = new DateTime(2004, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "2254810159@vaa.edu.vn",
                            Gender = "Nam",
                            PhoneNumber = "0123456968",
                            StudentName = "Trần Đình Anh Duy"
                        },
                        new
                        {
                            StudentID = 2254810192L,
                            Address = "Đồng Nai",
                            Class = "22ĐHTT04",
                            DayOfBirth = new DateTime(2004, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "2254810192@vaa.edu.vn",
                            Gender = "Nam",
                            PhoneNumber = "0123456789",
                            StudentName = "Trần Huy Hoàng"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
