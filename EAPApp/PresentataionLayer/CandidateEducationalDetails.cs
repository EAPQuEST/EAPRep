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
        int countPhysicsMark = 0;
        bool flagPhysicsMark = false;
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


                //if (cmb10thSchoolName.Text == string.Empty || txt10thMark.Text == string.Empty || cmb12thSchoolName.Text == string.Empty ||
                //       txt12thMark.Text == string.Empty || txtPhysics.Text == string.Empty || txtChemistry.Text == string.Empty || txtMaths.Text == string.Empty)
                //{
                //     //MessageBox.Show("Enter all the details");
                //    foreach (Control control in this.Controls)
                //    {
                //        if (!Validate())
                //        {
                //            DialogResult = DialogResult.None;
                //            return;
                //        }
                //    }
                //}

                //else
                //{
                //validation

                candidateDetails = new CandidateDetails();
                candidateDetails.Candidatemark10 = Convert.ToInt32(txt10thMark.Text);
                candidateDetails.Candidatemark12 = Convert.ToInt32(txt12thMark.Text);
                candidateDetails.CandidatePhysics = Convert.ToInt32(txtPhysics.Text);
                candidateDetails.CandidateChemistry = Convert.ToInt32(txtChemistry.Text);
                candidateDetails.CandidateMaths = Convert.ToInt32(txtMaths.Text);


                if (cmb10thSchoolName.SelectedIndex == -1)
                {
                    lblMessage.Text = "Please select a school !!!";
                    return;
                }
                else
                {
                    candidateDetails.CandidateSchoolName10 = cmb10thSchoolName.Text;
                }

                if (cmb12thSchoolName.SelectedIndex == -1)
                {
                    lblMessage.Text = "Please select a school !!!";
                    return;
                }
                else
                {
                    candidateDetails.CandidateSchoolName12 = cmb12thSchoolName.Text;
                }

                if (candidateDetails.Candidatemark10 > 100 || candidateDetails.Candidatemark10 < 0 ||
                    candidateDetails.Candidatemark12 > 100 || candidateDetails.Candidatemark12 < 0 ||
                    candidateDetails.CandidatePhysics > 100 || candidateDetails.CandidatePhysics < 0 ||
                    candidateDetails.CandidateChemistry > 100 || candidateDetails.CandidateChemistry < 0 ||
                    candidateDetails.CandidateMaths > 100 || candidateDetails.CandidateMaths < 0)
                {
                    lblMessage.Text = "Enter a valid mark (0-100) !!!";
                    return;
                }
                else
                {

                    //if (candidateDetails.Candidatemark10 > 100 || candidateDetails.Candidatemark10 < 0)
                    //{
                    //    lblMessage.Text = "Enter a valid mark (0-100) !!!";
                    //    return;
                    //}
                    //else
                    //{

                    //    candidateDetails.Candidatemark10 = Convert.ToInt32(txt10thMark.Text);
                    //}



                    //if (candidateDetails.Candidatemark12 > 100 || candidateDetails.Candidatemark12 < 0)
                    //{
                    //    lblMessage.Text = "Enter a valid mark (0-100) !!!";
                    //    return;
                    //}
                    //else
                    //{

                    //    candidateDetails.Candidatemark12 = Convert.ToInt32(txt12thMark.Text);
                    //}
                    //if (candidateDetails.CandidatePhysics > 100 || candidateDetails.CandidatePhysics < 0)
                    //{
                    //    lblMessage.Text = "Enter a valid mark (0-100) !!!";
                    //    return;
                    //}
                    //else
                    //{
                    //    candidateDetails.CandidatePhysics = Convert.ToInt32(txtPhysics.Text);
                    //}
                    //if (candidateDetails.CandidateChemistry > 100 || candidateDetails.CandidateChemistry < 0)
                    //{
                    //    lblMessage.Text = "Enter a valid mark (0-100) !!!";
                    //    return;
                    //}
                    //else
                    //{
                    //    candidateDetails.CandidateChemistry = Convert.ToInt32(txtChemistry.Text);
                    //}
                    //if (candidateDetails.CandidateMaths > 100 || candidateDetails.CandidateMaths < 0)
                    //{
                    //    lblMessage.Text = "Enter a valid mark (0-100) !!!";
                    //    return;
                    //}
                    //else
                    //{
                    //    candidateDetails.CandidateMaths = Convert.ToInt32(txtMaths.Text);
                    //}


                    output = EapBL.StudentDetailsInsert(candidateDetails);
                    if (output > 0)
                    {

                        MessageBox.Show("10th School Name :" + candidateDetails.CandidateSchoolName10 +
                    "\n10th Mark\t:" + candidateDetails.Candidatemark10 +
                    "\n12th School Name\t:" + candidateDetails.CandidateSchoolName12 +
                    "\n12th Mark\t:" + candidateDetails.Candidatemark12 +
                    "\nPhysics Mark \t:" + candidateDetails.CandidatePhysics +
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

        //validation

        private void cmb10thSchoolName_Validating(object sender, CancelEventArgs e)
        {
            if (cmb10thSchoolName.Text == string.Empty)
            {
                epCandidateEducation.SetError(cmb10thSchoolName, "School Name is required !");
            }
            else
            {
                epCandidateEducation.SetError(cmb10thSchoolName, string.Empty);
            }
        }

        private void txt10thMark_Validating(object sender, CancelEventArgs e)
        {

            if (txt10thMark.Text == string.Empty)
            {
                epCandidateEducation.SetError(txt10thMark, "Mark is required !");
            }
            else
            {
                epCandidateEducation.SetError(txt10thMark, string.Empty);
            }
        }

        private void cmb12thSchoolName_Validating(object sender, CancelEventArgs e)
        {

            if (cmb12thSchoolName.Text == string.Empty)
            {
                epCandidateEducation.SetError(cmb12thSchoolName, "School Name is required !");
            }
            else
            {
                epCandidateEducation.SetError(cmb12thSchoolName, string.Empty);
            }
        }

        private void txt12thMark_Validating(object sender, CancelEventArgs e)
        {
            if (txt12thMark.Text == string.Empty)
            {
                epCandidateEducation.SetError(txt12thMark, "Mark is required !");
            }
            else
            {
                epCandidateEducation.SetError(txt12thMark, string.Empty);
            }

        }

        private void txtPhysics_Validating(object sender, CancelEventArgs e)
        {

            if (txtPhysics.Text == string.Empty)
            {
                epCandidateEducation.SetError(txtPhysics, "Mark is required !");
            }
            else
            {
                epCandidateEducation.SetError(txtPhysics, string.Empty);
            }
        }

        private void txtChemistry_Validating(object sender, CancelEventArgs e)
        {

            if (txtChemistry.Text == string.Empty)
            {
                epCandidateEducation.SetError(txtChemistry, "Mark is required !");
            }
            else
            {
                epCandidateEducation.SetError(txtChemistry, string.Empty);
            }
        }

        private void txtMaths_Validating(object sender, CancelEventArgs e)
        {

            if (txtMaths.Text == string.Empty)
            {
                epCandidateEducation.SetError(txtMaths, "State is required !");
            }
            else
            {
                epCandidateEducation.SetError(txtMaths, string.Empty);
            }
        }





        private void txtPhysics_KeyDown(object sender, KeyEventArgs e)
        {
        //    flagPhysicsMark = false;

        //    if (!txtPhysics.Text.Contains(".") && countPhysicsMark > 0)                     //handling double Decimal point , eg 23.45.6 this is handled
        //    {
        //        countPhysicsMark++;
        //    }


        //    if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
        //        (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) || ((e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod) && countPhysicsMark < 1)
        //        || e.KeyCode == Keys.Back)
        //    {
        //        flagPhysicsMark = true;

        //        if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
        //        {
        //            countPhysicsMark++;
        //        }

        //    }
        }

        private void txtPhysics_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (!flagPhysicsMark)
            //{
            //    e.Handled = true;           //handling the event
            //}
        }
    }
}
