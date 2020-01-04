namespace PresentataionLayer
{
    partial class CollegeAuthority
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollegeAuthority));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCandidateInfo = new System.Windows.Forms.Label();
            this.txtViewEntrance = new System.Windows.Forms.TextBox();
            this.txtViewID = new System.Windows.Forms.TextBox();
            this.lblViewName = new System.Windows.Forms.Label();
            this.lblViewID = new System.Windows.Forms.Label();
            this.btnConfirmCandidate = new System.Windows.Forms.Button();
            this.tspCollegeAuthority = new System.Windows.Forms.ToolStrip();
            this.tspHome = new System.Windows.Forms.ToolStripButton();
            this.tspViewAllotedList = new System.Windows.Forms.ToolStripLabel();
            this.dgvCollegeAllotedList = new System.Windows.Forms.DataGridView();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.lblSearchID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tspCollegeAuthority.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollegeAllotedList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblCandidateInfo);
            this.panel1.Controls.Add(this.txtViewEntrance);
            this.panel1.Controls.Add(this.txtViewID);
            this.panel1.Controls.Add(this.lblViewName);
            this.panel1.Controls.Add(this.lblViewID);
            this.panel1.Location = new System.Drawing.Point(531, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 314);
            this.panel1.TabIndex = 0;
            // 
            // lblCandidateInfo
            // 
            this.lblCandidateInfo.AutoSize = true;
            this.lblCandidateInfo.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateInfo.Location = new System.Drawing.Point(34, 30);
            this.lblCandidateInfo.Name = "lblCandidateInfo";
            this.lblCandidateInfo.Size = new System.Drawing.Size(221, 17);
            this.lblCandidateInfo.TabIndex = 6;
            this.lblCandidateInfo.Text = "CANDIDATE INFORMATION";
            // 
            // txtViewEntrance
            // 
            this.txtViewEntrance.Location = new System.Drawing.Point(102, 157);
            this.txtViewEntrance.Name = "txtViewEntrance";
            this.txtViewEntrance.Size = new System.Drawing.Size(161, 20);
            this.txtViewEntrance.TabIndex = 5;
            // 
            // txtViewID
            // 
            this.txtViewID.Location = new System.Drawing.Point(102, 100);
            this.txtViewID.Name = "txtViewID";
            this.txtViewID.Size = new System.Drawing.Size(161, 20);
            this.txtViewID.TabIndex = 3;
            // 
            // lblViewName
            // 
            this.lblViewName.AutoSize = true;
            this.lblViewName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewName.Location = new System.Drawing.Point(6, 156);
            this.lblViewName.Name = "lblViewName";
            this.lblViewName.Size = new System.Drawing.Size(91, 18);
            this.lblViewName.TabIndex = 1;
            this.lblViewName.Text = "Entrance ID";
            // 
            // lblViewID
            // 
            this.lblViewID.AutoSize = true;
            this.lblViewID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewID.Location = new System.Drawing.Point(3, 102);
            this.lblViewID.Name = "lblViewID";
            this.lblViewID.Size = new System.Drawing.Size(96, 18);
            this.lblViewID.TabIndex = 0;
            this.lblViewID.Text = "Candidate ID";
            // 
            // btnConfirmCandidate
            // 
            this.btnConfirmCandidate.BackColor = System.Drawing.Color.White;
            this.btnConfirmCandidate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmCandidate.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmCandidate.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnConfirmCandidate.Location = new System.Drawing.Point(542, 402);
            this.btnConfirmCandidate.Name = "btnConfirmCandidate";
            this.btnConfirmCandidate.Size = new System.Drawing.Size(246, 38);
            this.btnConfirmCandidate.TabIndex = 1;
            this.btnConfirmCandidate.Text = "CONFIRM";
            this.btnConfirmCandidate.UseVisualStyleBackColor = false;
            this.btnConfirmCandidate.Click += new System.EventHandler(this.btnConfirmCandidate_Click);
            // 
            // tspCollegeAuthority
            // 
            this.tspCollegeAuthority.BackColor = System.Drawing.Color.SteelBlue;
            this.tspCollegeAuthority.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspHome,
            this.tspViewAllotedList});
            this.tspCollegeAuthority.Location = new System.Drawing.Point(0, 0);
            this.tspCollegeAuthority.Name = "tspCollegeAuthority";
            this.tspCollegeAuthority.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tspCollegeAuthority.Size = new System.Drawing.Size(800, 25);
            this.tspCollegeAuthority.TabIndex = 29;
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
            this.tspHome.Click += new System.EventHandler(this.tspHome_Click);
            // 
            // tspViewAllotedList
            // 
            this.tspViewAllotedList.Name = "tspViewAllotedList";
            this.tspViewAllotedList.Size = new System.Drawing.Size(70, 22);
            this.tspViewAllotedList.Text = "Allotted List";
            // 
            // dgvCollegeAllotedList
            // 
            this.dgvCollegeAllotedList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCollegeAllotedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollegeAllotedList.Location = new System.Drawing.Point(0, 82);
            this.dgvCollegeAllotedList.Name = "dgvCollegeAllotedList";
            this.dgvCollegeAllotedList.Size = new System.Drawing.Size(525, 369);
            this.dgvCollegeAllotedList.TabIndex = 30;
            this.dgvCollegeAllotedList.SelectionChanged += new System.EventHandler(this.dgvCollegeAllotedList_SelectionChanged);
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(244, 43);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(177, 20);
            this.txtSearchID.TabIndex = 7;
            this.txtSearchID.TextChanged += new System.EventHandler(this.txtSearchID_TextChanged);
            // 
            // lblSearchID
            // 
            this.lblSearchID.AutoSize = true;
            this.lblSearchID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchID.Location = new System.Drawing.Point(68, 42);
            this.lblSearchID.Name = "lblSearchID";
            this.lblSearchID.Size = new System.Drawing.Size(143, 18);
            this.lblSearchID.TabIndex = 7;
            this.lblSearchID.Text = "Search Candidate ID";
            // 
            // CollegeAuthority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSearchID);
            this.Controls.Add(this.txtSearchID);
            this.Controls.Add(this.btnConfirmCandidate);
            this.Controls.Add(this.dgvCollegeAllotedList);
            this.Controls.Add(this.tspCollegeAuthority);
            this.Controls.Add(this.panel1);
            this.Name = "CollegeAuthority";
            this.Text = "CollegeAuthority";
            this.Load += new System.EventHandler(this.CollegeAuthority_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tspCollegeAuthority.ResumeLayout(false);
            this.tspCollegeAuthority.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollegeAllotedList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfirmCandidate;
        private System.Windows.Forms.ToolStrip tspCollegeAuthority;
        private System.Windows.Forms.ToolStripButton tspHome;
        private System.Windows.Forms.ToolStripLabel tspViewAllotedList;
        private System.Windows.Forms.DataGridView dgvCollegeAllotedList;
        private System.Windows.Forms.Label lblCandidateInfo;
        private System.Windows.Forms.TextBox txtViewEntrance;
        private System.Windows.Forms.TextBox txtViewID;
        private System.Windows.Forms.Label lblViewName;
        private System.Windows.Forms.Label lblViewID;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Label lblSearchID;
    }
}