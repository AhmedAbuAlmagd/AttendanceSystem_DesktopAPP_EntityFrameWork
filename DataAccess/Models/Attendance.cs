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
        public DateTime? checkInTime { get; set; }
        public DateTime? checkOutTime { get; set; }
        public int? WorkingHours { get; set; }
        public bool? IsLate { get; set; }
        public bool? IsEarlyDeparture { get; set; }

        [ForeignKey("Employee")]
        public int Employee_id { get; set; }
        public virtual Employee Employee { get; set; }

    }
}
