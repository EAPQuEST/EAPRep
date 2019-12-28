namespace PresentataionLayer
{
    partial class CandidateLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExistingLogin = new System.Windows.Forms.Button();
            this.txtCandidatePassword = new System.Windows.Forms.TextBox();
            this.txtCandidateUsername = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::PresentataionLayer.Properties.Resources._username_login_1172579;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(340, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 93);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnExistingLogin);
            this.panel2.Controls.Add(this.txtCandidatePassword);
            this.panel2.Controls.Add(this.txtCandidateUsername);
            this.panel2.Location = new System.Drawing.Point(233, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 320);
            this.panel2.TabIndex = 3;
            // 
            // btnExistingLogin
            // 
            this.btnExistingLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnExistingLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExistingLogin.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExistingLogin.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnExistingLogin.Location = new System.Drawing.Point(107, 248);
            this.btnExistingLogin.Name = "btnExistingLogin";
            this.btnExistingLogin.Size = new System.Drawing.Size(133, 38);
            this.btnExistingLogin.TabIndex = 2;
            this.btnExistingLogin.Text = "LOGIN";
            this.btnExistingLogin.UseVisualStyleBackColor = false;
            this.btnExistingLogin.Click += new System.EventHandler(this.btnExistingLogin_Click);
            // 
            // txtCandidatePassword
            // 
            this.txtCandidatePassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCandidatePassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtCandidatePassword.Location = new System.Drawing.Point(58, 174);
            this.txtCandidatePassword.Multiline = true;
            this.txtCandidatePassword.Name = "txtCandidatePassword";
            this.txtCandidatePassword.Size = new System.Drawing.Size(232, 28);
            this.txtCandidatePassword.TabIndex = 1;
            this.txtCandidatePassword.Text = "Password";
            this.txtCandidatePassword.MouseEnter += new System.EventHandler(this.txtCandidatePassword_MouseEnter);
            this.txtCandidatePassword.MouseLeave += new System.EventHandler(this.txtCandidatePassword_MouseLeave);
            // 
            // txtCandidateUsername
            // 
            this.txtCandidateUsername.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCandidateUsername.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtCandidateUsername.Location = new System.Drawing.Point(58, 112);
            this.txtCandidateUsername.Multiline = true;
            this.txtCandidateUsername.Name = "txtCandidateUsername";
            this.txtCandidateUsername.Size = new System.Drawing.Size(232, 28);
            this.txtCandidateUsername.TabIndex = 0;
            this.txtCandidateUsername.Text = "Username";
            this.txtCandidateUsername.MouseEnter += new System.EventHandler(this.txtCandidateUsername_MouseEnter);
            this.txtCandidateUsername.MouseLeave += new System.EventHandler(this.txtCandidateUsername_MouseLeave);
            // 
            // CandidateLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::PresentataionLayer.Properties.Resources._7557127;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "CandidateLogin";
            this.Text = "CandidateLogin";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExistingLogin;
        private System.Windows.Forms.TextBox txtCandidatePassword;
        private System.Windows.Forms.TextBox txtCandidateUsername;
    }
}