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
using EmployeeAttendanceSystem.Models;

namespace EF_Project.Forms
{
    public partial class EmployeeManagment : Form
    {
        EmployeeServices employeeServices;
        DepartmentServices departmentServices;

        public EmployeeManagment()
        {
            InitializeComponent();
            employeeServices = new EmployeeServices(new AttendanceContext());
            departmentServices = new DepartmentServices(new AttendanceContext());
        }

        private void btn_getdata_EMF_Click(object sender, EventArgs e)
        {
            dgv_emp_EMF.DataSource = employeeServices.GetAll();
        }

        private void btn_add_EMF_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee()
                {
                    name = txt_name_EMF.Text,
                    email = txt_email_EMF.Text,
                    phone = txt_phone_EMF.Text,
                    position = txt_position_EMF.Text,
                    deptId = (int)cb_dept_EMF.SelectedValue,
                    workSchedule = (workSchedule)cb_schedule_EMF.SelectedItem,

                };
                employeeServices.Add(emp);
                MessageBox.Show("Added Done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_emp_EMF.DataSource= employeeServices.GetAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                //employeeServices.GetAll();
                txt_name_EMF.Text = txt_email_EMF.Text = txt_position_EMF.Text = txt_phone_EMF.Text = "";

        }
        int id;
        private void dgv_emp_EMF_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_emp_EMF.SelectedRows[0].Cells[0].Value;
            Employee emp = employeeServices.GetById(id);
            txt_name_EMF.Text = emp.name;
            txt_phone_EMF.Text = emp.phone;
            txt_email_EMF.Text = emp.email;
            txt_position_EMF.Text = emp.position;
            cb_dept_EMF.SelectedValue = emp.deptId;
            cb_schedule_EMF.SelectedItem = emp.workSchedule;

        }

        private void btn_edit_EMF_Click(object sender, EventArgs e)
        {

            try
            {
                id = (int)dgv_emp_EMF.SelectedRows[0].Cells[0].Value;
                Employee emp = employeeServices.GetById((int)id);
                emp.name = txt_name_EMF.Text;
                emp.email = txt_phone_EMF.Text;
                emp.phone = txt_email_EMF.Text;
                emp.position = txt_position_EMF.Text;
                emp.deptId = (int)cb_dept_EMF.SelectedValue;
                emp.workSchedule = (workSchedule)cb_schedule_EMF.SelectedItem;
                employeeServices.Update(id, emp);
                MessageBox.Show("Updated Done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_emp_EMF.DataSource = employeeServices.GetAll();
            }
            
            
           

            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                txt_name_EMF.Text = txt_email_EMF.Text = txt_phone_EMF.Text = txt_position_EMF.Text = "";

        }

        private void btn_delete_EMF_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure You Want to Delete this Employee?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    employeeServices.Delete(id);
                    MessageBox.Show("Deleted success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                dgv_emp_EMF.DataSource= employeeServices.GetAll();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                    
        }

        private void EmployeeManagment_Load(object sender, EventArgs e)
        {
            cb_dept_EMF.DataSource  = departmentServices.GetAll();
            LoadEnumComboBox();
            cb_dept_EMF.ValueMember = "id";
            cb_dept_EMF.DisplayMember = "name"; 
        }
        private void LoadEnumComboBox()
        {
            cb_schedule_EMF.DataSource = Enum.GetValues(typeof(workSchedule));
        }
    }
}
