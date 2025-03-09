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
        public HRDashboard()
        {
            InitializeComponent();
        }

        private void btn_myattend_HRF_Click(object sender, EventArgs e)
        {

        }

        private void btn_empmanage_HRF_Click(object sender, EventArgs e)
        {
            EmployeeManagment empmanage = new EmployeeManagment();
            this.Hide();
            empmanage.Show();
        }
    }
}
