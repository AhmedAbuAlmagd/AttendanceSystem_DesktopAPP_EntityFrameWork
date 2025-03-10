    using EmployeeAttendanceSystem.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace EmployeeAttendanceSystem.DataAccess.Models
    {
        public class Attendance
        {
            [Key]
            public int id { get; set; }
            public DateOnly Date { get; set; }
            public TimeOnly? checkInTime { get; set; }
            public TimeOnly? checkOutTime { get; set; }
            public int? WorkingHours { get; set; }

            [Column(TypeName = "nvarchar(20)")]
            public AttendanceStatus attendanceStatus { get; set; } = AttendanceStatus.Absent;
            public bool IsLate {  get; set; } 
            public bool IsEarlyDeparture { get; set; }

            [ForeignKey("Employee")]
            public int Employee_id { get; set; }
            public virtual Employee Employee { get; set; }
        }

        public enum AttendanceStatus
        {
            Present ,
            Absent ,
            LeaveRequest
        }
    }
