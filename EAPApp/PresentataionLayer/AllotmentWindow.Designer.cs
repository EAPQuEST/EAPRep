namespace PresentataionLayer
{
    partial class AllotmentWindow
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnCollge = new System.Windows.Forms.Button();
            this.btnCandidate = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblHeading.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(216, 67);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(334, 36);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Engineering Allotment ";
            // 
            // btnCollge
            // 
            this.btnCollge.Location = new System.Drawing.Point(38, 270);
            this.btnCollge.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCollge.Name = "btnCollge";
            this.btnCollge.Size = new System.Drawing.Size(192, 66);
            this.btnCollge.TabIndex = 3;
            this.btnCollge.Text = "COLLEGE";
            this.btnCollge.UseVisualStyleBackColor = true;
            // 
            // btnCandidate
            // 
            this.btnCandidate.Location = new System.Drawing.Point(38, 143);
            this.btnCandidate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCandidate.Name = "btnCandidate";
            this.btnCandidate.Size = new System.Drawing.Size(192, 66);
            this.btnCandidate.TabIndex = 2;
            this.btnCandidate.Text = "CANDIDATE";
            this.btnCandidate.UseVisualStyleBackColor = true;
            this.btnCandidate.Click += new System.EventHandler(this.btnCandidate_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(38, 19);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(192, 66);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "ADMIN";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.btnCollge);
            this.panel1.Controls.Add(this.btnCandidate);
            this.panel1.Location = new System.Drawing.Point(14, 185);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 354);
            this.panel1.TabIndex = 4;
            // 
            // AllotmentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(808, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AllotmentWindow";
            this.Text = "AllotmentWindow";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnCollge;
        private System.Windows.Forms.Button btnCandidate;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel panel1;
    }
}