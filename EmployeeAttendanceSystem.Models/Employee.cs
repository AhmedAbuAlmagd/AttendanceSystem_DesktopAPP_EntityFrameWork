using System.ComponentModel.DataAnnotations;

namespace EmployeeAttendanceSystem.Models
{
    public enum workSchedule
    {
        fullTime , 
        partTime,
        remote 
    }
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string department { get; set; }
        public string position { get; set; }
        [EmailAddress]
        public string email { get; set; }
        public string phone { get; set; }
        public workSchedule workSchedule { get; set; }
     
    }
}
