namespace PresentataionLayer
{
    partial class CandidateViewAllotment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateViewAllotment));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspHome = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspHome});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 28;
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
            // CandidateViewAllotment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CandidateViewAllotment";
            this.Text = "CandidateViewAllotment";
            this.Load += new System.EventHandler(this.CandidateViewAllotment_Load_1);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tspHome;
    }
}