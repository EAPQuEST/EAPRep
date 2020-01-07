namespace PresentataionLayer
{
    partial class AllotmentProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllotmentProcess));
            this.btnGenerateAllotment = new System.Windows.Forms.Button();
            this.tlsDeleteCollege = new System.Windows.Forms.ToolStrip();
            this.tlsBtnHomeDelete = new System.Windows.Forms.ToolStripButton();
            this.dgvAllotedTable = new System.Windows.Forms.DataGridView();
            this.tlsDeleteCollege.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllotedTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateAllotment
            // 
            this.btnGenerateAllotment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGenerateAllotment.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateAllotment.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnGenerateAllotment.Location = new System.Drawing.Point(0, 612);
            this.btnGenerateAllotment.Name = "btnGenerateAllotment";
            this.btnGenerateAllotment.Size = new System.Drawing.Size(1264, 69);
            this.btnGenerateAllotment.TabIndex = 3;
            this.btnGenerateAllotment.Text = "Generate Allotment";
            this.btnGenerateAllotment.UseVisualStyleBackColor = true;
            this.btnGenerateAllotment.Click += new System.EventHandler(this.btnGenerateAllotment_Click);
            // 
            // tlsDeleteCollege
            // 
            this.tlsDeleteCollege.BackColor = System.Drawing.Color.CadetBlue;
            this.tlsDeleteCollege.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsBtnHomeDelete});
            this.tlsDeleteCollege.Location = new System.Drawing.Point(0, 0);
            this.tlsDeleteCollege.Name = "tlsDeleteCollege";
            this.tlsDeleteCollege.Size = new System.Drawing.Size(1264, 25);
            this.tlsDeleteCollege.TabIndex = 10;
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
            this.tlsBtnHomeDelete.Text = "Home";
            this.tlsBtnHomeDelete.Click += new System.EventHandler(this.tlsBtnHomeDelete_Click);
            // 
            // dgvAllotedTable
            // 
            this.dgvAllotedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllotedTable.Location = new System.Drawing.Point(390, 152);
            this.dgvAllotedTable.Name = "dgvAllotedTable";
            this.dgvAllotedTable.Size = new System.Drawing.Size(445, 216);
            this.dgvAllotedTable.TabIndex = 11;
            // 
            // AllotmentProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dgvAllotedTable);
            this.Controls.Add(this.tlsDeleteCollege);
            this.Controls.Add(this.btnGenerateAllotment);
            this.Name = "AllotmentProcess";
            this.Text = "AllotmentProcess";
            this.Load += new System.EventHandler(this.AllotmentProcess_Load);
            this.tlsDeleteCollege.ResumeLayout(false);
            this.tlsDeleteCollege.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllotedTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateAllotment;
        private System.Windows.Forms.ToolStrip tlsDeleteCollege;
        private System.Windows.Forms.ToolStripButton tlsBtnHomeDelete;
        private System.Windows.Forms.DataGridView dgvAllotedTable;
    }
}