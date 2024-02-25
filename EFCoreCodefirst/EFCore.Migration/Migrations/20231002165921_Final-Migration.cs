using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreCodefirst.Migrations
{
    /// <inheritdoc />
    public partial class FinalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Enrollments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumns: new[] { "SectionId", "StudentId" },
                keyValues: new object[] { 6, 1 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumns: new[] { "SectionId", "StudentId" },
                keyValues: new object[] { 6, 2 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumns: new[] { "SectionId", "StudentId" },
                keyValues: new object[] { 7, 3 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumns: new[] { "SectionId", "StudentId" },
                keyValues: new object[] { 7, 4 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumns: new[] { "SectionId", "StudentId" },
                keyValues: new object[] { 8, 5 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumns: new[] { "SectionId", "StudentId" },
                keyValues: new object[] { 8, 6 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumns: new[] { "SectionId", "StudentId" },
                keyValues: new object[] { 9, 7 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumns: new[] { "SectionId", "StudentId" },
                keyValues: new object[] { 9, 8 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumns: new[] { "SectionId", "StudentId" },
                keyValues: new object[] { 10, 9 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumns: new[] { "SectionId", "StudentId" },
                keyValues: new object[] { 10, 10 },
                column: "Id",
                value: 0);
        }
    }
}
