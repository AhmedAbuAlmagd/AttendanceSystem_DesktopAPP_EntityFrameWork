using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeAttendanceSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class classes_update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_employeeId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "department",
                table: "Employees");

            migrationBuilder.CreateIndex(
                name: "IX_Users_employeeId",
                table: "Users",
                column: "employeeId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_employeeId",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "department",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Users_employeeId",
                table: "Users",
                column: "employeeId");
        }
    }
}
