namespace EF_Project.Forms
{
    partial class LoginForm
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
            check_viewPass_UF = new CheckBox();
            txt_userName_LF = new TextBox();
            btn_login_LF = new Button();
            txt_password_LF = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // check_viewPass_UF
            // 
            check_viewPass_UF.AutoSize = true;
            check_viewPass_UF.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            check_viewPass_UF.Location = new Point(529, 256);
            check_viewPass_UF.Name = "check_viewPass_UF";
            check_viewPass_UF.Size = new Size(121, 21);
            check_viewPass_UF.TabIndex = 43;
            check_viewPass_UF.Text = "Show Password";
            check_viewPass_UF.UseVisualStyleBackColor = true;
            check_viewPass_UF.CheckedChanged += check_viewPass_UF_CheckedChanged_1;
            // 
            // txt_userName_LF
            // 
            txt_userName_LF.Location = new Point(529, 133);
            txt_userName_LF.Name = "txt_userName_LF";
            txt_userName_LF.Size = new Size(175, 27);
            txt_userName_LF.TabIndex = 42;
            // 
            // btn_login_LF
            // 
            btn_login_LF.BackColor = Color.White;
            btn_login_LF.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn_login_LF.ForeColor = Color.Black;
            btn_login_LF.Location = new Point(529, 321);
            btn_login_LF.Name = "btn_login_LF";
            btn_login_LF.Size = new Size(155, 48);
            btn_login_LF.TabIndex = 41;
            btn_login_LF.Text = "Login";
            btn_login_LF.UseVisualStyleBackColor = false;
            btn_login_LF.Click += btn_login_LF_Click;
            // 
            // txt_password_LF
            // 
            txt_password_LF.Location = new Point(529, 223);
            txt_password_LF.Name = "txt_password_LF";
            txt_password_LF.Size = new Size(175, 27);
            txt_password_LF.TabIndex = 40;
            txt_password_LF.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(387, 218);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 39;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(370, 129);
            label1.Name = "label1";
            label1.Size = new Size(131, 31);
            label1.TabIndex = 38;
            label1.Text = "User Name";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(check_viewPass_UF);
            Controls.Add(txt_userName_LF);
            Controls.Add(btn_login_LF);
            Controls.Add(txt_password_LF);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox check_viewPass_UF;
        private TextBox txt_userName_LF;
        private Button btn_login_LF;
        private TextBox txt_password_LF;
        private Label label2;
        private Label label1;
    }
}