using EmployeeAttendanceSystem.DataAccess.Context;
using EmployeeAttendanceSystem.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAttendanceSystem.BusinessLogic.Services
{
    public class AttendanceServices
    {
        AttendanceContext context;
        public AttendanceServices(AttendanceContext context)
        {
           this.context = context;
        }
        public List<Attendance> getAll()
        {
            return context.Attendances.ToList();
        }
        public Attendance GetByempIdAndCheckIn(int employee_id , DateTime date)
        {
            return context.Attendances.FirstOrDefault(x => x.Employee_id == employee_id && x.checkInTime.Value.Date == date);
        }

        //show all dates in combobox
        public List<DateTime> GetAllDates()
        {
            return context.Attendances.Where(e => e.checkInTime.HasValue)
                .Select(e => e.checkInTime.Value.Date)
                .Distinct()
                .ToList();
        }
        public List<Attendance> GetAttendanceByEmployee(int empId)
        {
            return context.Attendances.Where(e => e.Employee_id == empId)
                .Include(e => e.Employee)
                .ToList();
        }
        public List<Attendance> GetAttendanceByDate(DateTime date)
        {
            return context.Attendances.Where(e => e.checkInTime.Value.Date == date.Date)
                .Include(e => e.Employee)
                .ToList();
        }
        //in case hr
        public List<Attendance> GetAttendanceByEmpIdAndDate(int empId, DateTime date)
        {
            return context.Attendances.Where(e => e.Employee_id == empId && e.checkInTime.HasValue && e.checkInTime.Value.Date == date)
                .Include(e => e.Employee)
                .ToList();
        }
        public void Add(Attendance attendance)
        {
            context.Attendances.Add(attendance);
            context.SaveChanges();
        }

        public void checkOut(int employee_id , DateTime date ,Attendance attendance)
        {
            Attendance existing = GetByempIdAndCheckIn(employee_id, date.Date);
            existing.checkOutTime = attendance.checkOutTime;
            existing.IsEarlyDeparture = attendance.IsEarlyDeparture;
            context.SaveChanges();
        }
        // reports form
        public List<Attendance> GetDailyAttendance(DateTime date)
        {
            return context.Attendances.Where(a => a.checkInTime.HasValue && a.checkInTime.Value.Date ==date.Date)
                .Include(a => a.Employee).ToList();
                
        }
        public List<Attendance> GetMonthlyAttendance(int year ,int month , int empId)
        {
            return context.Attendances.Where(a=> a.checkInTime.HasValue 
            && a.checkInTime.Value.Year == year &&
            a.checkInTime.Value.Month == month &&
            a.Employee_id == empId)
                .Include(a=> a.Employee).ToList();
        }
    }
}
