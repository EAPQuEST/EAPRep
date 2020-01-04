namespace PresentataionLayer
{
    partial class AdminAlottedList
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
            this.dgvAdminAlloted = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminAlloted)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdminAlloted
            // 
            this.dgvAdminAlloted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminAlloted.Location = new System.Drawing.Point(0, 53);
            this.dgvAdminAlloted.Name = "dgvAdminAlloted";
            this.dgvAdminAlloted.Size = new System.Drawing.Size(798, 394);
            this.dgvAdminAlloted.TabIndex = 0;
            // 
            // AdminAlottedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAdminAlloted);
            this.Name = "AdminAlottedList";
            this.Text = "AdminAlottedList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminAlloted)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdminAlloted;
    }
}