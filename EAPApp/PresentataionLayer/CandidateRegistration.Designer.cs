﻿namespace PresentataionLayer
{
    partial class CandidateRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateRegistration));
            this.btnCandidateRegister = new System.Windows.Forms.Button();
            this.lblTitleCandidate = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspBtnBack = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStar = new System.Windows.Forms.Label();
            this.rbtFemale = new System.Windows.Forms.RadioButton();
            this.rbtMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCandidateName = new System.Windows.Forms.TextBox();
            this.txtCandidateID = new System.Windows.Forms.TextBox();
            this.lblCandidateAddress = new System.Windows.Forms.Label();
            this.lblCandidateDOB = new System.Windows.Forms.Label();
            this.lblCandidateName = new System.Windows.Forms.Label();
            this.lblCandidateId = new System.Windows.Forms.Label();
            this.epRegistration = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epRegistration)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCandidateRegister
            // 
            this.btnCandidateRegister.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCandidateRegister.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCandidateRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCandidateRegister.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCandidateRegister.Location = new System.Drawing.Point(417, 563);
            this.btnCandidateRegister.Name = "btnCandidateRegister";
            this.btnCandidateRegister.Size = new System.Drawing.Size(124, 42);
            this.btnCandidateRegister.TabIndex = 22;
            this.btnCandidateRegister.Text = "REGISTER";
            this.btnCandidateRegister.UseVisualStyleBackColor = false;
            this.btnCandidateRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitleCandidate
            // 
            this.lblTitleCandidate.AutoSize = true;
            this.lblTitleCandidate.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitleCandidate.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCandidate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitleCandidate.Location = new System.Drawing.Point(493, 38);
            this.lblTitleCandidate.Name = "lblTitleCandidate";
            this.lblTitleCandidate.Size = new System.Drawing.Size(239, 31);
            this.lblTitleCandidate.TabIndex = 24;
            this.lblTitleCandidate.Text = "REGISTRATION";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspBtnBack});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tspBtnBack
            // 
            this.tspBtnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspBtnBack.Image = ((System.Drawing.Image)(resources.GetObject("tspBtnBack.Image")));
            this.tspBtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspBtnBack.Name = "tspBtnBack";
            this.tspBtnBack.Size = new System.Drawing.Size(23, 22);
            this.tspBtnBack.Text = "Back";
            this.tspBtnBack.Click += new System.EventHandler(this.tspBtnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblStar);
            this.panel1.Controls.Add(this.rbtFemale);
            this.panel1.Controls.Add(this.rbtMale);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.txtContactNumber);
            this.panel1.Controls.Add(this.lblContactNumber);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dtpDOB);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtCandidateName);
            this.panel1.Controls.Add(this.txtCandidateID);
            this.panel1.Controls.Add(this.lblCandidateAddress);
            this.panel1.Controls.Add(this.lblCandidateDOB);
            this.panel1.Controls.Add(this.lblCandidateName);
            this.panel1.Controls.Add(this.lblCandidateId);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 473);
            this.panel1.TabIndex = 23;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(242, 455);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 18);
            this.lblMessage.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(178, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 18);
            this.label6.TabIndex = 62;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(159, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 18);
            this.label5.TabIndex = 61;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(237, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 18);
            this.label4.TabIndex = 60;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(214, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 18);
            this.label3.TabIndex = 59;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(169, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 18);
            this.label2.TabIndex = 58;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(228, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 18);
            this.label1.TabIndex = 57;
            this.label1.Text = "*";
            // 
            // lblStar
            // 
            this.lblStar.AutoSize = true;
            this.lblStar.ForeColor = System.Drawing.Color.Red;
            this.lblStar.Location = new System.Drawing.Point(205, 72);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(14, 18);
            this.lblStar.TabIndex = 56;
            this.lblStar.Text = "*";
            // 
            // rbtFemale
            // 
            this.rbtFemale.AutoSize = true;
            this.rbtFemale.Location = new System.Drawing.Point(549, 165);
            this.rbtFemale.Name = "rbtFemale";
            this.rbtFemale.Size = new System.Drawing.Size(75, 22);
            this.rbtFemale.TabIndex = 55;
            this.rbtFemale.TabStop = true;
            this.rbtFemale.Text = "Female";
            this.rbtFemale.UseVisualStyleBackColor = true;
            this.rbtFemale.Validating += new System.ComponentModel.CancelEventHandler(this.rbtFemale_Validating);
            // 
            // rbtMale
            // 
            this.rbtMale.AutoSize = true;
            this.rbtMale.Location = new System.Drawing.Point(417, 165);
            this.rbtMale.Name = "rbtMale";
            this.rbtMale.Size = new System.Drawing.Size(58, 22);
            this.rbtMale.TabIndex = 54;
            this.rbtMale.TabStop = true;
            this.rbtMale.Text = "Male";
            this.rbtMale.UseVisualStyleBackColor = true;
            this.rbtMale.Validating += new System.ComponentModel.CancelEventHandler(this.rbtFemale_Validating);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblGender.Location = new System.Drawing.Point(115, 170);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(141, 15);
            this.lblGender.TabIndex = 53;
            this.lblGender.Text = "GENDER                           :";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactNumber.Location = new System.Drawing.Point(417, 258);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(242, 24);
            this.txtContactNumber.TabIndex = 52;
            this.txtContactNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtContactNumber_Validating);
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblContactNumber.Location = new System.Drawing.Point(114, 264);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(143, 15);
            this.lblContactNumber.TabIndex = 51;
            this.lblContactNumber.Text = "CONTACT NUMBER      :";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Location = new System.Drawing.Point(417, 313);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(242, 24);
            this.txtEmail.TabIndex = 50;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEmail.Location = new System.Drawing.Point(114, 313);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(141, 15);
            this.lblEmail.TabIndex = 49;
            this.lblEmail.Text = "E-MAIL                              :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1261, 39);
            this.button1.TabIndex = 48;
            this.button1.Text = "    Personal Details";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd-MM-yyyy";
            this.dtpDOB.Location = new System.Drawing.Point(417, 206);
            this.dtpDOB.MaxDate = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1997, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(242, 24);
            this.dtpDOB.TabIndex = 45;
            this.dtpDOB.Value = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            this.dtpDOB.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDOB_Validating);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(417, 369);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(242, 78);
            this.txtAddress.TabIndex = 44;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // txtCandidateName
            // 
            this.txtCandidateName.Location = new System.Drawing.Point(417, 119);
            this.txtCandidateName.Name = "txtCandidateName";
            this.txtCandidateName.Size = new System.Drawing.Size(242, 24);
            this.txtCandidateName.TabIndex = 38;
            this.txtCandidateName.Validating += new System.ComponentModel.CancelEventHandler(this.txtCandidateName_Validating);
            // 
            // txtCandidateID
            // 
            this.txtCandidateID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCandidateID.Location = new System.Drawing.Point(417, 66);
            this.txtCandidateID.Name = "txtCandidateID";
            this.txtCandidateID.Size = new System.Drawing.Size(242, 24);
            this.txtCandidateID.TabIndex = 37;
            this.txtCandidateID.Validating += new System.ComponentModel.CancelEventHandler(this.txtCandidateID_Validating);
            // 
            // lblCandidateAddress
            // 
            this.lblCandidateAddress.AutoSize = true;
            this.lblCandidateAddress.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateAddress.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCandidateAddress.Location = new System.Drawing.Point(114, 369);
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
            this.lblCandidateDOB.Location = new System.Drawing.Point(114, 214);
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
            this.lblCandidateName.Location = new System.Drawing.Point(114, 126);
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
            this.lblCandidateId.Location = new System.Drawing.Point(114, 73);
            this.lblCandidateId.Name = "lblCandidateId";
            this.lblCandidateId.Size = new System.Drawing.Size(142, 15);
            this.lblCandidateId.TabIndex = 26;
            this.lblCandidateId.Text = "CANDIDATE ID               :";
            // 
            // epRegistration
            // 
            this.epRegistration.ContainerControl = this;
            // 
            // CandidateRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblTitleCandidate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCandidateRegister);
            this.Name = "CandidateRegistration";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Candidate";
            this.Load += new System.EventHandler(this.Candidate_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epRegistration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCandidateRegister;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ToolStripButton tspBtnBack;
        private System.Windows.Forms.RadioButton rbtFemale;
        private System.Windows.Forms.RadioButton rbtMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.ErrorProvider epRegistration;
        private System.Windows.Forms.Label lblMessage;
    }
}