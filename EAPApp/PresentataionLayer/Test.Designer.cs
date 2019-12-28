namespace PresentataionLayer
{
    partial class Test
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.engineeringAllotmentDatabaseDataSet1 = new PresentataionLayer.EngineeringAllotmentDatabaseDataSet1();
            this.candidatedetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidate_detailsTableAdapter = new PresentataionLayer.EngineeringAllotmentDatabaseDataSet1TableAdapters.candidate_detailsTableAdapter();
            this.candidateidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatedobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidateaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidate10thschoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidate10thpercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidate12thschoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidate12thpercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candiatephysicsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candiatechemistryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candiatemathsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineeringAllotmentDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatedetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.candidateidDataGridViewTextBoxColumn,
            this.candidatenameDataGridViewTextBoxColumn,
            this.candidatedobDataGridViewTextBoxColumn,
            this.candidateaddressDataGridViewTextBoxColumn,
            this.candidate10thschoolDataGridViewTextBoxColumn,
            this.candidate10thpercentageDataGridViewTextBoxColumn,
            this.candidate12thschoolDataGridViewTextBoxColumn,
            this.candidate12thpercentageDataGridViewTextBoxColumn,
            this.candiatephysicsDataGridViewTextBoxColumn,
            this.candiatechemistryDataGridViewTextBoxColumn,
            this.candiatemathsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.candidatedetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(139, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // engineeringAllotmentDatabaseDataSet1
            // 
            this.engineeringAllotmentDatabaseDataSet1.DataSetName = "EngineeringAllotmentDatabaseDataSet1";
            this.engineeringAllotmentDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidatedetailsBindingSource
            // 
            this.candidatedetailsBindingSource.DataMember = "candidate_details";
            this.candidatedetailsBindingSource.DataSource = this.engineeringAllotmentDatabaseDataSet1;
            // 
            // candidate_detailsTableAdapter
            // 
            this.candidate_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // candidateidDataGridViewTextBoxColumn
            // 
            this.candidateidDataGridViewTextBoxColumn.DataPropertyName = "candidate_id";
            this.candidateidDataGridViewTextBoxColumn.HeaderText = "candidate_id";
            this.candidateidDataGridViewTextBoxColumn.Name = "candidateidDataGridViewTextBoxColumn";
            // 
            // candidatenameDataGridViewTextBoxColumn
            // 
            this.candidatenameDataGridViewTextBoxColumn.DataPropertyName = "candidate_name";
            this.candidatenameDataGridViewTextBoxColumn.HeaderText = "candidate_name";
            this.candidatenameDataGridViewTextBoxColumn.Name = "candidatenameDataGridViewTextBoxColumn";
            // 
            // candidatedobDataGridViewTextBoxColumn
            // 
            this.candidatedobDataGridViewTextBoxColumn.DataPropertyName = "candidate_dob";
            this.candidatedobDataGridViewTextBoxColumn.HeaderText = "candidate_dob";
            this.candidatedobDataGridViewTextBoxColumn.Name = "candidatedobDataGridViewTextBoxColumn";
            // 
            // candidateaddressDataGridViewTextBoxColumn
            // 
            this.candidateaddressDataGridViewTextBoxColumn.DataPropertyName = "candidate_address";
            this.candidateaddressDataGridViewTextBoxColumn.HeaderText = "candidate_address";
            this.candidateaddressDataGridViewTextBoxColumn.Name = "candidateaddressDataGridViewTextBoxColumn";
            // 
            // candidate10thschoolDataGridViewTextBoxColumn
            // 
            this.candidate10thschoolDataGridViewTextBoxColumn.DataPropertyName = "candidate_10th_school";
            this.candidate10thschoolDataGridViewTextBoxColumn.HeaderText = "candidate_10th_school";
            this.candidate10thschoolDataGridViewTextBoxColumn.Name = "candidate10thschoolDataGridViewTextBoxColumn";
            // 
            // candidate10thpercentageDataGridViewTextBoxColumn
            // 
            this.candidate10thpercentageDataGridViewTextBoxColumn.DataPropertyName = "candidate_10th_percentage";
            this.candidate10thpercentageDataGridViewTextBoxColumn.HeaderText = "candidate_10th_percentage";
            this.candidate10thpercentageDataGridViewTextBoxColumn.Name = "candidate10thpercentageDataGridViewTextBoxColumn";
            // 
            // candidate12thschoolDataGridViewTextBoxColumn
            // 
            this.candidate12thschoolDataGridViewTextBoxColumn.DataPropertyName = "candidate_12th_school";
            this.candidate12thschoolDataGridViewTextBoxColumn.HeaderText = "candidate_12th_school";
            this.candidate12thschoolDataGridViewTextBoxColumn.Name = "candidate12thschoolDataGridViewTextBoxColumn";
            // 
            // candidate12thpercentageDataGridViewTextBoxColumn
            // 
            this.candidate12thpercentageDataGridViewTextBoxColumn.DataPropertyName = "candidate_12th_percentage";
            this.candidate12thpercentageDataGridViewTextBoxColumn.HeaderText = "candidate_12th_percentage";
            this.candidate12thpercentageDataGridViewTextBoxColumn.Name = "candidate12thpercentageDataGridViewTextBoxColumn";
            // 
            // candiatephysicsDataGridViewTextBoxColumn
            // 
            this.candiatephysicsDataGridViewTextBoxColumn.DataPropertyName = "candiate_physics";
            this.candiatephysicsDataGridViewTextBoxColumn.HeaderText = "candiate_physics";
            this.candiatephysicsDataGridViewTextBoxColumn.Name = "candiatephysicsDataGridViewTextBoxColumn";
            // 
            // candiatechemistryDataGridViewTextBoxColumn
            // 
            this.candiatechemistryDataGridViewTextBoxColumn.DataPropertyName = "candiate_chemistry";
            this.candiatechemistryDataGridViewTextBoxColumn.HeaderText = "candiate_chemistry";
            this.candiatechemistryDataGridViewTextBoxColumn.Name = "candiatechemistryDataGridViewTextBoxColumn";
            // 
            // candiatemathsDataGridViewTextBoxColumn
            // 
            this.candiatemathsDataGridViewTextBoxColumn.DataPropertyName = "candiate_maths";
            this.candiatemathsDataGridViewTextBoxColumn.HeaderText = "candiate_maths";
            this.candiatemathsDataGridViewTextBoxColumn.Name = "candiatemathsDataGridViewTextBoxColumn";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineeringAllotmentDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatedetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EngineeringAllotmentDatabaseDataSet1 engineeringAllotmentDatabaseDataSet1;
        private System.Windows.Forms.BindingSource candidatedetailsBindingSource;
        private EngineeringAllotmentDatabaseDataSet1TableAdapters.candidate_detailsTableAdapter candidate_detailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidatenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidatedobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidate10thschoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidate10thpercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidate12thschoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidate12thpercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candiatephysicsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candiatechemistryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candiatemathsDataGridViewTextBoxColumn;
    }
}