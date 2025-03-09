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
using EmployeeAttendanceSystem.DataAccess.Models;

namespace EF_Project.Forms
{
    public partial class ShowReports : Form
    {
        AttendanceServices attendanceServices;
        AttendanceContext context;
        public ShowReports()
        {
            InitializeComponent();
            attendanceServices = new AttendanceServices(new AttendanceContext());
            cb_showemp_SRF.DataSource = context.Employees.Select(e => e.name).ToList();
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;
            for (int i = 0; i < 2020; i++)
            {
                cb_year_SRF.Items.Add(i);

            }
            cb_year_SRF.SelectedItem = currentYear;
            for (int i = 0; i < 12; i++)
            {
                cb_month_SRF.Items.Add(i);
            }
            cb_month_SRF.SelectedItem = currentMonth;

        }

        private void btn_dailyreport_SRF_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            dgv_showreport_SRF.DataSource = attendanceServices.GetDailyAttendance(date);

        }

        private void btn_showweekreport_SRF_Click(object sender, EventArgs e)
        {
            if (cb_showemp_SRF.SelectedValue == null)
            {
                MessageBox.Show("Please Choose Employee First!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int empId = (int)cb_showemp_SRF.SelectedValue;
            DateTime startDate = DateTime.Now.AddDays(-7);
            List<Attendance> weeklyReport = attendanceServices.GetAttendanceByEmpIdAndDate(empId, startDate);
            dgv_showreport_SRF.DataSource = weeklyReport;
        }

        private void btn_showmonth_SRF_Click(object sender, EventArgs e)
        {
            if(cb_showemp_SRF == null  )
            {
                MessageBox.Show("Please Choose One Employee", "warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cb_year_SRF.SelectedItem == null && cb_month_SRF.SelectedItem == null)
            {
                MessageBox.Show("Please Choose  Year and Month", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int empId = (int)cb_showemp_SRF.SelectedValue;
                MessageBox.Show("Please Choose One Employee", "warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            int year  = (int)cb_year_SRF.SelectedItem;
            int month = (int)cb_month_SRF.SelectedItem;
            List<Attendance> monthlyReport = attendanceServices.GetMonthlyAttendance(empId,year, month);
            dgv_showreport_SRF.DataSource= monthlyReport;



        }
    }
}
