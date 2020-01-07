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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAlottedList));
            this.dgvAdminAlloted = new System.Windows.Forms.DataGridView();
            this.tlsAddCollege = new System.Windows.Forms.ToolStrip();
            this.tlsBtnHomeAdd = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminAlloted)).BeginInit();
            this.tlsAddCollege.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAdminAlloted
            // 
            this.dgvAdminAlloted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminAlloted.Location = new System.Drawing.Point(151, 97);
            this.dgvAdminAlloted.Name = "dgvAdminAlloted";
            this.dgvAdminAlloted.Size = new System.Drawing.Size(798, 394);
            this.dgvAdminAlloted.TabIndex = 0;
            // 
            // tlsAddCollege
            // 
            this.tlsAddCollege.BackColor = System.Drawing.Color.CadetBlue;
            this.tlsAddCollege.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsAddCollege.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsBtnHomeAdd});
            this.tlsAddCollege.Location = new System.Drawing.Point(0, 0);
            this.tlsAddCollege.Name = "tlsAddCollege";
            this.tlsAddCollege.Size = new System.Drawing.Size(1264, 25);
            this.tlsAddCollege.TabIndex = 7;
            this.tlsAddCollege.Text = "toolStrip1";
            // 
            // tlsBtnHomeAdd
            // 
            this.tlsBtnHomeAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnHomeAdd.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnHomeAdd.Image")));
            this.tlsBtnHomeAdd.ImageTransparentColor = System.Drawing.Color.MediumAquamarine;
            this.tlsBtnHomeAdd.Name = "tlsBtnHomeAdd";
            this.tlsBtnHomeAdd.Size = new System.Drawing.Size(23, 22);
            this.tlsBtnHomeAdd.Text = "Home";
            this.tlsBtnHomeAdd.Click += new System.EventHandler(this.tlsBtnHomeAdd_Click);
            // 
            // AdminAlottedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tlsAddCollege);
            this.Controls.Add(this.dgvAdminAlloted);
            this.Name = "AdminAlottedList";
            this.Text = "AdminAlottedList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminAlloted)).EndInit();
            this.tlsAddCollege.ResumeLayout(false);
            this.tlsAddCollege.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdminAlloted;
        private System.Windows.Forms.ToolStrip tlsAddCollege;
        private System.Windows.Forms.ToolStripButton tlsBtnHomeAdd;
    }
}