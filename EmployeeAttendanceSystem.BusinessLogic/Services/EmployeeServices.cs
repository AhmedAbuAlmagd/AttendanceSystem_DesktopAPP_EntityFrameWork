    using EmployeeAttendanceSystem.DataAccess.Context;
    using EmployeeAttendanceSystem.DataAccess.Models;
    using EmployeeAttendanceSystem.Models;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace EmployeeAttendanceSystem.BusinessLogic.Services
    {
        public class EmployeeServices
        {
            AttendanceContext context;
            public EmployeeServices(AttendanceContext context)
            {
               this.context = context;
            }
            public Employee GetById(int id )
            {
                return context.Employees.FirstOrDefault(x => x.id == id);
            }
            public Employee GetByEmail(string email)
            {
                return context.Employees.FirstOrDefault(x => x.email == email);
            }
            public List<Employee> GetAll()
            {
                return context.Employees.ToList();
            }

            public void Add(Employee employee)
            {
                if (string.IsNullOrEmpty(employee.name))
                    throw new ArgumentException("Employee name is required.");
                if (GetByEmail(employee.email) != null)
                    throw new InvalidOperationException("Email already exists.");
                context.Employees.Add(employee);
                context.SaveChanges();
            }
   
            public void Update(int id,Employee employee)
            {
                Employee existing = GetById(id);
                if (existing == null)
                   throw new Exception("Employee not found.");
              if (GetByEmail(employee.email) != null)
                throw new InvalidOperationException("Email already exists.");
                existing.email = employee.email;
                existing.name = employee.name;
                existing.phone = employee.phone;
                existing.position = employee.position;
                existing.deptId = employee.deptId;
                existing.workSchedule = employee.workSchedule;
                context.SaveChanges();
            }
            public void Delete(int id)
            {
                if (GetById(id) == null)
                    throw new Exception("Employee not found.");
                context.Employees.Remove(GetById(id));
                context.SaveChanges();
            }

        }
    }
