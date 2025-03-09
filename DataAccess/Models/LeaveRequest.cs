using EmployeeAttendanceSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendanceSystem.DataAccess.Models
{
    public enum LeaverequestStatus
    {
        Approved ,
        Rejected , 
        Pending 
    }
    public enum LeaveType
    {
        Sick_Leave,
        Vacation_Leave,
        Unpaid_Leave
    }
    public  class LeaveRequest
    {
        public int id { get; set; }
        public string? LeaveReason { get; set; }
        public DateTime requestDate { get; set; }
        public DateTime LeaveStartTime { get; set; }
        public DateTime LeaveEndTime { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public LeaverequestStatus requestStatus { get; set; } = LeaverequestStatus.Pending;
        public LeaveType requestType { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        
    }
}
