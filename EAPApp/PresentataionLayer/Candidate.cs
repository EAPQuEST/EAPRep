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
    public partial class Candidate : Form
    {
        public Candidate()
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
                //candidateDetails.CandidateSchoolName10 = cmb10thSchoolName.Text;
                //candidateDetails.Candidatemark10 = Convert.ToInt32(txt10thMark.Text);
                //candidateDetails.CandidateSchoolName12 = cmb12thSchoolName.Text;
                //candidateDetails.Candidatemark12 = Convert.ToInt32(txt12thMark.Text);
                //candidateDetails.CandidatePhysics = Convert.ToInt32(txtPhysics.Text);
                //candidateDetails.CandidateChemistry = Convert.ToInt32(txtChemistry.Text);
                //candidateDetails.CandidateMaths = Convert.ToInt32(txtMaths.Text);

                output = EapBL.StudentDetailsInsert(candidateDetails);
                if (output > 0)
                {
                    lblMessage.Text = "Successfully added";
                }
                else
                {
                    lblMessage.Text = "Failed";
                }
                this.Hide();
                CandidateLogin candidateLogin = new CandidateLogin();
                candidateLogin.Show();
            }
            catch (Exception ex)
            {

            }
        }

        private void Candidate_Load(object sender, EventArgs e)
        {

        }
    }
}
