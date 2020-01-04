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
            this.btnConfirmCandidate = new System.Windows.Forms.Button();
            this.rtbConfirmCandidate = new System.Windows.Forms.RichTextBox();
            this.tspCollegeAuthority = new System.Windows.Forms.ToolStrip();
            this.tspHome = new System.Windows.Forms.ToolStripButton();
            this.tspBtnBack = new System.Windows.Forms.ToolStripButton();
            this.tspViewAllotedList = new System.Windows.Forms.ToolStripLabel();
            this.dgvCollegeAllotedList = new System.Windows.Forms.DataGridView();
            this.cmbSearchId = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tspCollegeAuthority.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollegeAllotedList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnConfirmCandidate);
            this.panel1.Controls.Add(this.rtbConfirmCandidate);
            this.panel1.Location = new System.Drawing.Point(531, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 369);
            this.panel1.TabIndex = 0;
            // 
            // btnConfirmCandidate
            // 
            this.btnConfirmCandidate.BackColor = System.Drawing.Color.White;
            this.btnConfirmCandidate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmCandidate.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmCandidate.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnConfirmCandidate.Location = new System.Drawing.Point(11, 318);
            this.btnConfirmCandidate.Name = "btnConfirmCandidate";
            this.btnConfirmCandidate.Size = new System.Drawing.Size(246, 38);
            this.btnConfirmCandidate.TabIndex = 1;
            this.btnConfirmCandidate.Text = "CONFIRM";
            this.btnConfirmCandidate.UseVisualStyleBackColor = false;
            this.btnConfirmCandidate.Click += new System.EventHandler(this.btnConfirmCandidate_Click);
            // 
            // rtbConfirmCandidate
            // 
            this.rtbConfirmCandidate.Location = new System.Drawing.Point(3, 3);
            this.rtbConfirmCandidate.Name = "rtbConfirmCandidate";
            this.rtbConfirmCandidate.ReadOnly = true;
            this.rtbConfirmCandidate.Size = new System.Drawing.Size(264, 309);
            this.rtbConfirmCandidate.TabIndex = 0;
            this.rtbConfirmCandidate.Text = "";
            // 
            // tspCollegeAuthority
            // 
            this.tspCollegeAuthority.BackColor = System.Drawing.Color.SteelBlue;
            this.tspCollegeAuthority.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspHome,
            this.tspBtnBack,
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
            this.tspHome.Text = "Home";
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
            // tspViewAllotedList
            // 
            this.tspViewAllotedList.Name = "tspViewAllotedList";
            this.tspViewAllotedList.Size = new System.Drawing.Size(70, 22);
            this.tspViewAllotedList.Text = "Allotted List";
            // 
            // dgvCollegeAllotedList
            // 
            this.dgvCollegeAllotedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollegeAllotedList.Location = new System.Drawing.Point(0, 82);
            this.dgvCollegeAllotedList.Name = "dgvCollegeAllotedList";
            this.dgvCollegeAllotedList.Size = new System.Drawing.Size(525, 369);
            this.dgvCollegeAllotedList.TabIndex = 30;
            // 
            // cmbSearchId
            // 
            this.cmbSearchId.BackColor = System.Drawing.Color.White;
            this.cmbSearchId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSearchId.FormattingEnabled = true;
            this.cmbSearchId.Location = new System.Drawing.Point(69, 39);
            this.cmbSearchId.Name = "cmbSearchId";
            this.cmbSearchId.Size = new System.Drawing.Size(257, 21);
            this.cmbSearchId.TabIndex = 31;
            this.cmbSearchId.Text = "(Search Candidate Id)";
            this.cmbSearchId.SelectedIndexChanged += new System.EventHandler(this.cmbSearchId_SelectedIndexChanged);
            // 
            // CollegeAuthority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbSearchId);
            this.Controls.Add(this.dgvCollegeAllotedList);
            this.Controls.Add(this.tspCollegeAuthority);
            this.Controls.Add(this.panel1);
            this.Name = "CollegeAuthority";
            this.Text = "CollegeAuthority";
            this.Load += new System.EventHandler(this.CollegeAuthority_Load);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripButton tspBtnBack;
        private System.Windows.Forms.ToolStripLabel tspViewAllotedList;
        private System.Windows.Forms.DataGridView dgvCollegeAllotedList;
        private System.Windows.Forms.ComboBox cmbSearchId;
        private System.Windows.Forms.RichTextBox rtbConfirmCandidate;
    }
}