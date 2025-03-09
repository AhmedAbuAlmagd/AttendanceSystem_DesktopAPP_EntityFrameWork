using EmployeeAttendanceSystem.DataAccess.Context;
using EmployeeAttendanceSystem.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
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
            return context.LeaveRequests.Where(x => x.EmployeeId == employee_id).ToList() ;
        }

        public void cancelRequest(int request_id)
        {
            context.LeaveRequests.Remove(getById(request_id));
            context.SaveChanges();
        }

        // Show Requests Form
        public List<object> GetAllPendingRequests()

        {
            return context.LeaveRequests
         .Where(r => r.requestStatus == LeaverequestStatus.Pending)
         .Select(r => new
         {
             r.id,
             r.EmployeeId,
             EmployeeName = r.Employee.name,
             r.requestDate,
             r.LeaveStartTime,
             r.LeaveEndTime,
             r.LeaveReason,
             r.requestType,
             r.requestStatus
         })
         .ToList<object>();
        }
        //show req by emp id
        public List<object> ShowRequestsByEmpId(int empId)
        {
            return context.LeaveRequests.Where(r => r.EmployeeId == empId)
                .Select(r => new
                {
                    r.id,
                    r.EmployeeId,
                    EmployeeName = r.Employee.name,
                    r.requestDate,
                    r.LeaveStartTime,
                    r.LeaveEndTime,
                    r.LeaveReason,
                    r.requestType,
                    r.requestStatus
                })
                .ToList<object>();
                
        }

        //fun to show emp names in combobox in showRequests form
        public List<object> GetEmployee()
        {
            return context.Employees.Select(e => new { Id = e.id, Name = e.name }).ToList<object>();
        }

        //update status of request 
        public void UpdateRequestStatus(int requestId ,  LeaverequestStatus NewStatus)
        {
            var request = context.LeaveRequests.FirstOrDefault(r => r.id == requestId);
            if(request != null)
            {
                request.requestStatus = NewStatus;
                context.SaveChanges();
            }
        }
    }
        
}

