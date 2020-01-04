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
            lblUserId.Text = LoginInfo.userID;
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
                //string userId = LoginInfo.userID;

                candidateDetails = new CandidateDetails();
                
                candidateDetails.Reservation = comboBoxReservation.Text.ToString();
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

                    MessageBox.Show("10th School Name :" + candidateDetails.CandidateSchoolName10 +
                "\n10th Mark\t:" + candidateDetails.Candidatemark10 +
                "\n12th School Name\t:" + candidateDetails.CandidateSchoolName12 +
                "\n12th Mark\t:" + candidateDetails.Candidatemark12 +
                "\nPhysics Mark 1\t:" + candidateDetails.CandidatePhysics +
                "\nChemistry Mark\t:" + candidateDetails.CandidateChemistry +
                "\nMaths Mark\t:" + candidateDetails.CandidateMaths);


                    lblMessage.Text = "Successfully added";
                    this.Hide();
                    CandidateEntrance candidateEntrance = new CandidateEntrance();
                    candidateEntrance.Show();
                }
                else
                {
                    lblMessage.Text = "Failed";
                }
                
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
            

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

        private void CandidateEducationalDetails_Load(object sender, EventArgs e)
        {

            LoadDetailstoForm();

        }
        //private int comboReservationText;

        //public int ComboReservationText
        //{
        //    get { return comboBoxReservation.Text.ToString(); }
        //    set { comboReservationText = value; }
        //}

        private void comboBoxReservation_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void LoadDetailstoForm()
        {
            //CandidateEducationalDetails loadForm = new CandidateEducationalDetails();
            CandidateDetails candidateDetails = null;
            try
            {
                candidateDetails = new CandidateDetails();

                candidateDetails=EapBL.LoadCandidateDetails();

                comboBoxReservation.Text = candidateDetails.Reservation;
                cmb10thSchoolName.Text = candidateDetails.CandidateSchoolName10;
                txt10thMark.Text = candidateDetails.Candidatemark10.ToString();
                cmb12thSchoolName.Text = candidateDetails.CandidateSchoolName12;
                txt12thMark.Text = candidateDetails.Candidatemark12.ToString();
                txtChemistry.Text = candidateDetails.CandidateChemistry.ToString();
                txtPhysics.Text = candidateDetails.CandidateChemistry.ToString();
                txtMaths.Text = candidateDetails.CandidateMaths.ToString();

                txtMaths.ReadOnly = true;
                txtPhysics.ReadOnly = true;
                txtChemistry.ReadOnly = true;
                txt10thMark.ReadOnly = true;
                txt12thMark.ReadOnly = true;

                cmb10thSchoolName.Enabled = false;
                cmb12thSchoolName.Enabled = false;
                comboBoxReservation.Enabled = false;


            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }


    }
}
