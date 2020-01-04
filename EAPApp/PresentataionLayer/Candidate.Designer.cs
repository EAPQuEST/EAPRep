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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.educationalDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllotmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspHome = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.educationalDetailsToolStripMenuItem,
            this.viewAllotmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // educationalDetailsToolStripMenuItem
            // 
            this.educationalDetailsToolStripMenuItem.Name = "educationalDetailsToolStripMenuItem";
            this.educationalDetailsToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.educationalDetailsToolStripMenuItem.Text = "Allotment Details";
            this.educationalDetailsToolStripMenuItem.Click += new System.EventHandler(this.educationalDetailsToolStripMenuItem_Click);
            // 
            // viewAllotmentToolStripMenuItem
            // 
            this.viewAllotmentToolStripMenuItem.Name = "viewAllotmentToolStripMenuItem";
            this.viewAllotmentToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.viewAllotmentToolStripMenuItem.Text = "View Allotment";
            this.viewAllotmentToolStripMenuItem.Click += new System.EventHandler(this.viewAllotmentToolStripMenuItem_Click);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.BackColor = System.Drawing.SystemColors.Control;
            this.lblUserId.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(714, 7);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(0, 16);
            this.lblUserId.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(612, 7);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(96, 17);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "Candidate ID :";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspHome});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 27;
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
            this.tspHome.Text = "Sign Out";
            this.tspHome.Click += new System.EventHandler(this.tspHome_Click);
            // 
            // Candidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentataionLayer.Properties.Resources.envelope_blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Candidate";
            this.Text = "Candidate";
            this.Load += new System.EventHandler(this.Candidate_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem educationalDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllotmentToolStripMenuItem;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tspHome;
    }
}