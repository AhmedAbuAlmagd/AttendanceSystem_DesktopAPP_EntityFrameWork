using EmployeeAttendanceSystem.DataAccess.Context;
using EmployeeAttendanceSystem.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeAttendanceSystem.BusinessLogic.Services
{
    public class AttendanceServices
    {
        private readonly AttendanceContext context;

        public AttendanceServices(AttendanceContext context)
        {
            this.context = context;
        }

        public List<Attendance> GetAll()
        {
            return context.Attendances.ToList();
        }

        public Attendance GetByEmployeeIdAndDate(int employeeId, DateOnly date)
        {
            return context.Attendances
                .FirstOrDefault(x => x.Employee_id == employeeId && x.Date == date);
        }

        public List<DateOnly> GetAllDates()
        {
            return context.Attendances.Select(e => e.Date).Distinct().ToList();
        }

        public List<Attendance> GetAttendanceByEmployee(int empId)
        {
            return context.Attendances
                .Where(e => e.Employee_id == empId)
                .Include(e => e.Employee)
                .ToList();
        }

        public List<Attendance> GetAttendanceByDate(DateOnly date)
        {
            return context.Attendances
                .Where(e => e.Date == date)
                .Include(e => e.Employee)
                .ToList();
        }

        public List<Attendance> GetAttendanceByEmpIdAndDate(int empId, DateOnly date)
        {
            return context.Attendances
                .Where(e => e.Employee_id == empId && e.Date == date)
                .Include(e => e.Employee)
                .ToList();
        }

        public void Add(Attendance attendance)
        {
            context.Attendances.Add(attendance);
            context.SaveChanges();
        }

        public void CreateDailyAttendanceRecords()
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            if (today.DayOfWeek != DayOfWeek.Friday && today.DayOfWeek != DayOfWeek.Saturday)
            {
                var employees = context.Employees.ToList();
                foreach (var employee in employees)
                {
                    var existingRecord = GetByEmployeeIdAndDate(employee.id, today);
                    if (existingRecord == null)
                    {
                        var attendance = new Attendance
                        {
                            Employee_id = employee.id,
                            Date = today,
                            checkInTime = null,
                            checkOutTime = null,
                            WorkingHours = null,
                            attendanceStatus = AttendanceStatus.Absent,
                            IsLate = false,
                            IsEarlyDeparture = false
                        };
                        context.Attendances.Add(attendance);
                    }
                }
                context.SaveChanges();
            }
        }

        public void CheckIn(int employeeId)
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var attendance = GetByEmployeeIdAndDate(employeeId, today);

            if (attendance == null)
            {
                throw new InvalidOperationException("Attendance record not found for today.");
            }

            if (attendance.checkInTime.HasValue)
            {
                throw new InvalidOperationException("You have already checked in today.");
            }

            var now = TimeOnly.FromDateTime(DateTime.Now);
            attendance.checkInTime = now;
            attendance.attendanceStatus = AttendanceStatus.Present;
            attendance.IsLate = now > new TimeOnly(9, 0, 0);

            context.SaveChanges();
        }

        public void CheckOut(int employeeId)
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var attendance = GetByEmployeeIdAndDate(employeeId, today);

            if (attendance == null)
            {
                throw new InvalidOperationException("No attendance record found for today.");
            }

            if (!attendance.checkInTime.HasValue)
            {
                throw new InvalidOperationException("You haven’t checked in today.");
            }

            if (attendance.checkOutTime.HasValue)
            {
                throw new InvalidOperationException("You have already checked out today.");
            }

            var now = TimeOnly.FromDateTime(DateTime.Now);
            attendance.checkOutTime = now;
            attendance.WorkingHours = (int?)((now - attendance.checkInTime.Value).TotalHours);
            attendance.IsEarlyDeparture = now < new TimeOnly(17, 0, 0);

            context.SaveChanges();
        }

        public List<Attendance> GetDailyAttendance(DateOnly date)
        {
            return context.Attendances
                .Where(a => a.Date == date)
                .Include(a => a.Employee)
                .ToList();
        }

        public List<Attendance> GetMonthlyAttendance(int year, int month, int empId)
        {
            return context.Attendances
                .Where(a => a.Date.Year == year && a.Date.Month == month && a.Employee_id == empId)
                .Include(a => a.Employee)
                .ToList();
        }
    }
}