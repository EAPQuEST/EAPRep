namespace PresentataionLayer
{
    partial class UpdateCollege
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCollege));
            this.tlsAddCollege = new System.Windows.Forms.ToolStrip();
            this.tlsBtnHomeAdd = new System.Windows.Forms.ToolStripButton();
            this.pnlCollegeDetails = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.cmbCollegeId = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtTotalSeats = new System.Windows.Forms.TextBox();
            this.txtCollegeName = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCollegeId = new System.Windows.Forms.Label();
            this.lblCollegeTotalSeats = new System.Windows.Forms.Label();
            this.lblCollegeName = new System.Windows.Forms.Label();
            this.lblCollegeDetails = new System.Windows.Forms.Label();
            this.pnlCourseDetails = new System.Windows.Forms.Panel();
            this.btnUpdateCollege = new System.Windows.Forms.Button();
            this.clbCoursesAvailable = new System.Windows.Forms.CheckedListBox();
            this.lblCourseDetails = new System.Windows.Forms.Label();
            this.lblCourseAvailable = new System.Windows.Forms.Label();
            this.tlsAddCollege.SuspendLayout();
            this.pnlCollegeDetails.SuspendLayout();
            this.pnlCourseDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsAddCollege
            // 
            this.tlsAddCollege.BackColor = System.Drawing.Color.CadetBlue;
            this.tlsAddCollege.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsAddCollege.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsBtnHomeAdd});
            this.tlsAddCollege.Location = new System.Drawing.Point(0, 0);
            this.tlsAddCollege.Name = "tlsAddCollege";
            this.tlsAddCollege.Size = new System.Drawing.Size(845, 25);
            this.tlsAddCollege.TabIndex = 9;
            this.tlsAddCollege.Text = "toolStrip1";
            // 
            // tlsBtnHomeAdd
            // 
            this.tlsBtnHomeAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnHomeAdd.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnHomeAdd.Image")));
            this.tlsBtnHomeAdd.ImageTransparentColor = System.Drawing.Color.MediumAquamarine;
            this.tlsBtnHomeAdd.Name = "tlsBtnHomeAdd";
            this.tlsBtnHomeAdd.Size = new System.Drawing.Size(23, 22);
            this.tlsBtnHomeAdd.Text = "Home";
            // 
            // pnlCollegeDetails
            // 
            this.pnlCollegeDetails.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlCollegeDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCollegeDetails.Controls.Add(this.lblMessage);
            this.pnlCollegeDetails.Controls.Add(this.cmbCollegeId);
            this.pnlCollegeDetails.Controls.Add(this.txtAddress);
            this.pnlCollegeDetails.Controls.Add(this.txtContactNumber);
            this.pnlCollegeDetails.Controls.Add(this.txtTotalSeats);
            this.pnlCollegeDetails.Controls.Add(this.txtCollegeName);
            this.pnlCollegeDetails.Controls.Add(this.lblContactNumber);
            this.pnlCollegeDetails.Controls.Add(this.lblAddress);
            this.pnlCollegeDetails.Controls.Add(this.lblCollegeId);
            this.pnlCollegeDetails.Controls.Add(this.lblCollegeTotalSeats);
            this.pnlCollegeDetails.Controls.Add(this.lblCollegeName);
            this.pnlCollegeDetails.Controls.Add(this.lblCollegeDetails);
            this.pnlCollegeDetails.Location = new System.Drawing.Point(0, 28);
            this.pnlCollegeDetails.Name = "pnlCollegeDetails";
            this.pnlCollegeDetails.Size = new System.Drawing.Size(409, 411);
            this.pnlCollegeDetails.TabIndex = 7;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(46, 14);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 12;
            // 
            // cmbCollegeId
            // 
            this.cmbCollegeId.FormattingEnabled = true;
            this.cmbCollegeId.Location = new System.Drawing.Point(195, 97);
            this.cmbCollegeId.Name = "cmbCollegeId";
            this.cmbCollegeId.Size = new System.Drawing.Size(176, 21);
            this.cmbCollegeId.TabIndex = 11;
            this.cmbCollegeId.Text = "(Select ID)";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(195, 317);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(176, 68);
            this.txtAddress.TabIndex = 10;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(195, 259);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(176, 20);
            this.txtContactNumber.TabIndex = 9;
            // 
            // txtTotalSeats
            // 
            this.txtTotalSeats.Location = new System.Drawing.Point(195, 208);
            this.txtTotalSeats.Name = "txtTotalSeats";
            this.txtTotalSeats.Size = new System.Drawing.Size(176, 20);
            this.txtTotalSeats.TabIndex = 8;
            // 
            // txtCollegeName
            // 
            this.txtCollegeName.Location = new System.Drawing.Point(195, 154);
            this.txtCollegeName.Name = "txtCollegeName";
            this.txtCollegeName.Size = new System.Drawing.Size(176, 20);
            this.txtCollegeName.TabIndex = 7;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.Location = new System.Drawing.Point(30, 262);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(127, 15);
            this.lblContactNumber.TabIndex = 5;
            this.lblContactNumber.Text = "CONTACT NUMBER ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(30, 317);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(114, 15);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "ADDRESS                ";
            // 
            // lblCollegeId
            // 
            this.lblCollegeId.AutoSize = true;
            this.lblCollegeId.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollegeId.Location = new System.Drawing.Point(30, 97);
            this.lblCollegeId.Name = "lblCollegeId";
            this.lblCollegeId.Size = new System.Drawing.Size(114, 15);
            this.lblCollegeId.TabIndex = 3;
            this.lblCollegeId.Text = "COLLEGE ID           ";
            // 
            // lblCollegeTotalSeats
            // 
            this.lblCollegeTotalSeats.AutoSize = true;
            this.lblCollegeTotalSeats.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollegeTotalSeats.Location = new System.Drawing.Point(30, 208);
            this.lblCollegeTotalSeats.Name = "lblCollegeTotalSeats";
            this.lblCollegeTotalSeats.Size = new System.Drawing.Size(105, 15);
            this.lblCollegeTotalSeats.TabIndex = 2;
            this.lblCollegeTotalSeats.Text = "TOTAL SEATS     ";
            // 
            // lblCollegeName
            // 
            this.lblCollegeName.AutoSize = true;
            this.lblCollegeName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollegeName.Location = new System.Drawing.Point(30, 154);
            this.lblCollegeName.Name = "lblCollegeName";
            this.lblCollegeName.Size = new System.Drawing.Size(107, 15);
            this.lblCollegeName.TabIndex = 1;
            this.lblCollegeName.Text = "COLLEGE NAME ";
            // 
            // lblCollegeDetails
            // 
            this.lblCollegeDetails.AutoSize = true;
            this.lblCollegeDetails.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollegeDetails.Location = new System.Drawing.Point(97, 32);
            this.lblCollegeDetails.Name = "lblCollegeDetails";
            this.lblCollegeDetails.Size = new System.Drawing.Size(185, 21);
            this.lblCollegeDetails.TabIndex = 0;
            this.lblCollegeDetails.Text = "COLLEGE DETAILS";
            // 
            // pnlCourseDetails
            // 
            this.pnlCourseDetails.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlCourseDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCourseDetails.Controls.Add(this.btnUpdateCollege);
            this.pnlCourseDetails.Controls.Add(this.clbCoursesAvailable);
            this.pnlCourseDetails.Controls.Add(this.lblCourseDetails);
            this.pnlCourseDetails.Controls.Add(this.lblCourseAvailable);
            this.pnlCourseDetails.Location = new System.Drawing.Point(415, 28);
            this.pnlCourseDetails.Name = "pnlCourseDetails";
            this.pnlCourseDetails.Size = new System.Drawing.Size(430, 411);
            this.pnlCourseDetails.TabIndex = 8;
            // 
            // btnUpdateCollege
            // 
            this.btnUpdateCollege.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUpdateCollege.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateCollege.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCollege.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCollege.Location = new System.Drawing.Point(255, 328);
            this.btnUpdateCollege.Name = "btnUpdateCollege";
            this.btnUpdateCollege.Size = new System.Drawing.Size(138, 44);
            this.btnUpdateCollege.TabIndex = 13;
            this.btnUpdateCollege.Text = "UPDATE";
            this.btnUpdateCollege.UseVisualStyleBackColor = false;
            // 
            // clbCoursesAvailable
            // 
            this.clbCoursesAvailable.FormattingEnabled = true;
            this.clbCoursesAvailable.Items.AddRange(new object[] {
            "Civil Engineering",
            "Mechanical Engineering",
            "Electrical Engineering",
            "Electrical & Electronics Engineering",
            "Electronics & Communication Engineering",
            "Computer Science and Engineering",
            "Biotechnology",
            "Electronics & Instrumentation Engineering",
            "Information Technology",
            "Automobile Engineering",
            "Aeronautical Engineering",
            "Architectural Engineering or Architecture",
            "Aerospace Engineering",
            "Genetic Engineering",
            "Ocean and Marine Engineering"});
            this.clbCoursesAvailable.Location = new System.Drawing.Point(172, 97);
            this.clbCoursesAvailable.Name = "clbCoursesAvailable";
            this.clbCoursesAvailable.Size = new System.Drawing.Size(236, 199);
            this.clbCoursesAvailable.TabIndex = 12;
            // 
            // lblCourseDetails
            // 
            this.lblCourseDetails.AutoSize = true;
            this.lblCourseDetails.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseDetails.Location = new System.Drawing.Point(130, 32);
            this.lblCourseDetails.Name = "lblCourseDetails";
            this.lblCourseDetails.Size = new System.Drawing.Size(169, 21);
            this.lblCourseDetails.TabIndex = 6;
            this.lblCourseDetails.Text = "COURSE DETAILS";
            // 
            // lblCourseAvailable
            // 
            this.lblCourseAvailable.AutoSize = true;
            this.lblCourseAvailable.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseAvailable.Location = new System.Drawing.Point(23, 97);
            this.lblCourseAvailable.Name = "lblCourseAvailable";
            this.lblCourseAvailable.Size = new System.Drawing.Size(136, 15);
            this.lblCourseAvailable.TabIndex = 7;
            this.lblCourseAvailable.Text = "COURSES AVAILABLE";
            // 
            // UpdateCollege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 446);
            this.Controls.Add(this.tlsAddCollege);
            this.Controls.Add(this.pnlCollegeDetails);
            this.Controls.Add(this.pnlCourseDetails);
            this.Name = "UpdateCollege";
            this.Text = "UpdateCollege";
            this.tlsAddCollege.ResumeLayout(false);
            this.tlsAddCollege.PerformLayout();
            this.pnlCollegeDetails.ResumeLayout(false);
            this.pnlCollegeDetails.PerformLayout();
            this.pnlCourseDetails.ResumeLayout(false);
            this.pnlCourseDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsAddCollege;
        private System.Windows.Forms.ToolStripButton tlsBtnHomeAdd;
        private System.Windows.Forms.Panel pnlCollegeDetails;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtTotalSeats;
        private System.Windows.Forms.TextBox txtCollegeName;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCollegeId;
        private System.Windows.Forms.Label lblCollegeTotalSeats;
        private System.Windows.Forms.Label lblCollegeName;
        private System.Windows.Forms.Label lblCollegeDetails;
        private System.Windows.Forms.Panel pnlCourseDetails;
        private System.Windows.Forms.Button btnUpdateCollege;
        private System.Windows.Forms.CheckedListBox clbCoursesAvailable;
        private System.Windows.Forms.Label lblCourseDetails;
        private System.Windows.Forms.ComboBox cmbCollegeId;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblCourseAvailable;
    }
}