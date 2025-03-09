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
    public enum role
    {
        Admin , 
        HR , 
        Employee
    }
    public class User
    {
        [Key]
        public int id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public role role { get; set; }
        [ForeignKey("Employee")]
        public int? employeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
