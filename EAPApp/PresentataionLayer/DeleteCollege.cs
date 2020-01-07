using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.BL;
using DataTransactionObject.DTO;

namespace PresentataionLayer
{
    public partial class DeleteCollege : Form
    {
        public DeleteCollege()
        {
            InitializeComponent();
            LoadCollegeDetails();
        }
        private void LoadCollegeDetails()                                               //To display all the college details
        {
            DataSet dsCollegeDetails = null;
            try
            {
                dsCollegeDetails = EapBLAdmin.GetCollegeDetails();

                if (dsCollegeDetails != null)
                {
                    dgvDeleteView.DataSource = dsCollegeDetails.Tables[0];


                }
                else
                {
                    lblMessage.Text = "Not Available";
                }

            }
            catch (FormatException ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }

        private void txtDelete_TextChanged(object sender, EventArgs e)                          //Delete College
        {
            DataSet dsData = null;
            try
            {
                dsData = EapBLAdmin.GetDataLike(txtDelete.Text);
                if (dsData != null)
                {

                    dgvDeleteView.DataSource = dsData.Tables[0];

                }
                else
                {
                    lblMessage.Text = "No data Available";
                }

            }
            catch (FormatException ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }

        private void dgvDeleteView_SelectionChanged(object sender, EventArgs e)
        {
            //string collegeName;

            //if(dgvDeleteView.SelectedCells.Count > 0)
            //{
            //    int SelectedrowIndex = dgvDeleteView.SelectedCells[0].RowIndex;
            //    DataGridViewRow selectedRow = dgvDeleteView.Rows[SelectedrowIndex];

            //    collegeName = Convert.ToString(selectedRow.Cells["college_name"].Value);

            //    txtDelete.Text = collegeName;
                    
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int output = 0;
            try
            {
                if (MessageBox.Show("Do you want to delete ?", "S I S", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    output = EapBLAdmin.CollegeDelete(txtDelete.Text);
                    

                    if (output > 0)
                    {
                        lblMessage.Text = "College details deleted successfully";
                        LoadCollegeDetails();
                    }
                    else
                    {
                        lblMessage.Text = "Please try again later";
                    }
                }

            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }

        private void tlsBtnHomeDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllotmentWindow allotmentWindow = new AllotmentWindow();
            allotmentWindow.Show();
        }
    }
}
