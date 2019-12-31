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

                if (txtCandidateID.Text == string.Empty || txtCandidateName.Text == string.Empty || dtpDOB.Text == string.Empty ||
                       txtAddress.Text == string.Empty || txtEmail.Text == string.Empty || txtContactNumber.Text == string.Empty)
                {
                    // MessageBox.Show("Enter all the details");
                    foreach (Control control in this.Controls)
                    {
                        if (!Validate())
                        {
                            DialogResult = DialogResult.None;
                            return;
                        }
                    }
                }

                else
                {
                    candidateDetails = new CandidateDetails();

                    if (txtCandidateID.Text == string.Empty)
                    {
                        lblMessage.Text = "Enter the Candidate ID";
                        return;
                    }
                    else
                    {
                        candidateDetails.CandidateId = txtCandidateID.Text;
                    }
                    if (txtCandidateName.Text == string.Empty)
                    {
                        lblMessage.Text = "Enter the Candidate Name";
                        return;
                    }
                    else
                    {
                        candidateDetails.CandidateName = txtCandidateName.Text;
                    }
                    //dtpDOB.MinDate = new DateTime(1997, 1, 1);
                    //dtpDOB.MaxDate = new DateTime(2003, 12, 31);
                    dtpDOB.Format = DateTimePickerFormat.Custom;
                    dtpDOB.CustomFormat = "dd-MM-yyyy";
                    candidateDetails.CandidateDOB = dtpDOB.Value.ToShortDateString();

                    if (!rbtMale.Checked && !rbtFemale.Checked)
                    {
                        lblMessage.Text = "Please Select gender !!!";
                        return;
                    }

                    else if (rbtMale.Checked)
                    {
                        candidateDetails.CandidateGender = "Male";

                    }
                    else
                    {
                        candidateDetails.CandidateGender = "Female";

                    }


                    if (txtContactNumber.Text == string.Empty || txtContactNumber.Text.Length != 10 || (txtContactNumber.Text.StartsWith("0")))
                    {
                        lblMessage.Text = "Enter a valid mobile number !!!";
                        return;

                    }
                    else
                    {
                        candidateDetails.CandidateNumber = Convert.ToInt64(txtContactNumber.Text);
                    }


                    if (txtEmail.Text == string.Empty || (!txtEmail.Text.Contains('@')) || (!txtEmail.Text.Contains('.')))
                    {
                        lblMessage.Text = "Enter a valid email id !!!";
                        return;
                    }
                    else
                    {
                        candidateDetails.CandidateEmail = txtEmail.Text;
                    }

                    if (txtAddress.Text == string.Empty)
                    {

                        lblMessage.Text = "Enter your address !!!";
                    }
                    else
                    {
                        candidateDetails.CandidateAddress = txtAddress.Text;
                    }

                    output = EapBL.CandidateRegistrationInsert(candidateDetails);


                    if (output > 0)
                    {
                        MessageBox.Show("Registration Successfull!!!");
                        this.Hide();
                        AllotmentWindow allotmentWindow = new AllotmentWindow();
                        allotmentWindow.Show();
                    }
                    else
                    {
                        lblMessage.Text = "Failed";
                    }

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

        private void txtCandidateID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCandidateID.Text))
            {
                e.Cancel = true;
                txtCandidateID.Focus();
                epRegistration.SetError(txtCandidateID, "ID is required!!");
            }
            else
            {
                e.Cancel = false;
                epRegistration.SetError(txtCandidateID, "");
            }
        }

        private void txtCandidateName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCandidateName.Text))
            {
                e.Cancel = true;
                txtCandidateName.Focus();
                epRegistration.SetError(txtCandidateName, "Name is required!!");
            }
            else
            {
                e.Cancel = false;
                epRegistration.SetError(txtCandidateName, "");
            }
        }

        private void rbtFemale_Validating(object sender, CancelEventArgs e)
        {

        }

        private void dtpDOB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dtpDOB.Text))
            {
                e.Cancel = true;
                dtpDOB.Focus();
                epRegistration.SetError(dtpDOB, "Date of Birth is required!!");
            }
            else
            {
                e.Cancel = false;
                epRegistration.SetError(dtpDOB, "");
            }
        }

        private void txtContactNumber_Validated(object sender, EventArgs e)
        {

        }

        private void txtContactNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContactNumber.Text))
            {
                e.Cancel = true;
                txtContactNumber.Focus();
                epRegistration.SetError(txtContactNumber, "Contact Number is required!!");
            }
            else
            {
                e.Cancel = false;
                epRegistration.SetError(txtContactNumber, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                epRegistration.SetError(txtEmail, "Email is required!!");
            }
            else
            {
                e.Cancel = false;
                epRegistration.SetError(txtEmail, "");
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                e.Cancel = true;
                txtAddress.Focus();
                epRegistration.SetError(txtAddress, "Address is required!!");
            }
            else
            {
                e.Cancel = false;
                epRegistration.SetError(txtAddress, "");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitleCandidate_Click(object sender, EventArgs e)
        {

        }
    }
}
