using EmployeeAttendanceSystem.BusinessLogic.Services;
using EmployeeAttendanceSystem.DataAccess.Context;
using EmployeeAttendanceSystem.DataAccess.Models;


namespace EF_Project.Forms
{
    public partial class AttendanceForm : Form
    {
        int employee_id;
        AttendanceServices attendanceServices;
        LogsServices logsServices;
        AttendanceContext context;

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
            if(attendanceServices.GetByempIdAndCheckIn(employee_id, DateTime.Now.Date) == null)
            {
                Attendance attendance = new Attendance()
                {
                    Employee_id = employee_id,
                    checkInTime = DateTime.Now
                };

                if (attendance.checkInTime?.TimeOfDay > new TimeSpan(9, 0, 0))
                    attendance.IsLate = true;

                attendanceServices.Add(attendance);

                Log log = new Log()
                {
                    empoloyeeId = employee_id,
                    action = EmployeeAttendanceSystem.DataAccess.Models.Action.checkIn,
                    actionTime = DateTime.Now
                };

                logsServices.Add(log);

                MessageBox.Show("Checked-In Successfully", "Check-In", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You have already checked-in once", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_checkout_AF_Click(object sender, EventArgs e)
        {
            Attendance attendance = attendanceServices.GetByempIdAndCheckIn(employee_id, DateTime.Now.Date);
            if(attendance != null)
            {
                if (attendance.checkOutTime == null)
                {
                    attendance.checkOutTime = DateTime.Now;
                    if (attendance.checkOutTime?.TimeOfDay > new TimeSpan(17, 0, 0))
                        attendance.IsEarlyDeparture = true;

                    Log log = new Log()
                    {
                        empoloyeeId = employee_id,
                        action = EmployeeAttendanceSystem.DataAccess.Models.Action.checkOut,
                        actionTime = DateTime.Now
                    };
                    logsServices.Add(log);
                    MessageBox.Show("Checked-Out Successfully", "Check-In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You have already checked-out once", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("You should check-in first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_leaveRequest_AF_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LeaveRequestForm(employee_id ,this).Show();
        }
    }
}
