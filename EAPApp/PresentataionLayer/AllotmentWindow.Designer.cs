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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllotmentWindow));
            this.lblHeading = new System.Windows.Forms.Label();
            this.tbcLogin = new System.Windows.Forms.TabControl();
            this.tbcCandidate = new System.Windows.Forms.TabPage();
            this.llblChangePassword = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnExistingLogin = new System.Windows.Forms.Button();
            this.txtCandidatePassword = new System.Windows.Forms.TextBox();
            this.txtCandidateUsername = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslCandidateLogin = new System.Windows.Forms.ToolStripLabel();
            this.btnCandidateSignIn = new System.Windows.Forms.Button();
            this.tbcCollege = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblMessageCollege = new System.Windows.Forms.Label();
            this.btnCollegeLogin = new System.Windows.Forms.Button();
            this.txtCollegePassword = new System.Windows.Forms.TextBox();
            this.txtCollegeUsername = new System.Windows.Forms.TextBox();
            this.tbcAdmin = new System.Windows.Forms.TabPage();
            this.llblAdminChangePassword = new System.Windows.Forms.LinkLabel();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMessageAdmin = new System.Windows.Forms.Label();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.txtAdminUsername = new System.Windows.Forms.TextBox();
            this.epCandidateLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbcLogin.SuspendLayout();
            this.tbcCandidate.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tbcCollege.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tbcAdmin.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCandidateLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Perpetua Titling MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Navy;
            this.lblHeading.Location = new System.Drawing.Point(356, 24);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(553, 44);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "ENGINEERING ALLOTMENT";
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // tbcLogin
            // 
            this.tbcLogin.Controls.Add(this.tbcCandidate);
            this.tbcLogin.Controls.Add(this.tbcCollege);
            this.tbcLogin.Controls.Add(this.tbcAdmin);
            this.tbcLogin.Location = new System.Drawing.Point(0, 89);
            this.tbcLogin.Name = "tbcLogin";
            this.tbcLogin.SelectedIndex = 0;
            this.tbcLogin.Size = new System.Drawing.Size(1264, 591);
            this.tbcLogin.TabIndex = 1;
            // 
            // tbcCandidate
            // 
            this.tbcCandidate.BackColor = System.Drawing.SystemColors.Window;
            this.tbcCandidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbcCandidate.Controls.Add(this.llblChangePassword);
            this.tbcCandidate.Controls.Add(this.label1);
            this.tbcCandidate.Controls.Add(this.panel1);
            this.tbcCandidate.Controls.Add(this.panel2);
            this.tbcCandidate.Controls.Add(this.toolStrip1);
            this.tbcCandidate.Controls.Add(this.btnCandidateSignIn);
            this.tbcCandidate.Location = new System.Drawing.Point(4, 28);
            this.tbcCandidate.Name = "tbcCandidate";
            this.tbcCandidate.Padding = new System.Windows.Forms.Padding(3);
            this.tbcCandidate.Size = new System.Drawing.Size(1256, 559);
            this.tbcCandidate.TabIndex = 0;
            this.tbcCandidate.Text = "Candidate";
            this.tbcCandidate.Click += new System.EventHandler(this.tbcCandidate_Click);
            // 
            // llblChangePassword
            // 
            this.llblChangePassword.AutoSize = true;
            this.llblChangePassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblChangePassword.LinkColor = System.Drawing.Color.DarkBlue;
            this.llblChangePassword.Location = new System.Drawing.Point(1133, 28);
            this.llblChangePassword.Name = "llblChangePassword";
            this.llblChangePassword.Size = new System.Drawing.Size(115, 17);
            this.llblChangePassword.TabIndex = 7;
            this.llblChangePassword.TabStop = true;
            this.llblChangePassword.Text = "Change Password";
            this.llblChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblChangePassword_LinkClicked);
            this.llblChangePassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.llblChangePassword_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(520, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Not an Existing User? Sign In";
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::PresentataionLayer.Properties.Resources._username_login_1172579;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(546, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 93);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblMessage);
            this.panel2.Controls.Add(this.btnExistingLogin);
            this.panel2.Controls.Add(this.txtCandidatePassword);
            this.panel2.Controls.Add(this.txtCandidateUsername);
            this.panel2.Location = new System.Drawing.Point(439, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 320);
            this.panel2.TabIndex = 5;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(71, 83);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 18);
            this.lblMessage.TabIndex = 3;
            // 
            // btnExistingLogin
            // 
            this.btnExistingLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnExistingLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExistingLogin.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExistingLogin.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnExistingLogin.Location = new System.Drawing.Point(105, 243);
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
            this.txtCandidatePassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCandidatePassword_MouseClick);
            this.txtCandidatePassword.TextChanged += new System.EventHandler(this.txtCandidatePassword_TextChanged);
            this.txtCandidatePassword.MouseEnter += new System.EventHandler(this.txtCandidatePassword_MouseEnter);
            this.txtCandidatePassword.MouseLeave += new System.EventHandler(this.txtCandidatePassword_MouseLeave);
            // 
            // txtCandidateUsername
            // 
            this.txtCandidateUsername.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCandidateUsername.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtCandidateUsername.Location = new System.Drawing.Point(56, 113);
            this.txtCandidateUsername.Multiline = true;
            this.txtCandidateUsername.Name = "txtCandidateUsername";
            this.txtCandidateUsername.Size = new System.Drawing.Size(232, 28);
            this.txtCandidateUsername.TabIndex = 0;
            this.txtCandidateUsername.Text = "Username";
            this.txtCandidateUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCandidateUsername_MouseClick);
            this.txtCandidateUsername.MouseEnter += new System.EventHandler(this.txtCandidateUsername_MouseEnter);
            this.txtCandidateUsername.MouseLeave += new System.EventHandler(this.txtCandidateUsername_MouseLeave);
            this.txtCandidateUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtCandidateUsername_Validating);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslCandidateLogin});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1250, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "Candidate Login";
            // 
            // tslCandidateLogin
            // 
            this.tslCandidateLogin.BackColor = System.Drawing.Color.DarkMagenta;
            this.tslCandidateLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tslCandidateLogin.ForeColor = System.Drawing.Color.Cornsilk;
            this.tslCandidateLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tslCandidateLogin.Name = "tslCandidateLogin";
            this.tslCandidateLogin.Size = new System.Drawing.Size(94, 22);
            this.tslCandidateLogin.Text = "Candidate Login";
            this.tslCandidateLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tslCandidateLogin.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // btnCandidateSignIn
            // 
            this.btnCandidateSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnCandidateSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCandidateSignIn.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCandidateSignIn.Location = new System.Drawing.Point(555, 428);
            this.btnCandidateSignIn.Name = "btnCandidateSignIn";
            this.btnCandidateSignIn.Size = new System.Drawing.Size(114, 33);
            this.btnCandidateSignIn.TabIndex = 2;
            this.btnCandidateSignIn.Text = "Sign Up";
            this.btnCandidateSignIn.UseVisualStyleBackColor = false;
            this.btnCandidateSignIn.Click += new System.EventHandler(this.btnNewUser1_Click);
            // 
            // tbcCollege
            // 
            this.tbcCollege.Controls.Add(this.linkLabel1);
            this.tbcCollege.Controls.Add(this.toolStrip2);
            this.tbcCollege.Controls.Add(this.panel5);
            this.tbcCollege.Controls.Add(this.panel6);
            this.tbcCollege.Location = new System.Drawing.Point(4, 28);
            this.tbcCollege.Name = "tbcCollege";
            this.tbcCollege.Padding = new System.Windows.Forms.Padding(3);
            this.tbcCollege.Size = new System.Drawing.Size(1256, 559);
            this.tbcCollege.TabIndex = 1;
            this.tbcCollege.Text = "College";
            this.tbcCollege.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkBlue;
            this.linkLabel1.Location = new System.Drawing.Point(1141, 28);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(115, 17);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Change Password";
            this.linkLabel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.linkLabel1_MouseClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.DarkBlue;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1250, 25);
            this.toolStrip2.TabIndex = 8;
            this.toolStrip2.Text = "College Login";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.toolStripLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Cornsilk;
            this.toolStripLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(133, 22);
            this.toolStripLabel1.Text = "College Authority Login";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(547, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(119, 92);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lblMessageCollege);
            this.panel6.Controls.Add(this.btnCollegeLogin);
            this.panel6.Controls.Add(this.txtCollegePassword);
            this.panel6.Controls.Add(this.txtCollegeUsername);
            this.panel6.Location = new System.Drawing.Point(440, 113);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(334, 320);
            this.panel6.TabIndex = 7;
            // 
            // lblMessageCollege
            // 
            this.lblMessageCollege.AutoSize = true;
            this.lblMessageCollege.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageCollege.ForeColor = System.Drawing.Color.Red;
            this.lblMessageCollege.Location = new System.Drawing.Point(80, 77);
            this.lblMessageCollege.Name = "lblMessageCollege";
            this.lblMessageCollege.Size = new System.Drawing.Size(0, 18);
            this.lblMessageCollege.TabIndex = 3;
            // 
            // btnCollegeLogin
            // 
            this.btnCollegeLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnCollegeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCollegeLogin.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollegeLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCollegeLogin.Location = new System.Drawing.Point(107, 248);
            this.btnCollegeLogin.Name = "btnCollegeLogin";
            this.btnCollegeLogin.Size = new System.Drawing.Size(133, 38);
            this.btnCollegeLogin.TabIndex = 2;
            this.btnCollegeLogin.Text = "LOGIN";
            this.btnCollegeLogin.UseVisualStyleBackColor = false;
            this.btnCollegeLogin.Click += new System.EventHandler(this.btnCollegeLogin_Click);
            // 
            // txtCollegePassword
            // 
            this.txtCollegePassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCollegePassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtCollegePassword.Location = new System.Drawing.Point(58, 174);
            this.txtCollegePassword.Multiline = true;
            this.txtCollegePassword.Name = "txtCollegePassword";
            this.txtCollegePassword.Size = new System.Drawing.Size(232, 28);
            this.txtCollegePassword.TabIndex = 1;
            this.txtCollegePassword.Text = "Password";
            this.txtCollegePassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCollegePassword_MouseClick);
            this.txtCollegePassword.MouseEnter += new System.EventHandler(this.txtCollegePassword_MouseEnter);
            this.txtCollegePassword.MouseLeave += new System.EventHandler(this.txtCollegePassword_MouseLeave);
            // 
            // txtCollegeUsername
            // 
            this.txtCollegeUsername.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCollegeUsername.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtCollegeUsername.Location = new System.Drawing.Point(58, 112);
            this.txtCollegeUsername.Multiline = true;
            this.txtCollegeUsername.Name = "txtCollegeUsername";
            this.txtCollegeUsername.Size = new System.Drawing.Size(232, 28);
            this.txtCollegeUsername.TabIndex = 0;
            this.txtCollegeUsername.Text = "Username";
            this.txtCollegeUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCollegeUsername_MouseClick);
            this.txtCollegeUsername.TextChanged += new System.EventHandler(this.txtCollegeUsername_TextChanged);
            this.txtCollegeUsername.MouseEnter += new System.EventHandler(this.txtCollegeUsername_MouseEnter);
            this.txtCollegeUsername.MouseLeave += new System.EventHandler(this.txtCollegeUsername_MouseLeave);
            // 
            // tbcAdmin
            // 
            this.tbcAdmin.Controls.Add(this.llblAdminChangePassword);
            this.tbcAdmin.Controls.Add(this.toolStrip3);
            this.tbcAdmin.Controls.Add(this.panel3);
            this.tbcAdmin.Controls.Add(this.panel4);
            this.tbcAdmin.Location = new System.Drawing.Point(4, 28);
            this.tbcAdmin.Name = "tbcAdmin";
            this.tbcAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tbcAdmin.Size = new System.Drawing.Size(1256, 559);
            this.tbcAdmin.TabIndex = 2;
            this.tbcAdmin.Text = "Admin";
            this.tbcAdmin.UseVisualStyleBackColor = true;
            // 
            // llblAdminChangePassword
            // 
            this.llblAdminChangePassword.AutoSize = true;
            this.llblAdminChangePassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblAdminChangePassword.LinkColor = System.Drawing.Color.DarkBlue;
            this.llblAdminChangePassword.Location = new System.Drawing.Point(1135, 28);
            this.llblAdminChangePassword.Name = "llblAdminChangePassword";
            this.llblAdminChangePassword.Size = new System.Drawing.Size(115, 17);
            this.llblAdminChangePassword.TabIndex = 10;
            this.llblAdminChangePassword.TabStop = true;
            this.llblAdminChangePassword.Text = "Change Password";
            this.llblAdminChangePassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.llblAdminChangePassword_MouseClick_1);
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackColor = System.Drawing.Color.DarkBlue;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1250, 25);
            this.toolStrip3.TabIndex = 8;
            this.toolStrip3.Text = "Administrator Login";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.BackColor = System.Drawing.Color.DarkMagenta;
            this.toolStripLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripLabel2.ForeColor = System.Drawing.Color.Cornsilk;
            this.toolStripLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(113, 22);
            this.toolStripLabel2.Text = "Administrator Login";
            this.toolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(549, 66);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(123, 93);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblMessageAdmin);
            this.panel4.Controls.Add(this.btnAdminLogin);
            this.panel4.Controls.Add(this.txtAdminPassword);
            this.panel4.Controls.Add(this.txtAdminUsername);
            this.panel4.Location = new System.Drawing.Point(442, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(334, 320);
            this.panel4.TabIndex = 7;
            // 
            // lblMessageAdmin
            // 
            this.lblMessageAdmin.AutoSize = true;
            this.lblMessageAdmin.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageAdmin.ForeColor = System.Drawing.Color.Red;
            this.lblMessageAdmin.Location = new System.Drawing.Point(86, 82);
            this.lblMessageAdmin.Name = "lblMessageAdmin";
            this.lblMessageAdmin.Size = new System.Drawing.Size(0, 18);
            this.lblMessageAdmin.TabIndex = 4;
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminLogin.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdminLogin.Location = new System.Drawing.Point(107, 248);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(133, 38);
            this.btnAdminLogin.TabIndex = 2;
            this.btnAdminLogin.Text = "LOGIN";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtAdminPassword.Location = new System.Drawing.Point(58, 174);
            this.txtAdminPassword.Multiline = true;
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(232, 28);
            this.txtAdminPassword.TabIndex = 1;
            this.txtAdminPassword.Text = "Password";
            this.txtAdminPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAdminPassword_MouseClick);
            this.txtAdminPassword.MouseEnter += new System.EventHandler(this.txtAdminPassword_MouseEnter);
            this.txtAdminPassword.MouseLeave += new System.EventHandler(this.txtAdminPassword_MouseLeave);
            // 
            // txtAdminUsername
            // 
            this.txtAdminUsername.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminUsername.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtAdminUsername.Location = new System.Drawing.Point(58, 112);
            this.txtAdminUsername.Multiline = true;
            this.txtAdminUsername.Name = "txtAdminUsername";
            this.txtAdminUsername.Size = new System.Drawing.Size(232, 28);
            this.txtAdminUsername.TabIndex = 0;
            this.txtAdminUsername.Text = "Username";
            this.txtAdminUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAdminUsername_MouseClick);
            this.txtAdminUsername.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtAdminUsername.MouseEnter += new System.EventHandler(this.txtAdminUsername_MouseEnter);
            this.txtAdminUsername.MouseLeave += new System.EventHandler(this.txtAdminUsername_MouseLeave);
            // 
            // epCandidateLogin
            // 
            this.epCandidateLogin.ContainerControl = this;
            // 
            // AllotmentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::PresentataionLayer.Properties.Resources._7557127;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tbcLogin);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AllotmentWindow";
            this.Text = "AllotmentWindow";
            this.tbcLogin.ResumeLayout(false);
            this.tbcCandidate.ResumeLayout(false);
            this.tbcCandidate.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbcCollege.ResumeLayout(false);
            this.tbcCollege.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tbcAdmin.ResumeLayout(false);
            this.tbcAdmin.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCandidateLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TabControl tbcLogin;
        private System.Windows.Forms.TabPage tbcCandidate;
        private System.Windows.Forms.TabPage tbcCollege;
        private System.Windows.Forms.TabPage tbcAdmin;
        private System.Windows.Forms.Button btnCandidateSignIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExistingLogin;
        private System.Windows.Forms.TextBox txtCandidatePassword;
        private System.Windows.Forms.TextBox txtCandidateUsername;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslCandidateLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.TextBox txtAdminUsername;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnCollegeLogin;
        private System.Windows.Forms.TextBox txtCollegePassword;
        private System.Windows.Forms.TextBox txtCollegeUsername;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ErrorProvider epCandidateLogin;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblMessageAdmin;
        private System.Windows.Forms.LinkLabel llblChangePassword;
        private System.Windows.Forms.Label lblMessageCollege;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel llblAdminChangePassword;
    }
}