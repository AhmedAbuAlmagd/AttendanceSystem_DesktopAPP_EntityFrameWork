using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeAttendanceSystem.BusinessLogic.Services;
using EmployeeAttendanceSystem.DataAccess.Context;

namespace EF_Project.Forms
{
    public partial class EmployeeAttendance : Form
    {
        AttendanceServices attendanceServices;
        AttendanceContext attendaceContext;
        public EmployeeAttendance()
        {
            InitializeComponent();
            attendanceServices = new AttendanceServices(new AttendanceContext());
            LoadEmployees();
            LoadDates();
        }
        private void LoadEmployees()
        {
            var employees = attendanceServices.GetAll();
            cb_showbyuser_EAF.DataSource = employees;
            cb_showbyuser_EAF.DisplayMember = "name";
            cb_showbyuser_EAF.ValueMember = "id";
        }
        private void LoadDates()
        {
            var dates = attendanceServices.GetAllDates();
            cb_showbydate_EAF.DataSource = dates;
        }


        private void btn_showbyuser_EAF_Click(object sender, EventArgs e)
        {
            if (cb_showbyuser_EAF.SelectedValue != null)
            {
                int employeeId = (int)cb_showbyuser_EAF.SelectedValue;
                var attendanceList = attendanceServices.GetAttendanceByEmployee(employeeId);
                dgv_empattend_EAF.DataSource = attendanceList;
            }
        }

        private void btn_showbydate_EAF_Click(object sender, EventArgs e)
        {
            if (cb_showbydate_EAF.SelectedItem != null)
            {
                DateOnly selectedDate = (DateOnly)cb_showbydate_EAF.SelectedItem;
                var attendanceList = attendanceServices.GetAttendanceByDate(selectedDate);
                dgv_empattend_EAF.DataSource = attendanceList;
            }
        }
    }
}
