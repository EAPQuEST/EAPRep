namespace PresentataionLayer
{
    partial class CandidateChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateChangePassword));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCandidateChangePassword = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtCandidateChangePasswordID = new System.Windows.Forms.TextBox();
            this.lblCandidateChangePasswordID = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspHome = new System.Windows.Forms.ToolStripButton();
            this.tspBtnBack = new System.Windows.Forms.ToolStripButton();
            this.pnlCandidateChangePassword.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(269, 62);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(265, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CHANGE PASSWORD";
            // 
            // pnlCandidateChangePassword
            // 
            this.pnlCandidateChangePassword.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlCandidateChangePassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCandidateChangePassword.Controls.Add(this.txtCandidateChangePasswordID);
            this.pnlCandidateChangePassword.Controls.Add(this.lblCandidateChangePasswordID);
            this.pnlCandidateChangePassword.Controls.Add(this.lblMessage);
            this.pnlCandidateChangePassword.Controls.Add(this.txtNewPassword);
            this.pnlCandidateChangePassword.Controls.Add(this.txtCurrentPassword);
            this.pnlCandidateChangePassword.Controls.Add(this.btnChangePassword);
            this.pnlCandidateChangePassword.Controls.Add(this.lblNewPassword);
            this.pnlCandidateChangePassword.Controls.Add(this.lblCurrentPassword);
            this.pnlCandidateChangePassword.Location = new System.Drawing.Point(135, 134);
            this.pnlCandidateChangePassword.Name = "pnlCandidateChangePassword";
            this.pnlCandidateChangePassword.Size = new System.Drawing.Size(506, 231);
            this.pnlCandidateChangePassword.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(27, 196);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 5;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(213, 107);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(214, 20);
            this.txtNewPassword.TabIndex = 4;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(213, 70);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(214, 20);
            this.txtCurrentPassword.TabIndex = 3;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.White;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassword.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnChangePassword.Location = new System.Drawing.Point(213, 163);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(156, 46);
            this.btnChangePassword.TabIndex = 2;
            this.btnChangePassword.Text = "CONFIRM";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(54, 115);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(100, 18);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "New Password";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.Location = new System.Drawing.Point(54, 70);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(122, 18);
            this.lblCurrentPassword.TabIndex = 0;
            this.lblCurrentPassword.Text = "Current Password";
            // 
            // txtCandidateChangePasswordID
            // 
            this.txtCandidateChangePasswordID.Location = new System.Drawing.Point(213, 28);
            this.txtCandidateChangePasswordID.Name = "txtCandidateChangePasswordID";
            this.txtCandidateChangePasswordID.Size = new System.Drawing.Size(214, 20);
            this.txtCandidateChangePasswordID.TabIndex = 7;
            // 
            // lblCandidateChangePasswordID
            // 
            this.lblCandidateChangePasswordID.AutoSize = true;
            this.lblCandidateChangePasswordID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateChangePasswordID.Location = new System.Drawing.Point(54, 28);
            this.lblCandidateChangePasswordID.Name = "lblCandidateChangePasswordID";
            this.lblCandidateChangePasswordID.Size = new System.Drawing.Size(71, 18);
            this.lblCandidateChangePasswordID.TabIndex = 6;
            this.lblCandidateChangePasswordID.Text = "Username";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspHome,
            this.tspBtnBack});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tspHome
            // 
            this.tspHome.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tspHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspHome.Image = ((System.Drawing.Image)(resources.GetObject("tspHome.Image")));
            this.tspHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspHome.Name = "tspHome";
            this.tspHome.Size = new System.Drawing.Size(23, 22);
            this.tspHome.Text = "Sign Out";
            // 
            // tspBtnBack
            // 
            this.tspBtnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspBtnBack.Image = ((System.Drawing.Image)(resources.GetObject("tspBtnBack.Image")));
            this.tspBtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspBtnBack.Name = "tspBtnBack";
            this.tspBtnBack.Size = new System.Drawing.Size(23, 22);
            this.tspBtnBack.Text = "Back";
            // 
            // CandidateChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlCandidateChangePassword);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CandidateChangePassword";
            this.Text = "CandidateChangePassword";
            this.Load += new System.EventHandler(this.CandidateChangePassword_Load);
            this.pnlCandidateChangePassword.ResumeLayout(false);
            this.pnlCandidateChangePassword.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlCandidateChangePassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtCandidateChangePasswordID;
        private System.Windows.Forms.Label lblCandidateChangePasswordID;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tspHome;
        private System.Windows.Forms.ToolStripButton tspBtnBack;
    }
}