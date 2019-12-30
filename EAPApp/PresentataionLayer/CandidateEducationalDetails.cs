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
    public partial class CandidateEducationalDetails : Form
    {
        public CandidateEducationalDetails()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCandidateNext_Click(object sender, EventArgs e)
        {

            CandidateDetails candidateDetails = null;
            int output = 0;

            try
            {


                candidateDetails.CandidateSchoolName10 = cmb10thSchoolName.Text;
                candidateDetails.Candidatemark10 = Convert.ToInt32(txt10thMark.Text);
                candidateDetails.CandidateSchoolName12 = cmb12thSchoolName.Text;
                candidateDetails.Candidatemark12 = Convert.ToInt32(txt12thMark.Text);
                candidateDetails.CandidatePhysics = Convert.ToInt32(txtPhysics.Text);
                candidateDetails.CandidateChemistry = Convert.ToInt32(txtChemistry.Text);
                candidateDetails.CandidateMaths = Convert.ToInt32(txtMaths.Text);

                output = EapBL.StudentDetailsInsert(candidateDetails);
                if (output > 0)
                {
                    lblMessage.Text = "Successfully added";
                }
                else
                {
                    lblMessage.Text = "Failed";
                }
                
            }
            catch (Exception ex)
            {

            }
            this.Hide();
            CandidateEntrance candidateEntrance = new CandidateEntrance();
            candidateEntrance.Show();

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
    }
}
