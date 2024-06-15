using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLHS.Migrations
{
    /// <inheritdoc />
    public partial class migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 30L);

            migrationBuilder.AlterColumn<double>(
                name: "TotalScore",
                table: "Grades",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "StudentName",
                table: "Grades",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<long>(
                name: "StudentID",
                table: "Grades",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "SemesterID",
                table: "Grades",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<double>(
                name: "MidScores",
                table: "Grades",
                type: "float",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<double>(
                name: "FinalScores",
                table: "Grades",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "CourseName",
                table: "Grades",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<long>(
                name: "CourseID",
                table: "Grades",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "StudentCategory",
                table: "Grades",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 1L,
                columns: new[] { "CourseID", "CourseName", "FinalScores", "MidScores", "SemesterID", "StudentCategory", "StudentID", "StudentName", "TotalScore" },
                values: new object[] { null, null, null, null, null, null, null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentCategory",
                table: "Grades");

            migrationBuilder.AlterColumn<double>(
                name: "TotalScore",
                table: "Grades",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StudentName",
                table: "Grades",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "StudentID",
                table: "Grades",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "SemesterID",
                table: "Grades",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "MidScores",
                table: "Grades",
                type: "float",
                maxLength: 100,
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "FinalScores",
                table: "Grades",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CourseName",
                table: "Grades",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CourseID",
                table: "Grades",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "GradeID",
                keyValue: 1L,
                columns: new[] { "CourseID", "CourseName", "FinalScores", "MidScores", "SemesterID", "StudentID", "StudentName", "TotalScore" },
                values: new object[] { 101000001L, "Tổng quan về Hàng không dân dụng", 6.5, 7.0, 1L, 2254810177L, "Lê Tấn Đạt ", 0.0 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "GradeID", "CourseID", "CourseName", "FinalScores", "MidScores", "SemesterID", "StudentID", "StudentName", "TotalScore" },
                values: new object[,]
                {
                    { 2L, 101000001L, "Tổng quan về Hàng không dân dụng", 7.0, 7.5, 1L, 2254810159L, "Đặng Nhật Hào", 0.0 },
                    { 3L, 101000001L, "Tổng quan về Hàng không dân dụng", 5.0, 10.0, 1L, 2254810196L, "Nguyễn Quốc Trí", 0.0 },
                    { 4L, 101000001L, "Tổng quan về Hàng không dân dụng", 7.0, 8.0, 1L, 2254810246L, "Trần Đình Anh Duy", 0.0 },
                    { 5L, 101000001L, "Tổng quan về Hàng không dân dụng", 9.0, 7.0, 1L, 2254810192L, "Trần Huy Hoàng", 0.0 },
                    { 6L, 101000009L, "Giáo dục thể chất - Sức nhanh", 6.5, 0.0, 1L, 2254810177L, "Lê Tấn Đạt", 0.0 },
                    { 7L, 101000009L, "Giáo dục thể chất - Sức nhanh", 6.7999999999999998, 0.0, 1L, 2254810159L, "Đặng Nhật Hào", 0.0 },
                    { 8L, 101000009L, "Giáo dục thể chất - Sức nhanh", 7.0, 0.0, 1L, 2254810246L, "Trần Đình Anh Duy", 0.0 },
                    { 9L, 101000009L, "Giáo dục thể chất - Sức nhanh", 6.0, 0.0, 1L, 2254810196L, "Nguyễn Quốc Trí", 0.0 },
                    { 10L, 101000009L, "Giáo dục thể chất - Sức nhanh", 7.0, 0.0, 1L, 2254810192L, "Trần Huy Hoàng", 0.0 },
                    { 11L, 101000373L, "Cơ sở dữ liệu", 6.2999999999999998, 6.0, 1L, 2254810177L, "Lê Tấn Đạt", 0.0 },
                    { 12L, 101000373L, "Cơ sở dữ liệu", 6.0, 6.5, 1L, 2254810159L, "Đặng Nhật Hào", 0.0 },
                    { 13L, 101000373L, "Cơ sở dữ liệu", 6.5, 9.0, 1L, 2254810196L, "Nguyễn Quốc Trí", 0.0 },
                    { 14L, 101000373L, "Cơ sở dữ liệu", 7.5, 7.0, 1L, 2254810246L, "Trần Đình Anh Duy", 0.0 },
                    { 15L, 101000373L, "Cơ sở dữ liệu", 5.5, 7.5, 1L, 2254810192L, "Trần Huy Hoàng", 0.0 },
                    { 16L, 101000517L, "Toán cơ sở", 6.5, 5.0, 1L, 2254810177L, "Lê Tấn Đạt", 0.0 },
                    { 17L, 101000517L, "Toán cơ sở", 5.5, 6.0, 1L, 2254810159L, "Đặng Nhật Hào", 0.0 },
                    { 18L, 101000517L, "Toán cơ sở", 7.5, 7.0, 1L, 2254810246L, "Trần Đình Anh Duy", 0.0 },
                    { 19L, 101000517L, "Toán cơ sở", 7.5, 5.5, 1L, 2254810196L, "Nguyễn Quốc Trí", 0.0 },
                    { 20L, 101000517L, "Toán cơ sở", 6.5, 6.0, 1L, 2254810177L, "Trần Huy Hoàng", 0.0 },
                    { 21L, 101000525L, "Nhập môn ngành CNTT", 5.5, 7.0, 1L, 2254810177L, "Lê Tấn Đạt", 0.0 },
                    { 22L, 101000525L, "Nhập môn ngành CNTT", 6.5, 7.0, 1L, 2254810177L, "Đặng Nhật Hào", 0.0 },
                    { 23L, 101000525L, "Nhập môn ngành CNTT", 7.5, 8.0, 1L, 2254810246L, "Trần Đình Anh Duy", 0.0 },
                    { 24L, 101000525L, "Nhập môn ngành CNTT", 6.7999999999999998, 8.0, 1L, 2254810196L, "Nguyễn Quốc Trí", 0.0 },
                    { 25L, 101000525L, "Nhập môn ngành CNTT", 7.5, 7.0, 1L, 2254810192L, "Trần Huy Hoàng", 0.0 },
                    { 26L, 101000746L, "Triết học Mác-Lênin", 5.4000000000000004, 8.5, 1L, 2254810177L, "Lê Tấn Đạt", 0.0 },
                    { 27L, 101000746L, "Triết học Mác-Lênin", 6.5, 7.0, 1L, 2254810159L, "Đặng Nhật Hàov", 0.0 },
                    { 28L, 101000746L, "Triết học Mác-Lênin", 7.5, 9.0, 1L, 2254810246L, "Trần Đình Anh Duy", 0.0 },
                    { 29L, 101000746L, "Triết học Mác-Lênin", 7.5, 8.0, 1L, 2254810196L, "Nguyễn Quốc Trí", 0.0 },
                    { 30L, 101000746L, "Triết học Mác-Lênin", 5.5, 8.0, 1L, 2254810192L, "Trần Huy Hoàng", 0.0 }
                });
        }
    }
}
