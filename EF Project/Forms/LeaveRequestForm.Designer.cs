namespace EF_Project.Forms
{
    partial class LeaveRequestForm
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
            label1 = new Label();
            label2 = new Label();
            requestStartTime_LRF = new DateTimePicker();
            requestEndTime_LRF = new DateTimePicker();
            label3 = new Label();
            requestReason_LRF = new RichTextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btn_SendRequest_LRF = new Button();
            btn_ShowRequests_LRF = new Button();
            btn_back_LRF = new Button();
            dgv_ShowRequests_LRF = new DataGridView();
            btn_cancelRequest_LRF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ShowRequests_LRF).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 92);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Start Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 164);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "End Time";
            // 
            // requestStartTime_LRF
            // 
            requestStartTime_LRF.Format = DateTimePickerFormat.Time;
            requestStartTime_LRF.Location = new Point(148, 89);
            requestStartTime_LRF.Name = "requestStartTime_LRF";
            requestStartTime_LRF.Size = new Size(133, 27);
            requestStartTime_LRF.TabIndex = 2;
            // 
            // requestEndTime_LRF
            // 
            requestEndTime_LRF.Format = DateTimePickerFormat.Time;
            requestEndTime_LRF.Location = new Point(148, 159);
            requestEndTime_LRF.Name = "requestEndTime_LRF";
            requestEndTime_LRF.Size = new Size(133, 27);
            requestEndTime_LRF.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 229);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 3;
            label3.Text = "Reason ";
            // 
            // requestReason_LRF
            // 
            requestReason_LRF.Location = new Point(148, 226);
            requestReason_LRF.Name = "requestReason_LRF";
            requestReason_LRF.Size = new Size(282, 64);
            requestReason_LRF.TabIndex = 4;
            requestReason_LRF.Text = "";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btn_SendRequest_LRF
            // 
            btn_SendRequest_LRF.Location = new Point(148, 319);
            btn_SendRequest_LRF.Name = "btn_SendRequest_LRF";
            btn_SendRequest_LRF.Size = new Size(121, 48);
            btn_SendRequest_LRF.TabIndex = 5;
            btn_SendRequest_LRF.Text = "Send Request";
            btn_SendRequest_LRF.UseVisualStyleBackColor = true;
            btn_SendRequest_LRF.Click += btn_SendRequest_LRF_Click;
            // 
            // btn_ShowRequests_LRF
            // 
            btn_ShowRequests_LRF.Location = new Point(586, 319);
            btn_ShowRequests_LRF.Name = "btn_ShowRequests_LRF";
            btn_ShowRequests_LRF.Size = new Size(121, 48);
            btn_ShowRequests_LRF.TabIndex = 5;
            btn_ShowRequests_LRF.Text = "Show Requests";
            btn_ShowRequests_LRF.UseVisualStyleBackColor = true;
            btn_ShowRequests_LRF.Click += btn_ShowRequests_LRF_Click;
            // 
            // btn_back_LRF
            // 
            btn_back_LRF.Location = new Point(12, 390);
            btn_back_LRF.Name = "btn_back_LRF";
            btn_back_LRF.Size = new Size(121, 48);
            btn_back_LRF.TabIndex = 5;
            btn_back_LRF.Text = "Back";
            btn_back_LRF.UseVisualStyleBackColor = true;
            btn_back_LRF.Click += btn_back_LRF_Click;
            // 
            // dgv_ShowRequests_LRF
            // 
            dgv_ShowRequests_LRF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ShowRequests_LRF.Location = new Point(503, 89);
            dgv_ShowRequests_LRF.Name = "dgv_ShowRequests_LRF";
            dgv_ShowRequests_LRF.RowHeadersWidth = 51;
            dgv_ShowRequests_LRF.Size = new Size(285, 201);
            dgv_ShowRequests_LRF.TabIndex = 6;
            dgv_ShowRequests_LRF.RowHeaderMouseDoubleClick += dgv_ShowRequests_LRF_RowHeaderMouseDoubleClick;
            // 
            // btn_cancelRequest_LRF
            // 
            btn_cancelRequest_LRF.Location = new Point(586, 319);
            btn_cancelRequest_LRF.Name = "btn_cancelRequest_LRF";
            btn_cancelRequest_LRF.Size = new Size(121, 48);
            btn_cancelRequest_LRF.TabIndex = 7;
            btn_cancelRequest_LRF.Text = "Cancel Request";
            btn_cancelRequest_LRF.UseVisualStyleBackColor = true;
            btn_cancelRequest_LRF.Click += btn_cancelRequest_LRF_Click;
            // 
            // LeaveRequestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cancelRequest_LRF);
            Controls.Add(dgv_ShowRequests_LRF);
            Controls.Add(btn_back_LRF);
            Controls.Add(btn_ShowRequests_LRF);
            Controls.Add(btn_SendRequest_LRF);
            Controls.Add(requestReason_LRF);
            Controls.Add(label3);
            Controls.Add(requestEndTime_LRF);
            Controls.Add(requestStartTime_LRF);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LeaveRequestForm";
            Text = "Leave Request Form";
            ((System.ComponentModel.ISupportInitialize)dgv_ShowRequests_LRF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker requestStartTime_LRF;
        private DateTimePicker requestEndTime_LRF;
        private Label label3;
        private RichTextBox requestReason_LRF;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btn_SendRequest_LRF;
        private Button btn_ShowRequests_LRF;
        private Button btn_back_LRF;
        private DataGridView dgv_ShowRequests_LRF;
        private Button btn_cancelRequest_LRF;
    }
}