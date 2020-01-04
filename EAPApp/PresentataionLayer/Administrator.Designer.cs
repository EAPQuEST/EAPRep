namespace PresentataionLayer
{
    partial class Administrator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewCollegeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllottedListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCollegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCollegeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCollegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGenerateAllotment = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCollegeListToolStripMenuItem,
            this.viewAllottedListToolStripMenuItem,
            this.addCollegeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewCollegeListToolStripMenuItem
            // 
            this.viewCollegeListToolStripMenuItem.Name = "viewCollegeListToolStripMenuItem";
            this.viewCollegeListToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.viewCollegeListToolStripMenuItem.Text = "College List";
            this.viewCollegeListToolStripMenuItem.Click += new System.EventHandler(this.viewCollegeListToolStripMenuItem_Click);
            // 
            // viewAllottedListToolStripMenuItem
            // 
            this.viewAllottedListToolStripMenuItem.Name = "viewAllottedListToolStripMenuItem";
            this.viewAllottedListToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.viewAllottedListToolStripMenuItem.Text = "Allotted List";
            this.viewAllottedListToolStripMenuItem.Click += new System.EventHandler(this.viewAllottedListToolStripMenuItem_Click);
            // 
            // addCollegeToolStripMenuItem
            // 
            this.addCollegeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCollegeToolStripMenuItem1,
            this.deleteCollegeToolStripMenuItem,
            this.addCourseToolStripMenuItem,
            this.deleteCourseToolStripMenuItem});
            this.addCollegeToolStripMenuItem.Name = "addCollegeToolStripMenuItem";
            this.addCollegeToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.addCollegeToolStripMenuItem.Text = "College Operations";
            this.addCollegeToolStripMenuItem.Click += new System.EventHandler(this.addCollegeToolStripMenuItem_Click);
            // 
            // addCollegeToolStripMenuItem1
            // 
            this.addCollegeToolStripMenuItem1.Name = "addCollegeToolStripMenuItem1";
            this.addCollegeToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.addCollegeToolStripMenuItem1.Text = "Add College";
            this.addCollegeToolStripMenuItem1.Click += new System.EventHandler(this.addCollegeToolStripMenuItem1_Click);
            // 
            // deleteCollegeToolStripMenuItem
            // 
            this.deleteCollegeToolStripMenuItem.Name = "deleteCollegeToolStripMenuItem";
            this.deleteCollegeToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.deleteCollegeToolStripMenuItem.Text = "Delete College";
            this.deleteCollegeToolStripMenuItem.Click += new System.EventHandler(this.deleteCollegeToolStripMenuItem_Click);
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.addCourseToolStripMenuItem.Text = "Update College Details";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // deleteCourseToolStripMenuItem
            // 
            this.deleteCourseToolStripMenuItem.Name = "deleteCourseToolStripMenuItem";
            this.deleteCourseToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.deleteCourseToolStripMenuItem.Text = "Delete Course";
            this.deleteCourseToolStripMenuItem.Click += new System.EventHandler(this.deleteCourseToolStripMenuItem_Click);
            // 
            // btnGenerateAllotment
            // 
            this.btnGenerateAllotment.Location = new System.Drawing.Point(413, 266);
            this.btnGenerateAllotment.Name = "btnGenerateAllotment";
            this.btnGenerateAllotment.Size = new System.Drawing.Size(191, 83);
            this.btnGenerateAllotment.TabIndex = 2;
            this.btnGenerateAllotment.Text = "Generate Allotment";
            this.btnGenerateAllotment.UseVisualStyleBackColor = true;
            this.btnGenerateAllotment.Click += new System.EventHandler(this.btnGenerateAllotment_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentataionLayer.Properties.Resources.envelope_blue1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 600);
            this.Controls.Add(this.btnGenerateAllotment);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewCollegeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllottedListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCollegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCollegeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteCollegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCourseToolStripMenuItem;
        private System.Windows.Forms.Button btnGenerateAllotment;
    }
}