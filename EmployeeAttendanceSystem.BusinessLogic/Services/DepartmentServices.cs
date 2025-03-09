using EmployeeAttendanceSystem.DataAccess.Context;
using EmployeeAttendanceSystem.DataAccess.Models;
using EmployeeAttendanceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendanceSystem.BusinessLogic.Services
{
    public class DepartmentServices
    {
        AttendanceContext context;
        public DepartmentServices(AttendanceContext context)
        {
            this.context = context;
        }
        public Department GetById(int id)
        {
            return context.Departments.FirstOrDefault(x => x.id == id);
        } 
        public Department GetByName(string name)
        {
            return context.Departments.FirstOrDefault(x => x.name == name);
        }
        public List<Department> GetAll()
        {
            return context.Departments.ToList();
        }

        public void Add(Department department)
        {
            if (string.IsNullOrEmpty(department.name))
                throw new ArgumentException("Department name is required.");
            if (GetByName(department.name) != null)
                throw new Exception("This department already exists.");
            context.Departments.Add(department);
            context.SaveChanges();
        }

        public void Update(int id, Department department)
        {
            Department existing = GetById(id);
            if (existing == null)
                throw new Exception("Department not found.");
            if (GetByName(department.name) != null)
                throw new Exception("This department already exists.");
            existing.name = department.name;
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            if (GetById(id) == null)
                throw new Exception("Department not found.");
            context.Departments.Remove(GetById(id));
            context.SaveChanges();
        }
    }
}
