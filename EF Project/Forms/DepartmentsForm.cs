using EmployeeAttendanceSystem.BusinessLogic.Services;
using EmployeeAttendanceSystem.DataAccess.Context;
using EmployeeAttendanceSystem.DataAccess.Models;
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
    public partial class DepartmentsForm : Form
    {
        DepartmentServices departmentServices;
        public DepartmentsForm()
        {
            InitializeComponent();
            departmentServices = new DepartmentServices(new AttendanceContext());
        }

        private void DepartmentsForm_Load(object sender, EventArgs e)
        {
            dgv_department.DataSource = departmentServices.GetAll();
        }
        int dept_id;
        private void dgv_department_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dept_id = (int)dgv_department.SelectedRows[0].Cells[0].Value;
            txt_deptName_DF.Text = dgv_department.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_addDept_UF_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department()
                {
                    name = txt_deptName_DF.Text
                };
                departmentServices.Add(dept);
                MessageBox.Show("Department Added Successfully");
                resetInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_updateDept_UF_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department()
                {
                    name = txt_deptName_DF.Text
                };
                departmentServices.Update(dept_id, dept);
                MessageBox.Show("Department Updated successfully");
                resetInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_deleteDept_UF_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure you want to delete this user ?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    departmentServices.Delete(dept_id);
                    MessageBox.Show("Department deleted successfully!");
                    resetInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetInputs()
        {
            dgv_department.DataSource = departmentServices.GetAll();
            txt_deptName_DF.Text = "";
        }

       
    }
}
