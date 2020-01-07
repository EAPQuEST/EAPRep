namespace PresentataionLayer
{
    partial class DeleteCollege
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCollege));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.dgvDeleteView = new System.Windows.Forms.DataGridView();
            this.lblDeleteId = new System.Windows.Forms.Label();
            this.tlsDeleteCollege = new System.Windows.Forms.ToolStrip();
            this.tlsBtnHomeDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteView)).BeginInit();
            this.tlsDeleteCollege.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtDelete);
            this.panel1.Controls.Add(this.dgvDeleteView);
            this.panel1.Controls.Add(this.lblDeleteId);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 656);
            this.panel1.TabIndex = 3;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(272, 23);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(805, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 50);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(537, 41);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(221, 20);
            this.txtDelete.TabIndex = 4;
            this.txtDelete.TextChanged += new System.EventHandler(this.txtDelete_TextChanged);
            // 
            // dgvDeleteView
            // 
            this.dgvDeleteView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDeleteView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeleteView.Location = new System.Drawing.Point(202, 125);
            this.dgvDeleteView.Name = "dgvDeleteView";
            this.dgvDeleteView.Size = new System.Drawing.Size(858, 348);
            this.dgvDeleteView.TabIndex = 3;
            this.dgvDeleteView.SelectionChanged += new System.EventHandler(this.dgvDeleteView_SelectionChanged);
            // 
            // lblDeleteId
            // 
            this.lblDeleteId.AutoSize = true;
            this.lblDeleteId.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteId.Location = new System.Drawing.Point(281, 39);
            this.lblDeleteId.Name = "lblDeleteId";
            this.lblDeleteId.Size = new System.Drawing.Size(227, 18);
            this.lblDeleteId.TabIndex = 2;
            this.lblDeleteId.Text = "ENTER COLLEGE NAME     : ";
            // 
            // tlsDeleteCollege
            // 
            this.tlsDeleteCollege.BackColor = System.Drawing.Color.CadetBlue;
            this.tlsDeleteCollege.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsBtnHomeDelete,
            this.toolStripLabel1});
            this.tlsDeleteCollege.Location = new System.Drawing.Point(0, 0);
            this.tlsDeleteCollege.Name = "tlsDeleteCollege";
            this.tlsDeleteCollege.Size = new System.Drawing.Size(1264, 25);
            this.tlsDeleteCollege.TabIndex = 11;
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(83, 22);
            this.toolStripLabel1.Text = "Delete College";
            // 
            // DeleteCollege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tlsDeleteCollege);
            this.Controls.Add(this.panel1);
            this.Name = "DeleteCollege";
            this.Text = "DeleteCollege";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteView)).EndInit();
            this.tlsDeleteCollege.ResumeLayout(false);
            this.tlsDeleteCollege.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.DataGridView dgvDeleteView;
        private System.Windows.Forms.Label lblDeleteId;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ToolStrip tlsDeleteCollege;
        private System.Windows.Forms.ToolStripButton tlsBtnHomeDelete;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}