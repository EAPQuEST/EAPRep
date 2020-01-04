namespace PresentataionLayer
{
    partial class AllotmentProcessWindow
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
            this.btnGenerateAllotment = new System.Windows.Forms.Button();
            this.dgvAllotedTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllotedTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateAllotment
            // 
            this.btnGenerateAllotment.Location = new System.Drawing.Point(258, 400);
            this.btnGenerateAllotment.Name = "btnGenerateAllotment";
            this.btnGenerateAllotment.Size = new System.Drawing.Size(247, 38);
            this.btnGenerateAllotment.TabIndex = 3;
            this.btnGenerateAllotment.Text = "View Allotment";
            this.btnGenerateAllotment.UseVisualStyleBackColor = true;
            this.btnGenerateAllotment.Click += new System.EventHandler(this.btnGenerateAllotment_Click);
            // 
            // dgvAllotedTable
            // 
            this.dgvAllotedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllotedTable.Location = new System.Drawing.Point(202, 109);
            this.dgvAllotedTable.Name = "dgvAllotedTable";
            this.dgvAllotedTable.Size = new System.Drawing.Size(371, 137);
            this.dgvAllotedTable.TabIndex = 4;
            // 
            // AllotmentProcessWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAllotedTable);
            this.Controls.Add(this.btnGenerateAllotment);
            this.IsMdiContainer = true;
            this.Name = "AllotmentProcessWindow";
            this.Text = "AllotmentProcessWindow";
            this.Load += new System.EventHandler(this.AllotmentProcessWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllotedTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateAllotment;
        private System.Windows.Forms.DataGridView dgvAllotedTable;
    }
}