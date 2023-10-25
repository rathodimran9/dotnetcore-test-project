using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PragimTechDotNetCore_Practice.Migrations
{
    /// <inheritdoc />
    public partial class AlterEmployeeSeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Ajaz");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Imran");
        }
    }
}
