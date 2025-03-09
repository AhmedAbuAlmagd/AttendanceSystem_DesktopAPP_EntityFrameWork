using EmployeeAttendanceSystem.DataAccess.Context;
using EmployeeAttendanceSystem.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendanceSystem.BusinessLogic.Services
{
    public class LogsServices
    {
        AttendanceContext context;
        public LogsServices(AttendanceContext context)
        {
            this.context = context;
        }

        public List<Log> GetAll()
        {
            return context.Logs.ToList();
        }

        public void Add(Log log)
        {
            context.Logs.Add(log);
            context.SaveChanges();
        }
    }
}
