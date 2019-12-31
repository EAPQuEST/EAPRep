namespace PresentataionLayer
{
    partial class AddCollege
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCollege));
            this.pnlCollegeDetails = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtTotalSeat = new System.Windows.Forms.TextBox();
            this.txtCollegeName = new System.Windows.Forms.TextBox();
            this.txtCollegeID = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCollegeId = new System.Windows.Forms.Label();
            this.lblCollegeTotalSeats = new System.Windows.Forms.Label();
            this.lblCollegeName = new System.Windows.Forms.Label();
            this.lblCollegeDetails = new System.Windows.Forms.Label();
            this.tlsAddCollege = new System.Windows.Forms.ToolStrip();
            this.tlsBtnHomeAdd = new System.Windows.Forms.ToolStripButton();
            this.pnlCourseDetails = new System.Windows.Forms.Panel();
            this.lblCourseDetails = new System.Windows.Forms.Label();
            this.clbCoursesAvailable = new System.Windows.Forms.CheckedListBox();
            this.btnAddCollege = new System.Windows.Forms.Button();
            this.lblCourseAvailable = new System.Windows.Forms.Label();
            this.pnlCollegeDetails.SuspendLayout();
            this.tlsAddCollege.SuspendLayout();
            this.pnlCourseDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCollegeDetails
            // 
            this.pnlCollegeDetails.BackColor = System.Drawing.Color.White;
            this.pnlCollegeDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCollegeDetails.Controls.Add(this.lblMessage);
            this.pnlCollegeDetails.Controls.Add(this.txtAddress);
            this.pnlCollegeDetails.Controls.Add(this.txtContactNumber);
            this.pnlCollegeDetails.Controls.Add(this.txtTotalSeat);
            this.pnlCollegeDetails.Controls.Add(this.txtCollegeName);
            this.pnlCollegeDetails.Controls.Add(this.txtCollegeID);
            this.pnlCollegeDetails.Controls.Add(this.lblContactNumber);
            this.pnlCollegeDetails.Controls.Add(this.lblAddress);
            this.pnlCollegeDetails.Controls.Add(this.lblCollegeId);
            this.pnlCollegeDetails.Controls.Add(this.lblCollegeTotalSeats);
            this.pnlCollegeDetails.Controls.Add(this.lblCollegeName);
            this.pnlCollegeDetails.Controls.Add(this.lblCollegeDetails);
            this.pnlCollegeDetails.Location = new System.Drawing.Point(5, 28);
            this.pnlCollegeDetails.Name = "pnlCollegeDetails";
            this.pnlCollegeDetails.Size = new System.Drawing.Size(421, 406);
            this.pnlCollegeDetails.TabIndex = 4;
            this.pnlCollegeDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCollegeDetails_Paint);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(63, 64);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 11;
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
            // txtTotalSeat
            // 
            this.txtTotalSeat.Location = new System.Drawing.Point(195, 208);
            this.txtTotalSeat.Name = "txtTotalSeat";
            this.txtTotalSeat.Size = new System.Drawing.Size(176, 20);
            this.txtTotalSeat.TabIndex = 8;
            // 
            // txtCollegeName
            // 
            this.txtCollegeName.Location = new System.Drawing.Point(195, 154);
            this.txtCollegeName.Name = "txtCollegeName";
            this.txtCollegeName.Size = new System.Drawing.Size(176, 20);
            this.txtCollegeName.TabIndex = 7;
            // 
            // txtCollegeID
            // 
            this.txtCollegeID.Location = new System.Drawing.Point(195, 97);
            this.txtCollegeID.Name = "txtCollegeID";
            this.txtCollegeID.Size = new System.Drawing.Size(176, 20);
            this.txtCollegeID.TabIndex = 6;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.Location = new System.Drawing.Point(30, 262);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(160, 17);
            this.lblContactNumber.TabIndex = 5;
            this.lblContactNumber.Text = "CONTACT NUMBER    :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(30, 317);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(207, 17);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "ADDRESS                                :";
            // 
            // lblCollegeId
            // 
            this.lblCollegeId.AutoSize = true;
            this.lblCollegeId.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollegeId.Location = new System.Drawing.Point(30, 97);
            this.lblCollegeId.Name = "lblCollegeId";
            this.lblCollegeId.Size = new System.Drawing.Size(200, 17);
            this.lblCollegeId.TabIndex = 3;
            this.lblCollegeId.Text = "COLLEGE ID                         :";
            // 
            // lblCollegeTotalSeats
            // 
            this.lblCollegeTotalSeats.AutoSize = true;
            this.lblCollegeTotalSeats.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollegeTotalSeats.Location = new System.Drawing.Point(30, 208);
            this.lblCollegeTotalSeats.Name = "lblCollegeTotalSeats";
            this.lblCollegeTotalSeats.Size = new System.Drawing.Size(196, 17);
            this.lblCollegeTotalSeats.TabIndex = 2;
            this.lblCollegeTotalSeats.Text = "TOTAL SEATS                      :";
            // 
            // lblCollegeName
            // 
            this.lblCollegeName.AutoSize = true;
            this.lblCollegeName.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollegeName.Location = new System.Drawing.Point(30, 154);
            this.lblCollegeName.Name = "lblCollegeName";
            this.lblCollegeName.Size = new System.Drawing.Size(182, 17);
            this.lblCollegeName.TabIndex = 1;
            this.lblCollegeName.Text = "COLLEGE NAME              :";
            // 
            // lblCollegeDetails
            // 
            this.lblCollegeDetails.AutoSize = true;
            this.lblCollegeDetails.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollegeDetails.Location = new System.Drawing.Point(150, 32);
            this.lblCollegeDetails.Name = "lblCollegeDetails";
            this.lblCollegeDetails.Size = new System.Drawing.Size(159, 17);
            this.lblCollegeDetails.TabIndex = 0;
            this.lblCollegeDetails.Text = "COLLEGE DETAILS";
            // 
            // tlsAddCollege
            // 
            this.tlsAddCollege.BackColor = System.Drawing.Color.CadetBlue;
            this.tlsAddCollege.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsAddCollege.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsBtnHomeAdd});
            this.tlsAddCollege.Location = new System.Drawing.Point(0, 0);
            this.tlsAddCollege.Name = "tlsAddCollege";
            this.tlsAddCollege.Size = new System.Drawing.Size(868, 25);
            this.tlsAddCollege.TabIndex = 6;
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
            this.tlsBtnHomeAdd.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // pnlCourseDetails
            // 
            this.pnlCourseDetails.BackColor = System.Drawing.Color.White;
            this.pnlCourseDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCourseDetails.Controls.Add(this.btnAddCollege);
            this.pnlCourseDetails.Controls.Add(this.clbCoursesAvailable);
            this.pnlCourseDetails.Controls.Add(this.lblCourseDetails);
            this.pnlCourseDetails.Controls.Add(this.lblCourseAvailable);
            this.pnlCourseDetails.Location = new System.Drawing.Point(429, 28);
            this.pnlCourseDetails.Name = "pnlCourseDetails";
            this.pnlCourseDetails.Size = new System.Drawing.Size(427, 406);
            this.pnlCourseDetails.TabIndex = 5;
            // 
            // lblCourseDetails
            // 
            this.lblCourseDetails.AutoSize = true;
            this.lblCourseDetails.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseDetails.Location = new System.Drawing.Point(160, 32);
            this.lblCourseDetails.Name = "lblCourseDetails";
            this.lblCourseDetails.Size = new System.Drawing.Size(147, 17);
            this.lblCourseDetails.TabIndex = 6;
            this.lblCourseDetails.Text = "COURSE DETAILS";
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
            "Ocean and Marine Engineering",
            "Industrial Engineering"});
            this.clbCoursesAvailable.Location = new System.Drawing.Point(175, 97);
            this.clbCoursesAvailable.Name = "clbCoursesAvailable";
            this.clbCoursesAvailable.Size = new System.Drawing.Size(236, 199);
            this.clbCoursesAvailable.TabIndex = 12;
            // 
            // btnAddCollege
            // 
            this.btnAddCollege.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCollege.Location = new System.Drawing.Point(280, 352);
            this.btnAddCollege.Name = "btnAddCollege";
            this.btnAddCollege.Size = new System.Drawing.Size(131, 33);
            this.btnAddCollege.TabIndex = 13;
            this.btnAddCollege.Text = "INSERT";
            this.btnAddCollege.UseVisualStyleBackColor = true;
            this.btnAddCollege.Click += new System.EventHandler(this.btnAddCollege_Click);
            // 
            // lblCourseAvailable
            // 
            this.lblCourseAvailable.AutoSize = true;
            this.lblCourseAvailable.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseAvailable.Location = new System.Drawing.Point(3, 97);
            this.lblCourseAvailable.Name = "lblCourseAvailable";
            this.lblCourseAvailable.Size = new System.Drawing.Size(171, 17);
            this.lblCourseAvailable.TabIndex = 7;
            this.lblCourseAvailable.Text = "COURSES AVAILABLE :";
            // 
            // AddCollege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.tlsAddCollege);
            this.Controls.Add(this.pnlCollegeDetails);
            this.Controls.Add(this.pnlCourseDetails);
            this.Name = "AddCollege";
            this.Text = "AddCollege";
            this.Load += new System.EventHandler(this.AddCollege_Load);
            this.pnlCollegeDetails.ResumeLayout(false);
            this.pnlCollegeDetails.PerformLayout();
            this.tlsAddCollege.ResumeLayout(false);
            this.tlsAddCollege.PerformLayout();
            this.pnlCourseDetails.ResumeLayout(false);
            this.pnlCourseDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCollegeDetails;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtTotalSeat;
        private System.Windows.Forms.TextBox txtCollegeName;
        private System.Windows.Forms.TextBox txtCollegeID;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCollegeId;
        private System.Windows.Forms.Label lblCollegeTotalSeats;
        private System.Windows.Forms.Label lblCollegeName;
        private System.Windows.Forms.Label lblCollegeDetails;
        private System.Windows.Forms.ToolStrip tlsAddCollege;
        private System.Windows.Forms.ToolStripButton tlsBtnHomeAdd;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel pnlCourseDetails;
        private System.Windows.Forms.Button btnAddCollege;
        private System.Windows.Forms.CheckedListBox clbCoursesAvailable;
        private System.Windows.Forms.Label lblCourseDetails;
        private System.Windows.Forms.Label lblCourseAvailable;
    }
}