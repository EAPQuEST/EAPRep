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
            this.dgvCollegeList = new System.Windows.Forms.DataGridView();
            this.lblTitleCollegeList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollegeList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCollegeList
            // 
            this.dgvCollegeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollegeList.Location = new System.Drawing.Point(2, 64);
            this.dgvCollegeList.Name = "dgvCollegeList";
            this.dgvCollegeList.Size = new System.Drawing.Size(796, 384);
            this.dgvCollegeList.TabIndex = 0;
            // 
            // lblTitleCollegeList
            // 
            this.lblTitleCollegeList.AutoSize = true;
            this.lblTitleCollegeList.Location = new System.Drawing.Point(325, 18);
            this.lblTitleCollegeList.Name = "lblTitleCollegeList";
            this.lblTitleCollegeList.Size = new System.Drawing.Size(82, 13);
            this.lblTitleCollegeList.TabIndex = 1;
            this.lblTitleCollegeList.Text = "COLLEGE LIST";
            // 
            // AdminCollegeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitleCollegeList);
            this.Controls.Add(this.dgvCollegeList);
            this.Name = "AdminCollegeList";
            this.Text = "AdminCollegeList";
            this.Load += new System.EventHandler(this.AdminCollegeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollegeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCollegeList;
        private System.Windows.Forms.Label lblTitleCollegeList;
    }
}