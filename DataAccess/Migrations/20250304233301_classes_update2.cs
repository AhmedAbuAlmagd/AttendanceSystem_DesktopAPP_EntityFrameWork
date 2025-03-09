using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeAttendanceSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class classes_update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEarlyDeparture",
                table: "Attendances",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsLate",
                table: "Attendances",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEarlyDeparture",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "IsLate",
                table: "Attendances");
        }
    }
}
