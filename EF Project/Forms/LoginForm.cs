using EmployeeAttendanceSystem.BusinessLogic.Services;
using EmployeeAttendanceSystem.DataAccess.Context;
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
    public partial class LoginForm : Form
    {

        UserServices usersService;
        public LoginForm()
        {
            InitializeComponent();
            usersService = new UserServices(new AttendanceContext());

        }
        int employee_id;
        private void btn_login_LF_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_userName_LF.Text))
                MessageBox.Show("User name is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            else if (String.IsNullOrWhiteSpace(txt_password_LF.Text))
                MessageBox.Show("Password is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                try
                {
                    var user = usersService.Authenticate(txt_userName_LF.Text, txt_password_LF.Text);
                    if (user.role.ToString() == "Employee")
                    {
                        employee_id = (int)user.employeeId;
                        this.Hide();
                        new AttendanceForm(employee_id).Show();
                    }
                    else if (user.role.ToString() == "HR")
                    {
                        this.Close();
                    }
                    else if (user.role.ToString() == "Admin")
                    {
                        this.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid UserName or Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void check_viewPass_UF_CheckedChanged_1(object sender, EventArgs e)
        {
            if (check_viewPass_UF.Checked)
                txt_password_LF.UseSystemPasswordChar = false;
            else
                txt_password_LF.UseSystemPasswordChar = true;
        }
    }
}
