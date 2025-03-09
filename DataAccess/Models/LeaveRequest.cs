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
        approaved ,
        rejected , 
        pending 
    }
    public  class LeaveRequest
    {
        public int id { get; set; }
        public string? LeaveReason { get; set; }
        public DateTime requestDate { get; set; }
        public DateTime LeaveStartTime { get; set; }
        public DateTime LeaveEndTime { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public LeaverequestStatus requestStatus { get; set; } = LeaverequestStatus.pending;
        [ForeignKey("Employee")]
        public int employeeId { get; set; }
        public virtual Employee Employee { get; set; }
        
    }
}
