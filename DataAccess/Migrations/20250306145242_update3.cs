using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeAttendanceSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Employees_employeeId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_employeeId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "employeeId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "attendance_Status",
                table: "Logs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_employeeId",
                table: "Users",
                column: "employeeId",
                unique: true,
                filter: "[employeeId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Employees_employeeId",
                table: "Users",
                column: "employeeId",
                principalTable: "Employees",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Employees_employeeId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_employeeId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "attendance_Status",
                table: "Logs");

            migrationBuilder.AlterColumn<int>(
                name: "employeeId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_employeeId",
                table: "Users",
                column: "employeeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Employees_employeeId",
                table: "Users",
                column: "employeeId",
                principalTable: "Employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
