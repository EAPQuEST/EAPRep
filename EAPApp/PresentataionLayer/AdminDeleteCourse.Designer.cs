namespace PresentataionLayer
{
    partial class AdminDeleteCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDeleteCourse));
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCollegeName = new System.Windows.Forms.Label();
            this.cmbCollegeNameSearch = new System.Windows.Forms.ComboBox();
            this.cmbCourseName = new System.Windows.Forms.ComboBox();
            this.lblCoursenameSearch = new System.Windows.Forms.Label();
            this.tlsDeleteCollege = new System.Windows.Forms.ToolStrip();
            this.tlsBtnHomeDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.pnlCourseDetails = new System.Windows.Forms.Panel();
            this.cmbAddCourse = new System.Windows.Forms.ComboBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCourseDetails = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tlsDeleteCollege.SuspendLayout();
            this.pnlCourseDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteCourse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteCourse.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCourse.Location = new System.Drawing.Point(321, 173);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(110, 48);
            this.btnDeleteCourse.TabIndex = 2;
            this.btnDeleteCourse.Text = "DELETE";
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(58, 173);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCollegeName);
            this.panel1.Controls.Add(this.cmbCollegeNameSearch);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.cmbCourseName);
            this.panel1.Controls.Add(this.btnDeleteCourse);
            this.panel1.Controls.Add(this.lblCoursenameSearch);
            this.panel1.Location = new System.Drawing.Point(26, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 322);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "DELETE COURSE";
            // 
            // lblCollegeName
            // 
            this.lblCollegeName.AutoSize = true;
            this.lblCollegeName.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollegeName.Location = new System.Drawing.Point(34, 55);
            this.lblCollegeName.Name = "lblCollegeName";
            this.lblCollegeName.Size = new System.Drawing.Size(189, 17);
            this.lblCollegeName.TabIndex = 9;
            this.lblCollegeName.Text = "SELECT COLLEGE NAME :";
            // 
            // cmbCollegeNameSearch
            // 
            this.cmbCollegeNameSearch.FormattingEnabled = true;
            this.cmbCollegeNameSearch.Location = new System.Drawing.Point(271, 55);
            this.cmbCollegeNameSearch.Name = "cmbCollegeNameSearch";
            this.cmbCollegeNameSearch.Size = new System.Drawing.Size(197, 21);
            this.cmbCollegeNameSearch.TabIndex = 8;
            this.cmbCollegeNameSearch.SelectedIndexChanged += new System.EventHandler(this.cmbCollegeNameSearch_SelectedIndexChanged_1);
            // 
            // cmbCourseName
            // 
            this.cmbCourseName.FormattingEnabled = true;
            this.cmbCourseName.Location = new System.Drawing.Point(271, 119);
            this.cmbCourseName.Name = "cmbCourseName";
            this.cmbCourseName.Size = new System.Drawing.Size(197, 21);
            this.cmbCourseName.TabIndex = 7;
            this.cmbCourseName.SelectedIndexChanged += new System.EventHandler(this.cmbCourseName_SelectedIndexChanged);
            // 
            // lblCoursenameSearch
            // 
            this.lblCoursenameSearch.AutoSize = true;
            this.lblCoursenameSearch.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoursenameSearch.Location = new System.Drawing.Point(35, 119);
            this.lblCoursenameSearch.Name = "lblCoursenameSearch";
            this.lblCoursenameSearch.Size = new System.Drawing.Size(190, 17);
            this.lblCoursenameSearch.TabIndex = 6;
            this.lblCoursenameSearch.Text = "SELECT COURSE NAME    :";
            // 
            // tlsDeleteCollege
            // 
            this.tlsDeleteCollege.BackColor = System.Drawing.Color.CadetBlue;
            this.tlsDeleteCollege.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsBtnHomeDelete,
            this.toolStripLabel1});
            this.tlsDeleteCollege.Location = new System.Drawing.Point(0, 0);
            this.tlsDeleteCollege.Name = "tlsDeleteCollege";
            this.tlsDeleteCollege.Size = new System.Drawing.Size(1264, 25);
            this.tlsDeleteCollege.TabIndex = 7;
            this.tlsDeleteCollege.Text = "toolStrip1";
            // 
            // tlsBtnHomeDelete
            // 
            this.tlsBtnHomeDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tlsBtnHomeDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnHomeDelete.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnHomeDelete.Image")));
            this.tlsBtnHomeDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnHomeDelete.Name = "tlsBtnHomeDelete";
            this.tlsBtnHomeDelete.Size = new System.Drawing.Size(23, 22);
            this.tlsBtnHomeDelete.Text = "Sign Out";
            this.tlsBtnHomeDelete.Click += new System.EventHandler(this.tlsBtnHomeDelete_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(85, 22);
            this.toolStripLabel1.Text = "Update Course";
            // 
            // pnlCourseDetails
            // 
            this.pnlCourseDetails.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlCourseDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCourseDetails.Controls.Add(this.cmbAddCourse);
            this.pnlCourseDetails.Controls.Add(this.btnAddCourse);
            this.pnlCourseDetails.Controls.Add(this.label2);
            this.pnlCourseDetails.Controls.Add(this.lblCourseDetails);
            this.pnlCourseDetails.Location = new System.Drawing.Point(686, 115);
            this.pnlCourseDetails.Name = "pnlCourseDetails";
            this.pnlCourseDetails.Size = new System.Drawing.Size(530, 322);
            this.pnlCourseDetails.TabIndex = 9;
            // 
            // cmbAddCourse
            // 
            this.cmbAddCourse.FormattingEnabled = true;
            this.cmbAddCourse.Location = new System.Drawing.Point(266, 119);
            this.cmbAddCourse.Name = "cmbAddCourse";
            this.cmbAddCourse.Size = new System.Drawing.Size(197, 21);
            this.cmbAddCourse.TabIndex = 12;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCourse.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Location = new System.Drawing.Point(358, 209);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(110, 48);
            this.btnAddCourse.TabIndex = 10;
            this.btnAddCourse.Text = "ADD";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "SELECT COURSE NAME    :";
            // 
            // lblCourseDetails
            // 
            this.lblCourseDetails.AutoSize = true;
            this.lblCourseDetails.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseDetails.Location = new System.Drawing.Point(29, 13);
            this.lblCourseDetails.Name = "lblCourseDetails";
            this.lblCourseDetails.Size = new System.Drawing.Size(127, 21);
            this.lblCourseDetails.TabIndex = 6;
            this.lblCourseDetails.Text = "ADD COURSE";
            // 
            // AdminDeleteCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlCourseDetails);
            this.Controls.Add(this.tlsDeleteCollege);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDeleteCourse";
            this.Text = "AdminDeleteCourse";
            this.Load += new System.EventHandler(this.AdminDeleteCourse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tlsDeleteCollege.ResumeLayout(false);
            this.tlsDeleteCollege.PerformLayout();
            this.pnlCourseDetails.ResumeLayout(false);
            this.pnlCourseDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCollegeName;
        private System.Windows.Forms.ComboBox cmbCollegeNameSearch;
        private System.Windows.Forms.ComboBox cmbCourseName;
        private System.Windows.Forms.Label lblCoursenameSearch;
        private System.Windows.Forms.ToolStrip tlsDeleteCollege;
        private System.Windows.Forms.ToolStripButton tlsBtnHomeDelete;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel pnlCourseDetails;
        private System.Windows.Forms.Label lblCourseDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.ComboBox cmbAddCourse;
        private System.Windows.Forms.Label label2;
    }
}