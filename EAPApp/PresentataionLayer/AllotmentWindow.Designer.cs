namespace PresentataionLayer
{
    partial class AllotmentWindow
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.tbcLogin = new System.Windows.Forms.TabControl();
            this.tbcCandidate = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslCandidateLogin = new System.Windows.Forms.ToolStripLabel();
            this.btnNewUser1 = new System.Windows.Forms.Button();
            this.btnExistingUser1 = new System.Windows.Forms.Button();
            this.tbcCollege = new System.Windows.Forms.TabPage();
            this.txtCollegePassword = new System.Windows.Forms.TextBox();
            this.txtCollegeUserName = new System.Windows.Forms.TextBox();
            this.btnCollegeLogin1 = new System.Windows.Forms.Button();
            this.lblCollegePassword = new System.Windows.Forms.Label();
            this.lblCollegeUsername = new System.Windows.Forms.Label();
            this.tbcAdmin = new System.Windows.Forms.TabPage();
            this.btnAdminLogin1 = new System.Windows.Forms.Button();
            this.lblAdminuserName = new System.Windows.Forms.Label();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbcLogin.SuspendLayout();
            this.tbcCandidate.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tbcCollege.SuspendLayout();
            this.tbcAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(173, 20);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(453, 36);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "ENGINEERING ALLOTMENT";
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // tbcLogin
            // 
            this.tbcLogin.Controls.Add(this.tbcCandidate);
            this.tbcLogin.Controls.Add(this.tbcCollege);
            this.tbcLogin.Controls.Add(this.tbcAdmin);
            this.tbcLogin.Location = new System.Drawing.Point(0, 74);
            this.tbcLogin.Name = "tbcLogin";
            this.tbcLogin.SelectedIndex = 0;
            this.tbcLogin.Size = new System.Drawing.Size(807, 579);
            this.tbcLogin.TabIndex = 1;
            // 
            // tbcCandidate
            // 
            this.tbcCandidate.Controls.Add(this.toolStrip1);
            this.tbcCandidate.Controls.Add(this.btnNewUser1);
            this.tbcCandidate.Controls.Add(this.btnExistingUser1);
            this.tbcCandidate.Location = new System.Drawing.Point(4, 28);
            this.tbcCandidate.Name = "tbcCandidate";
            this.tbcCandidate.Padding = new System.Windows.Forms.Padding(3);
            this.tbcCandidate.Size = new System.Drawing.Size(799, 547);
            this.tbcCandidate.TabIndex = 0;
            this.tbcCandidate.Text = "Candidate";
            this.tbcCandidate.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Turquoise;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslCandidateLogin});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(793, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "Candidate Login";
            // 
            // tslCandidateLogin
            // 
            this.tslCandidateLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tslCandidateLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tslCandidateLogin.Name = "tslCandidateLogin";
            this.tslCandidateLogin.Size = new System.Drawing.Size(94, 22);
            this.tslCandidateLogin.Text = "Candidate Login";
            this.tslCandidateLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tslCandidateLogin.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // btnNewUser1
            // 
            this.btnNewUser1.Location = new System.Drawing.Point(299, 155);
            this.btnNewUser1.Name = "btnNewUser1";
            this.btnNewUser1.Size = new System.Drawing.Size(114, 53);
            this.btnNewUser1.TabIndex = 2;
            this.btnNewUser1.Text = "New User";
            this.btnNewUser1.UseVisualStyleBackColor = true;
            // 
            // btnExistingUser1
            // 
            this.btnExistingUser1.Location = new System.Drawing.Point(299, 67);
            this.btnExistingUser1.Name = "btnExistingUser1";
            this.btnExistingUser1.Size = new System.Drawing.Size(114, 56);
            this.btnExistingUser1.TabIndex = 1;
            this.btnExistingUser1.Text = "Existing User";
            this.btnExistingUser1.UseVisualStyleBackColor = true;
            // 
            // tbcCollege
            // 
            this.tbcCollege.Controls.Add(this.txtCollegePassword);
            this.tbcCollege.Controls.Add(this.txtCollegeUserName);
            this.tbcCollege.Controls.Add(this.btnCollegeLogin1);
            this.tbcCollege.Controls.Add(this.lblCollegePassword);
            this.tbcCollege.Controls.Add(this.lblCollegeUsername);
            this.tbcCollege.Location = new System.Drawing.Point(4, 28);
            this.tbcCollege.Name = "tbcCollege";
            this.tbcCollege.Padding = new System.Windows.Forms.Padding(3);
            this.tbcCollege.Size = new System.Drawing.Size(799, 547);
            this.tbcCollege.TabIndex = 1;
            this.tbcCollege.Text = "College";
            this.tbcCollege.UseVisualStyleBackColor = true;
            // 
            // txtCollegePassword
            // 
            this.txtCollegePassword.Location = new System.Drawing.Point(337, 194);
            this.txtCollegePassword.Name = "txtCollegePassword";
            this.txtCollegePassword.Size = new System.Drawing.Size(209, 26);
            this.txtCollegePassword.TabIndex = 4;
            // 
            // txtCollegeUserName
            // 
            this.txtCollegeUserName.Location = new System.Drawing.Point(337, 129);
            this.txtCollegeUserName.Name = "txtCollegeUserName";
            this.txtCollegeUserName.Size = new System.Drawing.Size(209, 26);
            this.txtCollegeUserName.TabIndex = 3;
            // 
            // btnCollegeLogin1
            // 
            this.btnCollegeLogin1.Location = new System.Drawing.Point(385, 284);
            this.btnCollegeLogin1.Name = "btnCollegeLogin1";
            this.btnCollegeLogin1.Size = new System.Drawing.Size(102, 30);
            this.btnCollegeLogin1.TabIndex = 2;
            this.btnCollegeLogin1.Text = "Login";
            this.btnCollegeLogin1.UseVisualStyleBackColor = true;
            this.btnCollegeLogin1.Click += new System.EventHandler(this.btnCollegeLogin1_Click);
            // 
            // lblCollegePassword
            // 
            this.lblCollegePassword.AutoSize = true;
            this.lblCollegePassword.Location = new System.Drawing.Point(203, 196);
            this.lblCollegePassword.Name = "lblCollegePassword";
            this.lblCollegePassword.Size = new System.Drawing.Size(72, 19);
            this.lblCollegePassword.TabIndex = 1;
            this.lblCollegePassword.Text = "Password";
            // 
            // lblCollegeUsername
            // 
            this.lblCollegeUsername.AutoSize = true;
            this.lblCollegeUsername.Location = new System.Drawing.Point(203, 131);
            this.lblCollegeUsername.Name = "lblCollegeUsername";
            this.lblCollegeUsername.Size = new System.Drawing.Size(85, 19);
            this.lblCollegeUsername.TabIndex = 0;
            this.lblCollegeUsername.Text = "User Name";
            // 
            // tbcAdmin
            // 
            this.tbcAdmin.Controls.Add(this.textBox2);
            this.tbcAdmin.Controls.Add(this.textBox1);
            this.tbcAdmin.Controls.Add(this.lblAdminPassword);
            this.tbcAdmin.Controls.Add(this.lblAdminuserName);
            this.tbcAdmin.Controls.Add(this.btnAdminLogin1);
            this.tbcAdmin.Location = new System.Drawing.Point(4, 28);
            this.tbcAdmin.Name = "tbcAdmin";
            this.tbcAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tbcAdmin.Size = new System.Drawing.Size(799, 547);
            this.tbcAdmin.TabIndex = 2;
            this.tbcAdmin.Text = "Admin";
            this.tbcAdmin.UseVisualStyleBackColor = true;
            // 
            // btnAdminLogin1
            // 
            this.btnAdminLogin1.Location = new System.Drawing.Point(389, 301);
            this.btnAdminLogin1.Name = "btnAdminLogin1";
            this.btnAdminLogin1.Size = new System.Drawing.Size(109, 33);
            this.btnAdminLogin1.TabIndex = 0;
            this.btnAdminLogin1.Text = "Login";
            this.btnAdminLogin1.UseVisualStyleBackColor = true;
            this.btnAdminLogin1.Click += new System.EventHandler(this.btnAdminLogin1_Click);
            // 
            // lblAdminuserName
            // 
            this.lblAdminuserName.AutoSize = true;
            this.lblAdminuserName.Location = new System.Drawing.Point(214, 134);
            this.lblAdminuserName.Name = "lblAdminuserName";
            this.lblAdminuserName.Size = new System.Drawing.Size(85, 19);
            this.lblAdminuserName.TabIndex = 1;
            this.lblAdminuserName.Text = "User Name";
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.Location = new System.Drawing.Point(214, 208);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(72, 19);
            this.lblAdminPassword.TabIndex = 2;
            this.lblAdminPassword.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(348, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 26);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(348, 208);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 26);
            this.textBox2.TabIndex = 4;
            // 
            // AllotmentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(808, 650);
            this.Controls.Add(this.tbcLogin);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AllotmentWindow";
            this.Text = "AllotmentWindow";
            this.tbcLogin.ResumeLayout(false);
            this.tbcCandidate.ResumeLayout(false);
            this.tbcCandidate.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbcCollege.ResumeLayout(false);
            this.tbcCollege.PerformLayout();
            this.tbcAdmin.ResumeLayout(false);
            this.tbcAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TabControl tbcLogin;
        private System.Windows.Forms.TabPage tbcCandidate;
        private System.Windows.Forms.TabPage tbcCollege;
        private System.Windows.Forms.TabPage tbcAdmin;
        private System.Windows.Forms.Button btnNewUser1;
        private System.Windows.Forms.Button btnExistingUser1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslCandidateLogin;
        private System.Windows.Forms.TextBox txtCollegePassword;
        private System.Windows.Forms.TextBox txtCollegeUserName;
        private System.Windows.Forms.Button btnCollegeLogin1;
        private System.Windows.Forms.Label lblCollegePassword;
        private System.Windows.Forms.Label lblCollegeUsername;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.Label lblAdminuserName;
        private System.Windows.Forms.Button btnAdminLogin1;
    }
}