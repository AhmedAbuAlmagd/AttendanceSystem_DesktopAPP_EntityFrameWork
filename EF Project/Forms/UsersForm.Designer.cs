namespace EF_Project
{
    partial class UsersForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            dgv_users_UF = new DataGridView();
            txt_userName_UF = new TextBox();
            txt_password_UF = new TextBox();
            combo_role_UF = new ComboBox();
            btn_addUser_UF = new Button();
            btn_updateUser_UF = new Button();
            btn_deleteUser_UF = new Button();
            check_viewPass_UF = new CheckBox();
            label3 = new Label();
            combo_employee_UF = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_users_UF).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 46);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 102);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // dgv_users_UF
            // 
            dgv_users_UF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_users_UF.Location = new Point(12, 182);
            dgv_users_UF.Name = "dgv_users_UF";
            dgv_users_UF.RowHeadersWidth = 51;
            dgv_users_UF.Size = new Size(554, 321);
            dgv_users_UF.TabIndex = 2;
            dgv_users_UF.RowHeaderMouseDoubleClick += dgv_users_UF_RowHeaderMouseDoubleClick;
            // 
            // txt_userName_UF
            // 
            txt_userName_UF.Location = new Point(151, 43);
            txt_userName_UF.Name = "txt_userName_UF";
            txt_userName_UF.Size = new Size(125, 27);
            txt_userName_UF.TabIndex = 3;
            // 
            // txt_password_UF
            // 
            txt_password_UF.Location = new Point(151, 99);
            txt_password_UF.Name = "txt_password_UF";
            txt_password_UF.Size = new Size(125, 27);
            txt_password_UF.TabIndex = 4;
            txt_password_UF.UseSystemPasswordChar = true;
            // 
            // combo_role_UF
            // 
            combo_role_UF.FormattingEnabled = true;
            combo_role_UF.Location = new Point(452, 42);
            combo_role_UF.Name = "combo_role_UF";
            combo_role_UF.Size = new Size(151, 28);
            combo_role_UF.TabIndex = 5;
            // 
            // btn_addUser_UF
            // 
            btn_addUser_UF.Location = new Point(626, 215);
            btn_addUser_UF.Name = "btn_addUser_UF";
            btn_addUser_UF.Size = new Size(142, 54);
            btn_addUser_UF.TabIndex = 6;
            btn_addUser_UF.Text = "Add ";
            btn_addUser_UF.UseVisualStyleBackColor = true;
            btn_addUser_UF.Click += btn_addUser_UF_Click;
            // 
            // btn_updateUser_UF
            // 
            btn_updateUser_UF.Location = new Point(626, 312);
            btn_updateUser_UF.Name = "btn_updateUser_UF";
            btn_updateUser_UF.Size = new Size(142, 54);
            btn_updateUser_UF.TabIndex = 7;
            btn_updateUser_UF.Text = "Update";
            btn_updateUser_UF.UseVisualStyleBackColor = true;
            btn_updateUser_UF.Click += btn_updateUser_UF_Click;
            // 
            // btn_deleteUser_UF
            // 
            btn_deleteUser_UF.Location = new Point(626, 412);
            btn_deleteUser_UF.Name = "btn_deleteUser_UF";
            btn_deleteUser_UF.Size = new Size(142, 54);
            btn_deleteUser_UF.TabIndex = 8;
            btn_deleteUser_UF.Text = "Delete";
            btn_deleteUser_UF.UseVisualStyleBackColor = true;
            btn_deleteUser_UF.Click += btn_deleteUser_UF_Click;
            // 
            // check_viewPass_UF
            // 
            check_viewPass_UF.AutoSize = true;
            check_viewPass_UF.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            check_viewPass_UF.Location = new Point(151, 132);
            check_viewPass_UF.Name = "check_viewPass_UF";
            check_viewPass_UF.Size = new Size(121, 21);
            check_viewPass_UF.TabIndex = 38;
            check_viewPass_UF.Text = "Show Password";
            check_viewPass_UF.UseVisualStyleBackColor = true;
            check_viewPass_UF.CheckedChanged += check_viewPass_UF_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(370, 46);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 39;
            label3.Text = "Role";
            // 
            // combo_employee_UF
            // 
            combo_employee_UF.FormattingEnabled = true;
            combo_employee_UF.Location = new Point(452, 98);
            combo_employee_UF.Name = "combo_employee_UF";
            combo_employee_UF.Size = new Size(151, 28);
            combo_employee_UF.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(334, 102);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 39;
            label4.Text = "Employee";
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 515);
            Controls.Add(combo_employee_UF);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(check_viewPass_UF);
            Controls.Add(btn_deleteUser_UF);
            Controls.Add(btn_updateUser_UF);
            Controls.Add(btn_addUser_UF);
            Controls.Add(combo_role_UF);
            Controls.Add(txt_password_UF);
            Controls.Add(txt_userName_UF);
            Controls.Add(dgv_users_UF);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UsersForm";
            Text = "Users Form";
            Load += UsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_users_UF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgv_users_UF;
        private TextBox txt_userName_UF;
        private TextBox txt_password_UF;
        private ComboBox combo_role_UF;
        private Button btn_addUser_UF;
        private Button btn_updateUser_UF;
        private Button btn_deleteUser_UF;
        private CheckBox check_viewPass_UF;
        private Label label3;
        private ComboBox combo_employee_UF;
        private Label label4;
    }
}
