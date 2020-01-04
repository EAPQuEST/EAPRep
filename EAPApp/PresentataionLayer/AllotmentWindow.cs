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
    public partial class AllotmentWindow : Form
    {
 


        public AllotmentWindow()
    {
        InitializeComponent();
    }


    private void btnAdmin_Click(object sender, EventArgs e)
    {
   
    }



    private void btnCandidate_Click(object sender, EventArgs e)
    {

    }
    private void btnCollge_Click(object sender, EventArgs e)
    {

    }


    private void lblHeading_Click(object sender, EventArgs e)
    {

    }

    private void toolStripLabel1_Click(object sender, EventArgs e)
    {

    }

        private void btnCollegeLogin1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminLogin1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrator administrator = new Administrator();
            administrator.Show();
           
        }

        private void btnNewUser1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CandidateRegistration candidate = new CandidateRegistration();
            candidate.Show();
           
        }

        private void btnCandidateLogin_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExistingLogin_Click(object sender, EventArgs e)
        {


            string username;
            string password;
            LoginInfo.userID = txtCandidateUsername.Text;
            username = LoginInfo.userID;
            LoginInfo.password = txtCandidatePassword.Text;
            password = LoginInfo.password;
            //DataSet dsLogin = null;
            DataTable dtLogin = null;
            //if (dsLogin.Rows[0][0].ToString() == "1")
            try
            {

                dtLogin = EapBL.CandidateLogin(username, password);
                //if (dtLogin.Rows[0][0].ToString() == "1")
                if (dtLogin.Rows.Count > 0)
                {
                    lblMessage.Text = "";
                    MessageBox.Show("Login successfull");

                    this.Hide();
                    Candidate candidate = new Candidate();
                    candidate.Show();

                }
                else
                {
                    lblMessage.Text = "Invalid username/password !!!";
                }

            }
            catch (FormatException ex)
            {
                //lblMessage.Text = ex.Message.ToString();
            }

        }
        //change password


      



        //Candidate Login
        private void txtCandidateUsername_MouseEnter(object sender, EventArgs e)
        {
        }
        private void txtCandidateUsername_MouseClick(object sender, MouseEventArgs e)
        {

            if (txtCandidateUsername.Text == "Username")
            {
                txtCandidateUsername.Text = "";
                txtCandidateUsername.ForeColor = Color.Black;
                txtCandidateUsername.Font = new Font(txtCandidateUsername.Font.FontFamily, txtCandidateUsername.Font.Size, FontStyle.Regular);

            }
        }
        private void txtCandidateUsername_MouseLeave(object sender, EventArgs e)
        {

            if (txtCandidateUsername.Text == "")
            {
                txtCandidateUsername.Text = "Username";
                txtCandidateUsername.ForeColor = Color.Gray;
                txtCandidateUsername.Font = new Font(txtCandidateUsername.Font.FontFamily, txtCandidateUsername.Font.Size, FontStyle.Italic);
            }
        }

        private void txtCandidatePassword_MouseEnter(object sender, EventArgs e)
        {
           
        }
        private void txtCandidatePassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCandidatePassword.Text == "Password")
            {
                txtCandidatePassword.Text = "";

                txtCandidatePassword.ForeColor = Color.Black;
                txtCandidatePassword.Font = new Font(txtCandidatePassword.Font.FontFamily, txtCandidatePassword.Font.Size, FontStyle.Regular);
                txtCandidatePassword.PasswordChar = '*';
                txtCandidatePassword.MaxLength = 14;
            }
        }

        private void txtCandidatePassword_MouseLeave(object sender, EventArgs e)
        {

            if (txtCandidatePassword.Text == "")
            {
                txtCandidatePassword.Font = new Font(txtCandidatePassword.Font.FontFamily, txtCandidatePassword.Font.Size, FontStyle.Italic);
                txtCandidatePassword.Text = "Password";
                txtCandidatePassword.ForeColor = Color.Gray;
               
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCollegeUsername_TextChanged(object sender, EventArgs e)
        {

        }
     //college Login
        private void txtCollegeUsername_MouseEnter(object sender, EventArgs e)
        {
        }
        private void txtCollegeUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCollegeUsername.Text == "Username")
            {
                txtCollegeUsername.Text = "";
                txtCollegeUsername.ForeColor = Color.Black;
                txtCollegeUsername.Font = new Font(txtCollegeUsername.Font.FontFamily, txtCollegeUsername.Font.Size, FontStyle.Regular);

            }
        }
        private void txtCollegeUsername_MouseLeave(object sender, EventArgs e)
        {

            if (txtCollegeUsername.Text == "")
            {
                txtCollegeUsername.Text = "Username";
                txtCollegeUsername.ForeColor = Color.Gray;
                txtCollegeUsername.Font = new Font(txtCollegeUsername.Font.FontFamily, txtCollegeUsername.Font.Size, FontStyle.Italic);
            }
        }

        private void txtCollegePassword_MouseEnter(object sender, EventArgs e)
        {

          
        }
        private void txtCollegePassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCollegePassword.Text == "Password")
            {
                txtCollegePassword.Text = "";

                txtCollegePassword.ForeColor = Color.Black;
                txtCollegePassword.Font = new Font(txtCollegePassword.Font.FontFamily, txtCollegePassword.Font.Size, FontStyle.Regular);
                txtCollegePassword.PasswordChar = '*';
                txtCollegePassword.MaxLength = 14;
            }
        }
        private void txtCollegePassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtCollegePassword.Text == "")
            {
                txtCollegePassword.Text = "Password";
                txtCollegePassword.ForeColor = Color.Gray;
                txtCollegePassword.Font = new Font(txtCollegePassword.Font.FontFamily, txtCollegePassword.Font.Size, FontStyle.Italic);
            } 
        }

        //Admin Login

        private void txtAdminUsername_MouseEnter(object sender, EventArgs e)
        {
           
        }
        private void txtAdminUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtAdminUsername.Text == "Username")
            {
                txtAdminUsername.Text = "";
                txtAdminUsername.ForeColor = Color.Black;
                txtAdminUsername.Font = new Font(txtAdminUsername.Font.FontFamily, txtAdminUsername.Font.Size, FontStyle.Regular);

            }
        }
        private void txtAdminUsername_MouseLeave(object sender, EventArgs e)
        {

            if (txtAdminUsername.Text == "")
            {
                txtAdminUsername.Text = "Username";
                txtAdminUsername.ForeColor = Color.Gray;
                txtAdminUsername.Font = new Font(txtAdminUsername.Font.FontFamily, txtAdminUsername.Font.Size, FontStyle.Italic);
            }
        }

        private void txtAdminPassword_MouseEnter(object sender, EventArgs e)
        {
        }
        private void txtAdminPassword_MouseClick(object sender, MouseEventArgs e)
        {

            if (txtAdminPassword.Text == "Password")
            {
                txtAdminPassword.Text = "";

                txtAdminPassword.ForeColor = Color.Black;
                txtAdminPassword.Font = new Font(txtAdminPassword.Font.FontFamily, txtAdminPassword.Font.Size, FontStyle.Regular);
                txtAdminPassword.PasswordChar = '*';
                txtAdminPassword.MaxLength = 10;
            }
        }
        private void txtAdminPassword_MouseLeave(object sender, EventArgs e)
        {

            if (txtAdminPassword.Text == "")
            {
                txtAdminPassword.Text = "Password";
               
                txtAdminPassword.ForeColor = Color.Gray;
                txtAdminPassword.Font = new Font(txtAdminPassword.Font.FontFamily, txtAdminPassword.Font.Size, FontStyle.Italic);
            }
          
        }

        private void btnCollegeLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            CollegeAuthority collegeAuthority = new CollegeAuthority();
            collegeAuthority.Show();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {


            string usernameAdmin;
            string passwordAdmin;
            LoginInfo.userID = txtAdminUsername.Text;
            usernameAdmin = LoginInfo.userID;
            LoginInfo.password = txtAdminPassword.Text;
            passwordAdmin = LoginInfo.password;
            //DataSet dsLogin = null;
            DataTable dtLogin = null;
            //if (dsLogin.Rows[0][0].ToString() == "1")
            try
            {

                dtLogin = EapBL.AdminLogin(usernameAdmin, passwordAdmin);
                //if (dtLogin.Rows[0][0].ToString() == "1")
                if (dtLogin.Rows.Count > 0)
                {
                    lblMessageAdmin.Text = "";
                    MessageBox.Show("Login successfull");

                    this.Hide();
                    Administrator administrator = new Administrator();
                    administrator.Show();

                }
                else
                {
                    lblMessageAdmin.Text = "Invalid username/password !!!";
                }

            }
            catch (FormatException ex)
            {
                //lblMessage.Text = ex.Message.ToString();
            }



           
        }

        private void txtCandidatePassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCandidateUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCandidateUsername.Text) && txtCandidateUsername.Text=="Username")
            {
                e.Cancel = true;
                txtCandidateUsername.Focus();
                epCandidateLogin.SetError(txtCandidateUsername, "Username is required!!");
            }
            else
            {
                e.Cancel = false;
                epCandidateLogin.SetError(txtCandidateUsername, "");
            }
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            CandidateRegistration candidate = new CandidateRegistration();
            candidate.Show();
        }

        private void tbcCandidate_Click(object sender, EventArgs e)
        {

        }

        private void llblChangePassword_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            CandidateChangePassword candidateChangePassword = new CandidateChangePassword();
            candidateChangePassword.Show();
        }

        private void llblChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
