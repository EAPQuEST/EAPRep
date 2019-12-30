using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransactionObject.DTO;
using BusinessLayer.BL;

namespace PresentataionLayer
{
    public partial class CandidateRegistration : Form
    {
        public CandidateRegistration()
        {
            InitializeComponent();
        }

        private void lblCandidateId_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CandidateDetails candidateDetails = null;
            int output = 0;

            try
            {
                candidateDetails = new CandidateDetails();
                candidateDetails.CandidateId = txtCandidateID.Text;
                candidateDetails.CandidateName = txtCandidateName.Text;
                candidateDetails.CandidateDOB = dtpDOB.Value.ToShortDateString();
                candidateDetails.CandidateAddress = txtAddress.Text;
                candidateDetails.CandidateEmail = txtEmail.Text;
                candidateDetails.CandidateNumber = Convert.ToInt32(txtContactNumber.Text);

                if (rbtMale.Checked)
                {
                    candidateDetails.CandidateGender = "Male";

                }
                else
                {
                    candidateDetails.CandidateGender = "Female";

                }

                output = EapBL.CandidateRegistrationInsert(candidateDetails);
                if (output > 0)
                {
                    lblMessage.Text = "Successfully added";
                    this.Hide();
                    CandidateLogin candidateLogin = new CandidateLogin();
                    candidateLogin.Show();
                }
                else
                {
                    lblMessage.Text = "Failed";
                }
                
            }
            catch (Exception ex)
            {

            }
            
        }

        private void Candidate_Load(object sender, EventArgs e)
        {

        }

        private void tspBtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllotmentWindow allotmentWindow = new AllotmentWindow();
            allotmentWindow.Show();
        }

        private void tspHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllotmentWindow allotmentWindow = new AllotmentWindow();
            allotmentWindow.Show();
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
