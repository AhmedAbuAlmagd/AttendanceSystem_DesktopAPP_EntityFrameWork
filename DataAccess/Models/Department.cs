using EmployeeAttendanceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendanceSystem.DataAccess.Models
{
    public class Department
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual List<Employee> Employees { get; set; } = new List<Employee>();

    }
}
