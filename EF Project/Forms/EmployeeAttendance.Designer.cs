namespace EF_Project.Forms
{
    partial class EmployeeAttendance
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
            cb_showbydate_EAF = new ComboBox();
            cb_showbyuser_EAF = new ComboBox();
            btn_showbydate_EAF = new Button();
            btn_showbyuser_EAF = new Button();
            dgv_empattend_EAF = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_empattend_EAF).BeginInit();
            SuspendLayout();
            // 
            // cb_showbydate_EAF
            // 
            cb_showbydate_EAF.FormattingEnabled = true;
            cb_showbydate_EAF.Location = new Point(644, 175);
            cb_showbydate_EAF.Name = "cb_showbydate_EAF";
            cb_showbydate_EAF.Size = new Size(151, 28);
            cb_showbydate_EAF.TabIndex = 9;
            // 
            // cb_showbyuser_EAF
            // 
            cb_showbyuser_EAF.FormattingEnabled = true;
            cb_showbyuser_EAF.Location = new Point(644, 68);
            cb_showbyuser_EAF.Name = "cb_showbyuser_EAF";
            cb_showbyuser_EAF.Size = new Size(151, 28);
            cb_showbyuser_EAF.TabIndex = 8;
            // 
            // btn_showbydate_EAF
            // 
            btn_showbydate_EAF.Location = new Point(421, 160);
            btn_showbydate_EAF.Name = "btn_showbydate_EAF";
            btn_showbydate_EAF.Size = new Size(151, 56);
            btn_showbydate_EAF.TabIndex = 7;
            btn_showbydate_EAF.Text = "Show By Date";
            btn_showbydate_EAF.UseVisualStyleBackColor = true;
            btn_showbydate_EAF.Click += btn_showbydate_EAF_Click;
            // 
            // btn_showbyuser_EAF
            // 
            btn_showbyuser_EAF.Location = new Point(421, 55);
            btn_showbyuser_EAF.Name = "btn_showbyuser_EAF";
            btn_showbyuser_EAF.Size = new Size(151, 53);
            btn_showbyuser_EAF.TabIndex = 6;
            btn_showbyuser_EAF.Text = "Show By User";
            btn_showbyuser_EAF.UseVisualStyleBackColor = true;
            btn_showbyuser_EAF.Click += btn_showbyuser_EAF_Click;
            // 
            // dgv_empattend_EAF
            // 
            dgv_empattend_EAF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_empattend_EAF.Location = new Point(6, 20);
            dgv_empattend_EAF.Name = "dgv_empattend_EAF";
            dgv_empattend_EAF.RowHeadersWidth = 51;
            dgv_empattend_EAF.Size = new Size(369, 411);
            dgv_empattend_EAF.TabIndex = 5;
            // 
            // EmployeeAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 450);
            Controls.Add(cb_showbydate_EAF);
            Controls.Add(cb_showbyuser_EAF);
            Controls.Add(btn_showbydate_EAF);
            Controls.Add(btn_showbyuser_EAF);
            Controls.Add(dgv_empattend_EAF);
            Name = "EmployeeAttendance";
            Text = "EmployeeAttendance";
            ((System.ComponentModel.ISupportInitialize)dgv_empattend_EAF).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cb_showbydate_EAF;
        private ComboBox cb_showbyuser_EAF;
        private Button btn_showbydate_EAF;
        private Button btn_showbyuser_EAF;
        private DataGridView dgv_empattend_EAF;
    }
}