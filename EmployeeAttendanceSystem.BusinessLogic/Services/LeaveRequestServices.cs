using EmployeeAttendanceSystem.DataAccess.Context;
using EmployeeAttendanceSystem.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendanceSystem.BusinessLogic.Services
{
    public class LeaveRequestServices
    {
        AttendanceContext context;
        public LeaveRequestServices(AttendanceContext context)
        {
            this.context = context;
        }

        public List<LeaveRequest> getAll()
        {
            return context.LeaveRequests.ToList();
        }

        public void Add(LeaveRequest request)
        {
            context.LeaveRequests.Add(request);
            context.SaveChanges();
        }
        public LeaveRequest getById(int request_id)
        {
            return context.LeaveRequests.FirstOrDefault(x => x.id == request_id);
        }
        public List<LeaveRequest> ShowByEmployeeId(int employee_id)
        {
            return context.LeaveRequests.Where(x => x.employeeId == employee_id).ToList() ;
        }

        public void cancelRequest(int request_id)
        {
            context.LeaveRequests.Remove(getById(request_id));
            context.SaveChanges();
        }
    }
}
