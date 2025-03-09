    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project.Forms
{
    public partial class HRDashboard : Form
    {
        private int hrID;

        public HRDashboard()
        {
            InitializeComponent();
        }

        private void btn_myattend_HRF_Click(object sender, EventArgs e)
        {
            HRAttendance hRAttendance = new HRAttendance( hrID);
            hRAttendance.Show();
            this.Hide();
        }

        private void btn_empmanage_HRF_Click(object sender, EventArgs e)
        {

            EmployeeManagment empmanage = new EmployeeManagment();
            this.Hide();
            empmanage.Show();
        }

        private void btn_showrequest_HRF_Click(object sender, EventArgs e)
        {

            ShowRequests showRequests = new ShowRequests();
            this.Hide();
            showRequests.Show();
        }

        private void btn_showreport_HRF_Click(object sender, EventArgs e)
        {
            ShowReports showReports = new ShowReports();
            showReports.Show();
            this.Hide();
        }
    }
}
