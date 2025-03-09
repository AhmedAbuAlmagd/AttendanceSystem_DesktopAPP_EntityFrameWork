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
    public partial class ShowRequests : Form
    {
        LeaveRequestServices LeaveRequestServices;
        int selectedRequestId = -1;


        public ShowRequests()
        {
            InitializeComponent();

            LeaveRequestServices = new LeaveRequestServices(new AttendanceContext());
        }

        private void ShowRequests_Load(object sender, EventArgs e)
        {
            dgv_showrequests_SRF.DataSource = LeaveRequestServices.GetAllPendingRequests();
            dgv_showrequests_SRF.Columns["EmployeeId"].Visible = false;
            LoadEmployees();
        }
       
        private void LoadEmployees()
        {
            cb_showbyemp_SRF.DataSource = LeaveRequestServices.GetEmployee();
            //cb_showbyemp_SRF.DisplayMember = "name";
            //cb_showbyemp_SRF.ValueMember = "id";
        }

        private void cb_showbyemp_SRF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_showbyemp_SRF.SelectedValue != null)
            {
                int selectedEmpId = (int)cb_showbyemp_SRF.SelectedValue;
                dgv_showrequests_SRF.DataSource = LeaveRequestServices.ShowByEmployeeId(selectedEmpId);
            }
        }

        private void dgv_showrequests_SRF_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRequestId = (int)dgv_showrequests_SRF.SelectedRows[0].Cells[0].Value;
            btn_accept_SRF.Enabled = true;
            btn_reject_SRF.Enabled = true;
        }

        private void btn_accept_SRF_Click(object sender, EventArgs e)
        {
            if (selectedRequestId != -1)
            {
                LeaveRequestServices.UpdateRequestStatus(selectedRequestId, LeaverequestStatus.Approved);
                MessageBox.Show("Request Approved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showRefreshRequests();

            }
        }

        private void btn_reject_SRF_Click(object sender, EventArgs e)
        {
            if(selectedRequestId != -1)
            {
                LeaveRequestServices.UpdateRequestStatus(selectedRequestId,LeaverequestStatus.Rejected);
                MessageBox.Show("Request Rejected", "fail",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                showRefreshRequests();
            }
        }


        private void showRefreshRequests()
        {
            if(cb_showbyemp_SRF.SelectedValue != null)
            {
                int selectedEmpId =(int) cb_showbyemp_SRF.SelectedValue;
                dgv_showrequests_SRF.DataSource = LeaveRequestServices.ShowRequestsByEmpId(selectedEmpId);
            }
        }
    }
}
