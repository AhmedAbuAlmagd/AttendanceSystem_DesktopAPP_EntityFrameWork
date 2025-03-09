namespace EF_Project.Forms
{
    partial class HRAttendance
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
            dgv_hrattend_HRAF = new DataGridView();
            btn_getattendlogs_HRAF = new Button();
            btn_showbydate_HRAF = new Button();
            cb_showbydate_HRAF = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_hrattend_HRAF).BeginInit();
            SuspendLayout();
            // 
            // dgv_hrattend_HRAF
            // 
            dgv_hrattend_HRAF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_hrattend_HRAF.Location = new Point(21, 200);
            dgv_hrattend_HRAF.Name = "dgv_hrattend_HRAF";
            dgv_hrattend_HRAF.RowHeadersWidth = 51;
            dgv_hrattend_HRAF.Size = new Size(804, 289);
            dgv_hrattend_HRAF.TabIndex = 0;
            //dgv_hrattend_HRAF.CellContentClick += dgv_hrattend_HRAF_CellContentClick;
            // 
            // btn_getattendlogs_HRAF
            // 
            btn_getattendlogs_HRAF.Location = new Point(37, 24);
            btn_getattendlogs_HRAF.Name = "btn_getattendlogs_HRAF";
            btn_getattendlogs_HRAF.Size = new Size(220, 51);
            btn_getattendlogs_HRAF.TabIndex = 1;
            btn_getattendlogs_HRAF.Text = "Get My Attendance Logs";
            btn_getattendlogs_HRAF.UseVisualStyleBackColor = true;
            btn_getattendlogs_HRAF.Click += btn_getattendlogs_HRAF_Click;
            // 
            // btn_showbydate_HRAF
            // 
            btn_showbydate_HRAF.Location = new Point(37, 95);
            btn_showbydate_HRAF.Name = "btn_showbydate_HRAF";
            btn_showbydate_HRAF.Size = new Size(220, 54);
            btn_showbydate_HRAF.TabIndex = 2;
            btn_showbydate_HRAF.Text = "Show By Date";
            btn_showbydate_HRAF.UseVisualStyleBackColor = true;
            btn_showbydate_HRAF.Click += btn_showbydate_HRAF_Click;
            // 
            // cb_showbydate_HRAF
            // 
            cb_showbydate_HRAF.FormattingEnabled = true;
            cb_showbydate_HRAF.Location = new Point(333, 109);
            cb_showbydate_HRAF.Name = "cb_showbydate_HRAF";
            cb_showbydate_HRAF.Size = new Size(227, 28);
            cb_showbydate_HRAF.TabIndex = 3;
            // 
            // HRAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 501);
            Controls.Add(cb_showbydate_HRAF);
            Controls.Add(btn_showbydate_HRAF);
            Controls.Add(btn_getattendlogs_HRAF);
            Controls.Add(dgv_hrattend_HRAF);
            Name = "HRAttendance";
            Text = "HRAttendance";
            ((System.ComponentModel.ISupportInitialize)dgv_hrattend_HRAF).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_hrattend_HRAF;
        private Button btn_getattendlogs_HRAF;
        private Button btn_showbydate_HRAF;
        private ComboBox cb_showbydate_HRAF;
    }
}