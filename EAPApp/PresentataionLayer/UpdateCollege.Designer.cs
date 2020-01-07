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
            this.tlsDeleteCollege = new System.Windows.Forms.ToolStrip();
            this.tlsBtnHomeDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblCollegeDetails = new System.Windows.Forms.Label();
            this.lblCollegeName = new System.Windows.Forms.Label();
            this.lblCollegeId = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtCollegeName = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cmbCollegeId = new System.Windows.Forms.ComboBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnUpdateCollege = new System.Windows.Forms.Button();
            this.pnlCollegeDetails = new System.Windows.Forms.Panel();
            this.tlsDeleteCollege.SuspendLayout();
            this.pnlCollegeDetails.SuspendLayout();
            this.SuspendLayout();
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
            this.tlsDeleteCollege.TabIndex = 16;
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
            this.toolStripLabel1.Size = new System.Drawing.Size(88, 22);
            this.toolStripLabel1.Text = "Update College";
            // 
            // lblCollegeDetails
            // 
            this.lblCollegeDetails.AutoSize = true;
            this.lblCollegeDetails.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollegeDetails.Location = new System.Drawing.Point(513, 66);
            this.lblCollegeDetails.Name = "lblCollegeDetails";
            this.lblCollegeDetails.Size = new System.Drawing.Size(185, 21);
            this.lblCollegeDetails.TabIndex = 0;
            this.lblCollegeDetails.Text = "COLLEGE DETAILS";
            this.lblCollegeDetails.Click += new System.EventHandler(this.lblCollegeDetails_Click);
            // 
            // lblCollegeName
            // 
            this.lblCollegeName.AutoSize = true;
            this.lblCollegeName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollegeName.Location = new System.Drawing.Point(441, 208);
            this.lblCollegeName.Name = "lblCollegeName";
            this.lblCollegeName.Size = new System.Drawing.Size(107, 15);
            this.lblCollegeName.TabIndex = 1;
            this.lblCollegeName.Text = "COLLEGE NAME ";
            // 
            // lblCollegeId
            // 
            this.lblCollegeId.AutoSize = true;
            this.lblCollegeId.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollegeId.Location = new System.Drawing.Point(441, 157);
            this.lblCollegeId.Name = "lblCollegeId";
            this.lblCollegeId.Size = new System.Drawing.Size(114, 15);
            this.lblCollegeId.TabIndex = 3;
            this.lblCollegeId.Text = "COLLEGE ID           ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(441, 319);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(114, 15);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "ADDRESS                ";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.Location = new System.Drawing.Point(441, 263);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(127, 15);
            this.lblContactNumber.TabIndex = 5;
            this.lblContactNumber.Text = "CONTACT NUMBER ";
            // 
            // txtCollegeName
            // 
            this.txtCollegeName.Location = new System.Drawing.Point(606, 208);
            this.txtCollegeName.Name = "txtCollegeName";
            this.txtCollegeName.Size = new System.Drawing.Size(199, 20);
            this.txtCollegeName.TabIndex = 7;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(606, 260);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(199, 20);
            this.txtContactNumber.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(606, 319);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(199, 96);
            this.txtAddress.TabIndex = 10;
            // 
            // cmbCollegeId
            // 
            this.cmbCollegeId.FormattingEnabled = true;
            this.cmbCollegeId.Location = new System.Drawing.Point(606, 157);
            this.cmbCollegeId.Name = "cmbCollegeId";
            this.cmbCollegeId.Size = new System.Drawing.Size(199, 21);
            this.cmbCollegeId.TabIndex = 11;
            this.cmbCollegeId.Text = "(Select ID)";
            this.cmbCollegeId.SelectedIndexChanged += new System.EventHandler(this.cmbCollegeId_SelectedIndexChanged_2);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(866, 125);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 12;
            // 
            // btnUpdateCollege
            // 
            this.btnUpdateCollege.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUpdateCollege.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateCollege.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCollege.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCollege.Location = new System.Drawing.Point(572, 466);
            this.btnUpdateCollege.Name = "btnUpdateCollege";
            this.btnUpdateCollege.Size = new System.Drawing.Size(126, 39);
            this.btnUpdateCollege.TabIndex = 14;
            this.btnUpdateCollege.Text = "UPDATE";
            this.btnUpdateCollege.UseVisualStyleBackColor = false;
            this.btnUpdateCollege.Click += new System.EventHandler(this.btnUpdateCollege_Click_2);
            // 
            // pnlCollegeDetails
            // 
            this.pnlCollegeDetails.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlCollegeDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCollegeDetails.Controls.Add(this.btnUpdateCollege);
            this.pnlCollegeDetails.Controls.Add(this.lblMessage);
            this.pnlCollegeDetails.Controls.Add(this.cmbCollegeId);
            this.pnlCollegeDetails.Controls.Add(this.txtAddress);
            this.pnlCollegeDetails.Controls.Add(this.txtContactNumber);
            this.pnlCollegeDetails.Controls.Add(this.txtCollegeName);
            this.pnlCollegeDetails.Controls.Add(this.lblContactNumber);
            this.pnlCollegeDetails.Controls.Add(this.lblAddress);
            this.pnlCollegeDetails.Controls.Add(this.lblCollegeId);
            this.pnlCollegeDetails.Controls.Add(this.lblCollegeName);
            this.pnlCollegeDetails.Controls.Add(this.lblCollegeDetails);
            this.pnlCollegeDetails.Location = new System.Drawing.Point(0, 28);
            this.pnlCollegeDetails.Name = "pnlCollegeDetails";
            this.pnlCollegeDetails.Size = new System.Drawing.Size(1264, 656);
            this.pnlCollegeDetails.TabIndex = 7;
            this.pnlCollegeDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCollegeDetails_Paint);
            // 
            // UpdateCollege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tlsDeleteCollege);
            this.Controls.Add(this.pnlCollegeDetails);
            this.Name = "UpdateCollege";
            this.Text = "UpdateCollege";
            this.Load += new System.EventHandler(this.UpdateCollege_Load);
            this.tlsDeleteCollege.ResumeLayout(false);
            this.tlsDeleteCollege.PerformLayout();
            this.pnlCollegeDetails.ResumeLayout(false);
            this.pnlCollegeDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tlsDeleteCollege;
        private System.Windows.Forms.ToolStripButton tlsBtnHomeDelete;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label lblCollegeDetails;
        private System.Windows.Forms.Label lblCollegeName;
        private System.Windows.Forms.Label lblCollegeId;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtCollegeName;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cmbCollegeId;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnUpdateCollege;
        private System.Windows.Forms.Panel pnlCollegeDetails;
    }
}