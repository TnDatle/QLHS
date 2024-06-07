using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLHS.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DayOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentID);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentID", "Address", "Class", "DayOfBirth", "Email", "Gender", "PhoneNumber", "StudentName" },
                values: new object[,]
                {
                    { 2254810159L, "TP.Hồ Chí Minh", "22ĐHTT04", new DateTime(2004, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2254810159@vaa.edu.vn", "Nam", "0123456968", "Đặng Nhật Hào" },
                    { 2254810177L, "TP.Hồ Chí Minh", "22ĐHTT04", new DateTime(2004, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "2254810177@vaa.edu.vn", "Nam", "0123456789", "Lê Tấn Đạt" },
                    { 2254810192L, "Đồng Nai", "22ĐHTT04", new DateTime(2004, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "2254810192@vaa.edu.vn", "Nam", "0123456789", "Trần Huy Hoàng" },
                    { 2254810196L, "TP.Hồ Chí Minh", "22ĐHTT04", new DateTime(2004, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "2254810196@vaa.edu.vn", "Nam", "0123456968", "Nguyễn Quốc Trí" },
                    { 2254810246L, "TP.Hồ Chí Minh", "22ĐHTT04", new DateTime(2004, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "2254810159@vaa.edu.vn", "Nam", "0123456968", "Trần Đình Anh Duy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
