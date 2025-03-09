using EmployeeAttendanceSystem.DataAccess.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAttendanceSystem.Models
{
    public enum workSchedule
    {
        fullTime,
        partTime,
        remote
    }
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        [EmailAddress]
        public string email { get; set; }
        public string phone { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public workSchedule workSchedule { get; set; }
        [ForeignKey("Department")]
        public int deptId { get; set; }
        public virtual Department Department { get; set; }
        public virtual List<Attendance> Attendances { get; set; } = new List<Attendance>();
        public virtual List<Log> Logs { get; set; } = new List<Log>();
        public virtual List<LeaveRequest> LeaveRequests { get; set; } = new List<LeaveRequest>();
        public virtual User User { get; set; }
    }
}
