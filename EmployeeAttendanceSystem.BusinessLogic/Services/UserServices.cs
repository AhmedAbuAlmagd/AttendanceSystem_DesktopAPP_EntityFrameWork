using EmployeeAttendanceSystem.DataAccess.Context;
using EmployeeAttendanceSystem.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmployeeAttendanceSystem.BusinessLogic.Services
{
    public class UserServices
    {
        AttendanceContext context;
        public UserServices(AttendanceContext context)
        {
            this.context = context;
        }

        public List<User> GetAll()
        {
            return context.Users.ToList();
        }
        public User GetById(int id)
        {
            return context.Users.FirstOrDefault(x => x.id == id);
        }
        public User GetByUserName(string userName)
        {
            return context.Users.FirstOrDefault(x => x.userName == userName);
        }
        public User Authenticate(string userName , string password)
        {
            return context.Users.FirstOrDefault(x => x.userName == userName && x.password == password);
        }
        public void Add(User user)
        {
            if (string.IsNullOrWhiteSpace(user.userName) || string.IsNullOrWhiteSpace(user.password))
            {
                throw new Exception("Username and password cannot be empty.");
            }
            if (!Regex.IsMatch(user.userName, @"^[a-zA-Z0-9_]{3,20}$"))
            {
                throw new Exception("Invalid username. Use only letters, numbers, and underscores (3-20 characters).");
            }
            if (!Regex.IsMatch(user.password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$"))
            {
                throw new Exception("Invalid password. Must contain uppercase, lowercase, number, special character, and be at least 6 characters.");
            }

            if (GetByUserName(user.userName) != null)
            {
                throw new InvalidOperationException("Username already exists.");
            }
            try
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Data base error : " + ex.Message);
            }
        }
        public void Update(int id , User user)
        {
            if (string.IsNullOrWhiteSpace(user.userName) || string.IsNullOrWhiteSpace(user.password))
            {
                throw new Exception("Username and password cannot be empty.");
            }
            if (!Regex.IsMatch(user.userName, @"^[a-zA-Z0-9_]{3,20}$"))
            {
                throw new Exception("Invalid username. Use only letters, numbers, and underscores (3-20 characters).");
            }
            if (!Regex.IsMatch(user.password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$"))
            {
                throw new Exception("Invalid password. Must contain uppercase, lowercase, number, special character, and be at least 6 characters.");
            }

            if (GetById(id).userName != user.userName && GetByUserName(user.userName) != null)
            {
                throw new InvalidOperationException("Username already exists.");
            }
            try
            {
                User existing = GetById(id);
                existing.userName = user.userName;
                existing.password = user.password;
                existing.role = user.role;
                existing.employeeId = user.employeeId;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
         
            }

        public void Delete(int id)
        {
            try
            {
                context.Users.Remove(GetById(id));
                context.SaveChanges();
            }
            catch (Exception ex)
            { 
                throw new Exception(ex.Message);
            }
        }
    }
}
