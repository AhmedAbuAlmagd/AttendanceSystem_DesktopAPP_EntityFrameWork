using System.Configuration;
using EmployeeAttendanceSystem.DataAccess.Models;
using EmployeeAttendanceSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeAttendanceSystem.DataAccess.Context
{
    public class AttendanceContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(ConfigurationManager.ConnectionStrings["EmployeeDbContext"].ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>()
                .Property(a => a.WorkingHours)
                .HasComputedColumnSql("DATEDIFF(SECOND, CAST(checkInTime AS DATETIME), CAST(checkOutTime AS DATETIME)) / 3600", stored: true);

            modelBuilder.Entity<Attendance>()
          .Property(a => a.IsLate)
          .HasConversion(
              v => v ? "Yes" : "No", // Convert bool to string
              v => v == "Yes" // Convert string to bool
          );
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<LeaveRequest> LeaveRequests { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
