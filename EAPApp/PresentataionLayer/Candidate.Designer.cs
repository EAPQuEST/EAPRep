namespace PresentataionLayer
{
    partial class Candidate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Candidate));
            this.btnCandidateNext = new System.Windows.Forms.Button();
            this.lblTitleCandidate = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspHome = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCandidateName = new System.Windows.Forms.TextBox();
            this.txtCandidateID = new System.Windows.Forms.TextBox();
            this.lblCandidateAddress = new System.Windows.Forms.Label();
            this.lblCandidateDOB = new System.Windows.Forms.Label();
            this.lblCandidateName = new System.Windows.Forms.Label();
            this.lblCandidateId = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCandidateNext
            // 
            this.btnCandidateNext.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCandidateNext.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCandidateNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCandidateNext.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCandidateNext.Location = new System.Drawing.Point(643, 550);
            this.btnCandidateNext.Name = "btnCandidateNext";
            this.btnCandidateNext.Size = new System.Drawing.Size(124, 42);
            this.btnCandidateNext.TabIndex = 22;
            this.btnCandidateNext.Text = "REGISTER";
            this.btnCandidateNext.UseVisualStyleBackColor = false;
            this.btnCandidateNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitleCandidate
            // 
            this.lblTitleCandidate.AutoSize = true;
            this.lblTitleCandidate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitleCandidate.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCandidate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitleCandidate.Location = new System.Drawing.Point(291, 43);
            this.lblTitleCandidate.Name = "lblTitleCandidate";
            this.lblTitleCandidate.Size = new System.Drawing.Size(203, 25);
            this.lblTitleCandidate.TabIndex = 24;
            this.lblTitleCandidate.Text = "REGISTRATION";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspHome});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(799, 25);
            this.toolStrip1.TabIndex = 25;
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
            this.tspHome.Text = "Home";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtContactNumber);
            this.panel1.Controls.Add(this.lblContactNumber);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.dtpDOB);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtCandidateName);
            this.panel1.Controls.Add(this.txtCandidateID);
            this.panel1.Controls.Add(this.lblCandidateAddress);
            this.panel1.Controls.Add(this.lblCandidateDOB);
            this.panel1.Controls.Add(this.lblCandidateName);
            this.panel1.Controls.Add(this.lblCandidateId);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 452);
            this.panel1.TabIndex = 23;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMessage.Location = new System.Drawing.Point(75, 13);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 18);
            this.lblMessage.TabIndex = 46;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(407, 198);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(242, 24);
            this.dtpDOB.TabIndex = 45;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(407, 361);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(242, 78);
            this.txtAddress.TabIndex = 44;
            // 
            // txtCandidateName
            // 
            this.txtCandidateName.Location = new System.Drawing.Point(407, 141);
            this.txtCandidateName.Name = "txtCandidateName";
            this.txtCandidateName.Size = new System.Drawing.Size(242, 24);
            this.txtCandidateName.TabIndex = 38;
            // 
            // txtCandidateID
            // 
            this.txtCandidateID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCandidateID.Location = new System.Drawing.Point(407, 88);
            this.txtCandidateID.Name = "txtCandidateID";
            this.txtCandidateID.Size = new System.Drawing.Size(242, 24);
            this.txtCandidateID.TabIndex = 37;
            // 
            // lblCandidateAddress
            // 
            this.lblCandidateAddress.AutoSize = true;
            this.lblCandidateAddress.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateAddress.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCandidateAddress.Location = new System.Drawing.Point(104, 361);
            this.lblCandidateAddress.Name = "lblCandidateAddress";
            this.lblCandidateAddress.Size = new System.Drawing.Size(137, 15);
            this.lblCandidateAddress.TabIndex = 29;
            this.lblCandidateAddress.Text = "ADDRESS                       :";
            // 
            // lblCandidateDOB
            // 
            this.lblCandidateDOB.AutoSize = true;
            this.lblCandidateDOB.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateDOB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCandidateDOB.Location = new System.Drawing.Point(104, 206);
            this.lblCandidateDOB.Name = "lblCandidateDOB";
            this.lblCandidateDOB.Size = new System.Drawing.Size(144, 15);
            this.lblCandidateDOB.TabIndex = 28;
            this.lblCandidateDOB.Text = "DATE OF BIRTH              :";
            // 
            // lblCandidateName
            // 
            this.lblCandidateName.AutoSize = true;
            this.lblCandidateName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCandidateName.Location = new System.Drawing.Point(104, 148);
            this.lblCandidateName.Name = "lblCandidateName";
            this.lblCandidateName.Size = new System.Drawing.Size(143, 15);
            this.lblCandidateName.TabIndex = 27;
            this.lblCandidateName.Text = "CANDIDATE NAME        :";
            // 
            // lblCandidateId
            // 
            this.lblCandidateId.AutoSize = true;
            this.lblCandidateId.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateId.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCandidateId.Location = new System.Drawing.Point(104, 95);
            this.lblCandidateId.Name = "lblCandidateId";
            this.lblCandidateId.Size = new System.Drawing.Size(142, 15);
            this.lblCandidateId.TabIndex = 26;
            this.lblCandidateId.Text = "CANDIDATE ID               :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(800, 32);
            this.button1.TabIndex = 48;
            this.button1.Text = "      Personal Details";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Location = new System.Drawing.Point(407, 305);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(242, 24);
            this.txtEmail.TabIndex = 50;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEmail.Location = new System.Drawing.Point(104, 305);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(141, 15);
            this.lblEmail.TabIndex = 49;
            this.lblEmail.Text = "E-MAIL                              :";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactNumber.Location = new System.Drawing.Point(407, 250);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(242, 24);
            this.txtContactNumber.TabIndex = 52;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblContactNumber.Location = new System.Drawing.Point(104, 256);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(143, 15);
            this.lblContactNumber.TabIndex = 51;
            this.lblContactNumber.Text = "CONTACT NUMBER      :";
            // 
            // Candidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 661);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblTitleCandidate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCandidateNext);
            this.Name = "Candidate";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Candidate";
            this.Load += new System.EventHandler(this.Candidate_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCandidateNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCandidateName;
        private System.Windows.Forms.TextBox txtCandidateID;
        private System.Windows.Forms.Label lblCandidateAddress;
        private System.Windows.Forms.Label lblCandidateDOB;
        private System.Windows.Forms.Label lblCandidateName;
        private System.Windows.Forms.Label lblCandidateId;
        private System.Windows.Forms.Label lblTitleCandidate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tspHome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}