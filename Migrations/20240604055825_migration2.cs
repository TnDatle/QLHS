using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLHS.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    StudentID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentPW = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserRole = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "LoginTC",
                columns: table => new
                {
                    TeacherID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherPW = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserRole = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginTC", x => x.TeacherID);
                });

            migrationBuilder.InsertData(
                table: "Login",
                columns: new[] { "StudentID", "StudentPW", "UserRole" },
                values: new object[,]
                {
                    { 2254810159L, "01072004", "Student", 1},
                    { 2254810177L, "21112004" ,"Student", 1},
                    { 2254810192L, "10022004" ,"Student", 1},
                    { 2254810196L, "28022004" ,"Student", 1},
                    { 2254810246L, "16012004", "Student", 1}
                });

            migrationBuilder.InsertData(
                table: "LoginTC",
                columns: new[] { "TeacherID", "TeacherPW", "TeacherRole" },
                values: new object[,]
                {
                    { 1000002024L, "HVHK@2023" ,"Teacher", 2},
                    { 2000002024L, "HVHK@2024" ,"Teacher", 2},
                    { 3000002024L, "HVHK@2025" ,"Teacher", 2}
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "LoginTC");
        }
    }
}
