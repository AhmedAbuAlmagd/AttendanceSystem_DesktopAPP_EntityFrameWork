namespace EF_Project.Forms
{
    partial class DepartmentsForm
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
            dgv_department = new DataGridView();
            txt_deptName_DF = new TextBox();
            label1 = new Label();
            btn_deleteDept_UF = new Button();
            btn_updateDept_UF = new Button();
            btn_addDept_UF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_department).BeginInit();
            SuspendLayout();
            // 
            // dgv_department
            // 
            dgv_department.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_department.Location = new Point(5, 203);
            dgv_department.Name = "dgv_department";
            dgv_department.RowHeadersWidth = 51;
            dgv_department.Size = new Size(560, 311);
            dgv_department.TabIndex = 0;
            dgv_department.RowHeaderMouseDoubleClick += dgv_department_RowHeaderMouseDoubleClick;
            // 
            // txt_deptName_DF
            // 
            txt_deptName_DF.Location = new Point(293, 104);
            txt_deptName_DF.Name = "txt_deptName_DF";
            txt_deptName_DF.Size = new Size(163, 27);
            txt_deptName_DF.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 107);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 2;
            label1.Text = "Department Name";
            // 
            // btn_deleteDept_UF
            // 
            btn_deleteDept_UF.Location = new Point(634, 423);
            btn_deleteDept_UF.Name = "btn_deleteDept_UF";
            btn_deleteDept_UF.Size = new Size(142, 54);
            btn_deleteDept_UF.TabIndex = 11;
            btn_deleteDept_UF.Text = "Delete";
            btn_deleteDept_UF.UseVisualStyleBackColor = true;
            btn_deleteDept_UF.Click += btn_deleteDept_UF_Click;
            // 
            // btn_updateDept_UF
            // 
            btn_updateDept_UF.Location = new Point(634, 323);
            btn_updateDept_UF.Name = "btn_updateDept_UF";
            btn_updateDept_UF.Size = new Size(142, 54);
            btn_updateDept_UF.TabIndex = 10;
            btn_updateDept_UF.Text = "Update";
            btn_updateDept_UF.UseVisualStyleBackColor = true;
            btn_updateDept_UF.Click += btn_updateDept_UF_Click;
            // 
            // btn_addDept_UF
            // 
            btn_addDept_UF.Location = new Point(634, 226);
            btn_addDept_UF.Name = "btn_addDept_UF";
            btn_addDept_UF.Size = new Size(142, 54);
            btn_addDept_UF.TabIndex = 9;
            btn_addDept_UF.Text = "Add ";
            btn_addDept_UF.UseVisualStyleBackColor = true;
            btn_addDept_UF.Click += btn_addDept_UF_Click;
            // 
            // DepartmentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 515);
            Controls.Add(btn_deleteDept_UF);
            Controls.Add(btn_updateDept_UF);
            Controls.Add(btn_addDept_UF);
            Controls.Add(label1);
            Controls.Add(txt_deptName_DF);
            Controls.Add(dgv_department);
            Name = "DepartmentsForm";
            Text = "DepartmentsForm";
            Load += DepartmentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_department).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_department;
        private TextBox txt_deptName_DF;
        private Label label1;
        private Button btn_deleteDept_UF;
        private Button btn_updateDept_UF;
        private Button btn_addDept_UF;
    }
}