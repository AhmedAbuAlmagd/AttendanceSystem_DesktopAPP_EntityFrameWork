using EmployeeAttendanceSystem.BusinessLogic.Services;
using EmployeeAttendanceSystem.DataAccess.Context;
using EmployeeAttendanceSystem.DataAccess.Models;

namespace EF_Project.Forms
{
    public partial class AttendanceForm : Form
    {
        private readonly int employee_id;
        private readonly AttendanceServices attendanceServices;
        private readonly LogsServices logsServices;
        private readonly AttendanceContext context;

        public AttendanceForm(int employee_id)
        {
            InitializeComponent();
            context = new AttendanceContext();
            this.employee_id = employee_id;
            attendanceServices = new AttendanceServices(context);
            logsServices = new LogsServices(context);
        }

        private void btn_checkin_AF_Click(object sender, EventArgs e)
        {
            try
            {
                attendanceServices.CheckIn(employee_id);

                Log log = new Log
                {
                    empoloyeeId = employee_id,
                    action = EmployeeAttendanceSystem.DataAccess.Models.Action.checkIn,
                    actionTime = DateTime.Now
                };
                logsServices.Add(log);

                MessageBox.Show("Checked-In Successfully", "Check-In", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_checkout_AF_Click(object sender, EventArgs e)
        {
            try
            {
                attendanceServices.CheckOut(employee_id);

                Log log = new Log
                {
                    empoloyeeId = employee_id,
                    action = EmployeeAttendanceSystem.DataAccess.Models.Action.checkOut,
                    actionTime = DateTime.Now
                };
                logsServices.Add(log);

                MessageBox.Show("Checked-Out Successfully", "Check-Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_leaveRequest_AF_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LeaveRequestForm(employee_id, this).Show();
        }
    }
}