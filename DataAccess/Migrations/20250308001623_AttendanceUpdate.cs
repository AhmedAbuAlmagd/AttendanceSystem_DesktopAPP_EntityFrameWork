using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeAttendanceSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AttendanceUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkingHours",
                table: "Attendances",
                type: "int",
                nullable: true,
                computedColumnSql: "ISNULL(DATEDIFF(second, [checkInTime], [checkOutTime]), 0)",
                stored: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkingHours",
                table: "Attendances");
        }
    }
}
