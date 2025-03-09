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

namespace EF_Project.Forms
{
    public partial class HRAttendance : Form
    {
        private int currentHRId;
        AttendanceServices attendanceServices;
        public HRAttendance(int hrID)
        {
            InitializeComponent();
            this.currentHRId = hrID;
            LoadDates();
        }
        private void LoadDates()
        {
            var dates = attendanceServices.GetAllDates();
            cb_showbydate_HRAF.DataSource = dates;
        }

        private void btn_getattendlogs_HRAF_Click(object sender, EventArgs e)
        {
            var attendanceLogs = attendanceServices.GetAttendanceByEmployee(this.currentHRId);
            dgv_hrattend_HRAF.DataSource = attendanceLogs;
        }

        private void btn_showbydate_HRAF_Click(object sender, EventArgs e)
        {
           if(cb_showbydate_HRAF != null)
            {
                DateTime selectedDate = (DateTime)cb_showbydate_HRAF.SelectedItem;
                var filteredLogs = attendanceServices.GetAttendanceByEmpIdAndDate(currentHRId, selectedDate);
                dgv_hrattend_HRAF.DataSource= filteredLogs;
            }
        }
    }
}
