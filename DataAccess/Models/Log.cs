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
    public enum Action
    {
        checkIn , 
        checkOut ,
        leaveRequest, 
    }
    public enum Attendance_Status
    {
        present,
        absent,
        late ,
        early_departure
    }
    public class Log
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public Action action { get; set; }  
        public DateTime actionTime {  get; set; }
        public Attendance_Status? attendance_Status  { get; set; }

        [ForeignKey("Employee")]
        public int empoloyeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
