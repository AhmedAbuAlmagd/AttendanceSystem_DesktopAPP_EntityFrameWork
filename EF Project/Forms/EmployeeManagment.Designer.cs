namespace EF_Project.Forms
{
    partial class EmployeeManagment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_emp_EMF = new DataGridView();
            txt_name_EMF = new TextBox();
            txt_position_EMF = new TextBox();
            txt_email_EMF = new TextBox();
            txt_phone_EMF = new TextBox();
            cb_schedule_EMF = new ComboBox();
            cb_dept_EMF = new ComboBox();
            btn_getdata_EMF = new Button();
            btn_add_EMF = new Button();
            btn_edit_EMF = new Button();
            btn_delete_EMF = new Button();
            lbl_empname_EM = new Label();
            lbl_position_EMF = new Label();
            lbl_email_EMF = new Label();
            lbl_phone_EMF = new Label();
            lbl_schedule_EMF = new Label();
            lbl_dept_EMF = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_emp_EMF).BeginInit();
            SuspendLayout();
            // 
            // dgv_emp_EMF
            // 
            dgv_emp_EMF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_emp_EMF.Location = new Point(34, 317);
            dgv_emp_EMF.Name = "dgv_emp_EMF";
            dgv_emp_EMF.RowHeadersWidth = 51;
            dgv_emp_EMF.Size = new Size(791, 199);
            dgv_emp_EMF.TabIndex = 0;
            dgv_emp_EMF.RowHeaderMouseDoubleClick += dgv_emp_EMF_RowHeaderMouseDoubleClick;
            // 
            // txt_name_EMF
            // 
            txt_name_EMF.Location = new Point(134, 25);
            txt_name_EMF.Name = "txt_name_EMF";
            txt_name_EMF.Size = new Size(125, 27);
            txt_name_EMF.TabIndex = 1;
            // 
            // txt_position_EMF
            // 
            txt_position_EMF.Location = new Point(134, 85);
            txt_position_EMF.Name = "txt_position_EMF";
            txt_position_EMF.Size = new Size(125, 27);
            txt_position_EMF.TabIndex = 2;
            // 
            // txt_email_EMF
            // 
            txt_email_EMF.Location = new Point(134, 150);
            txt_email_EMF.Name = "txt_email_EMF";
            txt_email_EMF.Size = new Size(125, 27);
            txt_email_EMF.TabIndex = 3;
            // 
            // txt_phone_EMF
            // 
            txt_phone_EMF.Location = new Point(134, 228);
            txt_phone_EMF.Name = "txt_phone_EMF";
            txt_phone_EMF.Size = new Size(125, 27);
            txt_phone_EMF.TabIndex = 4;
            // 
            // cb_schedule_EMF
            // 
            cb_schedule_EMF.FormattingEnabled = true;
            cb_schedule_EMF.Location = new Point(549, 25);
            cb_schedule_EMF.Name = "cb_schedule_EMF";
            cb_schedule_EMF.Size = new Size(151, 28);
            cb_schedule_EMF.TabIndex = 5;
            // 
            // cb_dept_EMF
            // 
            cb_dept_EMF.FormattingEnabled = true;
            cb_dept_EMF.Location = new Point(549, 96);
            cb_dept_EMF.Name = "cb_dept_EMF";
            cb_dept_EMF.Size = new Size(151, 28);
            cb_dept_EMF.TabIndex = 6;
            // 
            // btn_getdata_EMF
            // 
            btn_getdata_EMF.Location = new Point(430, 172);
            btn_getdata_EMF.Name = "btn_getdata_EMF";
            btn_getdata_EMF.Size = new Size(327, 45);
            btn_getdata_EMF.TabIndex = 7;
            btn_getdata_EMF.Text = "Get Data";
            btn_getdata_EMF.UseVisualStyleBackColor = true;
            btn_getdata_EMF.Click += btn_getdata_EMF_Click;
            // 
            // btn_add_EMF
            // 
            btn_add_EMF.Location = new Point(430, 253);
            btn_add_EMF.Name = "btn_add_EMF";
            btn_add_EMF.Size = new Size(94, 41);
            btn_add_EMF.TabIndex = 8;
            btn_add_EMF.Text = "Add";
            btn_add_EMF.UseVisualStyleBackColor = true;
            btn_add_EMF.Click += btn_add_EMF_Click;
            // 
            // btn_edit_EMF
            // 
            btn_edit_EMF.Location = new Point(567, 253);
            btn_edit_EMF.Name = "btn_edit_EMF";
            btn_edit_EMF.Size = new Size(94, 41);
            btn_edit_EMF.TabIndex = 9;
            btn_edit_EMF.Text = "Edit";
            btn_edit_EMF.UseVisualStyleBackColor = true;
            btn_edit_EMF.Click += btn_edit_EMF_Click;
            // 
            // btn_delete_EMF
            // 
            btn_delete_EMF.Location = new Point(714, 253);
            btn_delete_EMF.Name = "btn_delete_EMF";
            btn_delete_EMF.Size = new Size(94, 41);
            btn_delete_EMF.TabIndex = 10;
            btn_delete_EMF.Text = "Delete";
            btn_delete_EMF.UseVisualStyleBackColor = true;
            btn_delete_EMF.Click += btn_delete_EMF_Click;
            // 
            // lbl_empname_EM
            // 
            lbl_empname_EM.AutoSize = true;
            lbl_empname_EM.Location = new Point(34, 33);
            lbl_empname_EM.Name = "lbl_empname_EM";
            lbl_empname_EM.Size = new Size(49, 20);
            lbl_empname_EM.TabIndex = 11;
            lbl_empname_EM.Text = "Name";
            // 
            // lbl_position_EMF
            // 
            lbl_position_EMF.AutoSize = true;
            lbl_position_EMF.Location = new Point(34, 92);
            lbl_position_EMF.Name = "lbl_position_EMF";
            lbl_position_EMF.Size = new Size(61, 20);
            lbl_position_EMF.TabIndex = 12;
            lbl_position_EMF.Text = "Position";
            // 
            // lbl_email_EMF
            // 
            lbl_email_EMF.AutoSize = true;
            lbl_email_EMF.Location = new Point(34, 157);
            lbl_email_EMF.Name = "lbl_email_EMF";
            lbl_email_EMF.Size = new Size(46, 20);
            lbl_email_EMF.TabIndex = 13;
            lbl_email_EMF.Text = "Email";
            // 
            // lbl_phone_EMF
            // 
            lbl_phone_EMF.AutoSize = true;
            lbl_phone_EMF.Location = new Point(34, 235);
            lbl_phone_EMF.Name = "lbl_phone_EMF";
            lbl_phone_EMF.Size = new Size(50, 20);
            lbl_phone_EMF.TabIndex = 14;
            lbl_phone_EMF.Text = "Phone";
            // 
            // lbl_schedule_EMF
            // 
            lbl_schedule_EMF.AutoSize = true;
            lbl_schedule_EMF.Location = new Point(417, 33);
            lbl_schedule_EMF.Name = "lbl_schedule_EMF";
            lbl_schedule_EMF.Size = new Size(107, 20);
            lbl_schedule_EMF.TabIndex = 15;
            lbl_schedule_EMF.Text = "Work Schedule";
            // 
            // lbl_dept_EMF
            // 
            lbl_dept_EMF.AutoSize = true;
            lbl_dept_EMF.Location = new Point(445, 104);
            lbl_dept_EMF.Name = "lbl_dept_EMF";
            lbl_dept_EMF.Size = new Size(86, 20);
            lbl_dept_EMF.TabIndex = 16;
            lbl_dept_EMF.Text = "Dept Name";
            // 
            // EmployeeManagment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 554);
            Controls.Add(lbl_dept_EMF);
            Controls.Add(lbl_schedule_EMF);
            Controls.Add(lbl_phone_EMF);
            Controls.Add(lbl_email_EMF);
            Controls.Add(lbl_position_EMF);
            Controls.Add(lbl_empname_EM);
            Controls.Add(btn_delete_EMF);
            Controls.Add(btn_edit_EMF);
            Controls.Add(btn_add_EMF);
            Controls.Add(btn_getdata_EMF);
            Controls.Add(cb_dept_EMF);
            Controls.Add(cb_schedule_EMF);
            Controls.Add(txt_phone_EMF);
            Controls.Add(txt_email_EMF);
            Controls.Add(txt_position_EMF);
            Controls.Add(txt_name_EMF);
            Controls.Add(dgv_emp_EMF);
            Name = "EmployeeManagment";
            Text = "EmployeeManagment";
            Load += EmployeeManagment_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_emp_EMF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_emp_EMF;
        private TextBox txt_name_EMF;
        private TextBox txt_position_EMF;
        private TextBox txt_email_EMF;
        private TextBox txt_phone_EMF;
        private ComboBox cb_schedule_EMF;
        private ComboBox cb_dept_EMF;
        private Button btn_getdata_EMF;
        private Button btn_add_EMF;
        private Button btn_edit_EMF;
        private Button btn_delete_EMF;
        private Label lbl_empname_EM;
        private Label lbl_position_EMF;
        private Label lbl_email_EMF;
        private Label lbl_phone_EMF;
        private Label lbl_schedule_EMF;
        private Label lbl_dept_EMF;
    }
}