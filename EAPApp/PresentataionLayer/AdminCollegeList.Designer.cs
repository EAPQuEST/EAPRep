namespace PresentataionLayer
{
    partial class AdminCollegeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCollegeList));
            this.dgvCollegeList = new System.Windows.Forms.DataGridView();
            this.lblTitleCollegeList = new System.Windows.Forms.Label();
            this.tlsDeleteCollege = new System.Windows.Forms.ToolStrip();
            this.tlsBtnHomeDelete = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollegeList)).BeginInit();
            this.tlsDeleteCollege.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCollegeList
            // 
            this.dgvCollegeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollegeList.Location = new System.Drawing.Point(217, 132);
            this.dgvCollegeList.Name = "dgvCollegeList";
            this.dgvCollegeList.Size = new System.Drawing.Size(796, 384);
            this.dgvCollegeList.TabIndex = 0;
            // 
            // lblTitleCollegeList
            // 
            this.lblTitleCollegeList.AutoSize = true;
            this.lblTitleCollegeList.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCollegeList.ForeColor = System.Drawing.Color.Indigo;
            this.lblTitleCollegeList.Location = new System.Drawing.Point(505, 75);
            this.lblTitleCollegeList.Name = "lblTitleCollegeList";
            this.lblTitleCollegeList.Size = new System.Drawing.Size(171, 24);
            this.lblTitleCollegeList.TabIndex = 1;
            this.lblTitleCollegeList.Text = "COLLEGE LIST";
            // 
            // tlsDeleteCollege
            // 
            this.tlsDeleteCollege.BackColor = System.Drawing.Color.CadetBlue;
            this.tlsDeleteCollege.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsBtnHomeDelete});
            this.tlsDeleteCollege.Location = new System.Drawing.Point(0, 0);
            this.tlsDeleteCollege.Name = "tlsDeleteCollege";
            this.tlsDeleteCollege.Size = new System.Drawing.Size(1264, 25);
            this.tlsDeleteCollege.TabIndex = 8;
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
            // AdminCollegeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tlsDeleteCollege);
            this.Controls.Add(this.lblTitleCollegeList);
            this.Controls.Add(this.dgvCollegeList);
            this.Name = "AdminCollegeList";
            this.Text = "AdminCollegeList";
            this.Load += new System.EventHandler(this.AdminCollegeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollegeList)).EndInit();
            this.tlsDeleteCollege.ResumeLayout(false);
            this.tlsDeleteCollege.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCollegeList;
        private System.Windows.Forms.Label lblTitleCollegeList;
        private System.Windows.Forms.ToolStrip tlsDeleteCollege;
        private System.Windows.Forms.ToolStripButton tlsBtnHomeDelete;
    }
}