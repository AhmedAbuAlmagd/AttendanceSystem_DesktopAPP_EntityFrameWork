namespace EF_Project.Forms
{
    partial class AttendanceForm
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
            btn_checkin_AF = new Button();
            btn_checkout_AF = new Button();
            btn_leaveRequest_AF = new Button();
            SuspendLayout();
            // 
            // btn_checkin_AF
            // 
            btn_checkin_AF.Location = new Point(467, 110);
            btn_checkin_AF.Name = "btn_checkin_AF";
            btn_checkin_AF.Size = new Size(181, 56);
            btn_checkin_AF.TabIndex = 0;
            btn_checkin_AF.Text = "Check In ";
            btn_checkin_AF.UseVisualStyleBackColor = true;
            btn_checkin_AF.Click += btn_checkin_AF_Click;
            // 
            // btn_checkout_AF
            // 
            btn_checkout_AF.Location = new Point(468, 210);
            btn_checkout_AF.Name = "btn_checkout_AF";
            btn_checkout_AF.Size = new Size(181, 56);
            btn_checkout_AF.TabIndex = 1;
            btn_checkout_AF.Text = "Check Out";
            btn_checkout_AF.UseVisualStyleBackColor = true;
            btn_checkout_AF.Click += btn_checkout_AF_Click;
            // 
            // btn_leaveRequest_AF
            // 
            btn_leaveRequest_AF.Location = new Point(468, 310);
            btn_leaveRequest_AF.Name = "btn_leaveRequest_AF";
            btn_leaveRequest_AF.Size = new Size(181, 56);
            btn_leaveRequest_AF.TabIndex = 2;
            btn_leaveRequest_AF.Text = "Leave Request";
            btn_leaveRequest_AF.UseVisualStyleBackColor = true;
            btn_leaveRequest_AF.Click += btn_leaveRequest_AF_Click;
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_leaveRequest_AF);
            Controls.Add(btn_checkout_AF);
            Controls.Add(btn_checkin_AF);
            Name = "AttendanceForm";
            Text = "AttendanceForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_checkin_AF;
        private Button btn_checkout_AF;
        private Button btn_leaveRequest_AF;
    }
}