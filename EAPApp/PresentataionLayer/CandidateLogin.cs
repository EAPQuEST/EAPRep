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
    public partial class CandidateLogin : Form
    {
        public CandidateLogin()
        {
            InitializeComponent();
        }

        private void txtCandidateUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCandidateUsername_MouseEnter(object sender, EventArgs e)
        {
            if(txtCandidateUsername.Text=="Username")
            {
                txtCandidateUsername.Text = "";
                txtCandidateUsername.ForeColor = Color.Black;
                txtCandidateUsername.Font = new Font(txtCandidateUsername.Font.FontFamily, txtCandidateUsername.Font.Size,FontStyle.Regular);

            }

        }

        private void txtCandidateUsername_MouseLeave(object sender, EventArgs e)
        {
            if(txtCandidateUsername.Text=="")
            {
                txtCandidateUsername.Text = "Username";
                txtCandidateUsername.ForeColor = Color.Gray;
                txtCandidateUsername.Font = new Font(txtCandidateUsername.Font.FontFamily, txtCandidateUsername.Font.Size, FontStyle.Italic);
            }
        }

        private void txtCandidatePassword_MouseEnter(object sender, EventArgs e)
        {
            if (txtCandidatePassword.Text == "Password")
            {
                txtCandidatePassword.Text = "";

                txtCandidatePassword.ForeColor = Color.Black;
                txtCandidatePassword.Font = new Font(txtCandidatePassword.Font.FontFamily, txtCandidatePassword.Font.Size, FontStyle.Regular);
            }
        }

        private void txtCandidatePassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtCandidatePassword.Text == "")
            {
                txtCandidatePassword.Text = "Password";
                txtCandidatePassword.ForeColor = Color.Gray;
                txtCandidatePassword.Font = new Font(txtCandidatePassword.Font.FontFamily, txtCandidatePassword.Font.Size, FontStyle.Italic);
            }
        }

        private void btnExistingLogin_Click(object sender, EventArgs e)
        {
            CandidateDetails candidateDetails = null;
            int output = 0;

            try
            {
                candidateDetails = new CandidateDetails();


                this.Hide();
                CandidateEducationalDetails candidateEducationalDetails = new CandidateEducationalDetails();
                candidateEducationalDetails.Show();


            }
            catch (Exception ex)
            {

            }


        }
    }
}
