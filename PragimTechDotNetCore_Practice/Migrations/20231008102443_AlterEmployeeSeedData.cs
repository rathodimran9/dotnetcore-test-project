using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PragimTechDotNetCore_Practice.Migrations
{
    /// <inheritdoc />
    public partial class AlterEmployeeSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Email", "Name" },
                values: new object[] { 3, 2, "ajaz@gmail.com", "Imran" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
