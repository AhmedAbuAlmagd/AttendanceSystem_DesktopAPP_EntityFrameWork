namespace EF_Project.Forms
{
    partial class ShowReports
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
            dgv_showreport_SRF = new DataGridView();
            btn_dailyreport_SRF = new Button();
            btn_showweekreport_SRF = new Button();
            btn_showmonth_SRF = new Button();
            cb_showemp_SRF = new ComboBox();
            cb_year_SRF = new ComboBox();
            cb_month_SRF = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_showreport_SRF).BeginInit();
            SuspendLayout();
            // 
            // dgv_showreport_SRF
            // 
            dgv_showreport_SRF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_showreport_SRF.Location = new Point(27, 291);
            dgv_showreport_SRF.Name = "dgv_showreport_SRF";
            dgv_showreport_SRF.RowHeadersWidth = 51;
            dgv_showreport_SRF.Size = new Size(691, 188);
            dgv_showreport_SRF.TabIndex = 0;
            // 
            // btn_dailyreport_SRF
            // 
            btn_dailyreport_SRF.Location = new Point(245, 26);
            btn_dailyreport_SRF.Name = "btn_dailyreport_SRF";
            btn_dailyreport_SRF.Size = new Size(361, 64);
            btn_dailyreport_SRF.TabIndex = 1;
            btn_dailyreport_SRF.Text = "Get Employees Daily Reports";
            btn_dailyreport_SRF.UseVisualStyleBackColor = true;
            btn_dailyreport_SRF.Click += btn_dailyreport_SRF_Click;
            // 
            // btn_showweekreport_SRF
            // 
            btn_showweekreport_SRF.Location = new Point(12, 127);
            btn_showweekreport_SRF.Name = "btn_showweekreport_SRF";
            btn_showweekreport_SRF.Size = new Size(282, 53);
            btn_showweekreport_SRF.TabIndex = 2;
            btn_showweekreport_SRF.Text = "Show Weekly Report Per Employee";
            btn_showweekreport_SRF.UseVisualStyleBackColor = true;
            btn_showweekreport_SRF.Click += btn_showweekreport_SRF_Click;
            // 
            // btn_showmonth_SRF
            // 
            btn_showmonth_SRF.Location = new Point(12, 210);
            btn_showmonth_SRF.Name = "btn_showmonth_SRF";
            btn_showmonth_SRF.Size = new Size(282, 54);
            btn_showmonth_SRF.TabIndex = 3;
            btn_showmonth_SRF.Text = "Show Monthly Report Per Employee";
            btn_showmonth_SRF.UseVisualStyleBackColor = true;
            btn_showmonth_SRF.Click += btn_showmonth_SRF_Click;
            // 
            // cb_showemp_SRF
            // 
            cb_showemp_SRF.FormattingEnabled = true;
            cb_showemp_SRF.Location = new Point(366, 140);
            cb_showemp_SRF.Name = "cb_showemp_SRF";
            cb_showemp_SRF.Size = new Size(187, 28);
            cb_showemp_SRF.TabIndex = 4;
            // 
            // cb_year_SRF
            // 
            cb_year_SRF.FormattingEnabled = true;
            cb_year_SRF.Location = new Point(382, 224);
            cb_year_SRF.Name = "cb_year_SRF";
            cb_year_SRF.Size = new Size(102, 28);
            cb_year_SRF.TabIndex = 5;
            // 
            // cb_month_SRF
            // 
            cb_month_SRF.FormattingEnabled = true;
            cb_month_SRF.Location = new Point(593, 224);
            cb_month_SRF.Name = "cb_month_SRF";
            cb_month_SRF.Size = new Size(102, 28);
            cb_month_SRF.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 227);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 7;
            label1.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(517, 227);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 8;
            label2.Text = "Month";
            // 
            // ShowReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 503);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_month_SRF);
            Controls.Add(cb_year_SRF);
            Controls.Add(cb_showemp_SRF);
            Controls.Add(btn_showmonth_SRF);
            Controls.Add(btn_showweekreport_SRF);
            Controls.Add(btn_dailyreport_SRF);
            Controls.Add(dgv_showreport_SRF);
            Name = "ShowReports";
            Text = "ShowReports";
            ((System.ComponentModel.ISupportInitialize)dgv_showreport_SRF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dgv_showreport_SRF;
        private Button btn_dailyreport_SRF;
        private Button btn_showweekreport_SRF;
        private Button btn_showmonth_SRF;
        private ComboBox cb_showemp_SRF;
        private ComboBox cb_year_SRF;
        private ComboBox cb_month_SRF;
        private Label label1;
        private Label label2;

        #endregion

        // private NotifyIcon notifyIcon1;
    }
}