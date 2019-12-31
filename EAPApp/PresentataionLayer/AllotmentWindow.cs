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
    //ADMIN

        //Panel panelAdmin;
        //Label lblheaderAdmin;
        //TextBox txtUsernameAdmin;
        //TextBox txtPasswordAdmin;
        //Button btnAdminLogin;

        ////COLLEGE

        //Panel panelCollege;
        //Label lblheaderCollege;
        //TextBox txtUsernameCollege;
        //TextBox txtPasswordCollege;
        //Button btnCollegelogin;

        ////CANDIDATE

        //Panel panelCandidate;
        //Label lblheaderCandidate;
        //Button btnExistingUser;
        //Button btnNewUser;


        public AllotmentWindow()
    {
        InitializeComponent();
    }


    private void btnAdmin_Click(object sender, EventArgs e)
    {
    //    try
    //    {
    //        //REMOVE COLLEGE
    //        try
    //        {

    //            panelCollege.Controls.Remove(lblheaderCollege);
    //            panelCollege.Controls.Remove(txtUsernameCollege);
    //            panelCollege.Controls.Remove(btnCollegelogin);
    //            panelCollege.Controls.Remove(txtPasswordCollege);
    //            Controls.Remove(btnCollegelogin);
    //            Controls.Remove(panelCollege);

    //        }

    //        //REMOVE CANDIDATE

    //        catch (Exception)
    //        {
    //            panelCandidate.Controls.Remove(lblheaderCandidate);
    //            panelCandidate.Controls.Remove(btnExistingUser);
    //            panelCandidate.Controls.Remove(btnNewUser);
    //            Controls.Remove(btnExistingUser);
    //            Controls.Remove(btnNewUser);
    //            Controls.Remove(panelCandidate);
    //        }

    //    }
    //    catch (Exception) { }
    //    finally
    //    {

    //        panelAdmin = new Panel();
    //        txtUsernameAdmin = new TextBox();
    //        txtPasswordAdmin = new TextBox();
    //        btnAdminLogin = new Button();
    //        btnAdminLogin.Location = new Point(80, 240);
    //        btnAdminLogin.Text = "LOGIN";
    //        btnAdminLogin.BackColor = Color.PaleTurquoise;
    //        panelAdmin.Location = new System.Drawing.Point(300, 190);
    //        panelAdmin.Name = "pnlAdmin";
    //        panelAdmin.Size = new System.Drawing.Size(450, 350);
    //        panelAdmin.BackColor = Color.AntiqueWhite;
    //        lblheaderAdmin = new Label();
    //        lblheaderAdmin.Location = new Point(150, 20);
    //        lblheaderAdmin.Size = new Size(350, 350);
    //        lblheaderAdmin.Text = "ADMIN LOGIN";


    //        txtUsernameAdmin.Location = new Point(50, 80);
    //        txtUsernameAdmin.Text = "Username";

    //        txtPasswordAdmin.Location = new Point(50, 150);
    //        txtPasswordAdmin.Text = "Password";



    //        panelAdmin.Controls.Add(lblheaderAdmin);
    //        panelAdmin.Controls.Add(txtUsernameAdmin);
    //        panelAdmin.Controls.Add(txtPasswordAdmin);
    //        panelAdmin.Controls.Add(btnAdminLogin);

    //        Controls.Add(panelAdmin);
    //    }
    }



    private void btnCandidate_Click(object sender, EventArgs e)
    {
        //try
        //{
        //    //REMOVE COLLEGE

        //    try
        //    {
        //        panelCollege.Controls.Remove(lblheaderCollege);
        //        panelCollege.Controls.Remove(txtUsernameCollege);
        //        panelCollege.Controls.Remove(btnCollegelogin);
        //        panelCollege.Controls.Remove(txtPasswordCollege);
        //        Controls.Remove(btnCollegelogin);
        //        Controls.Remove(panelCollege);
        //    }
        //    //REMOVE ADMIN
        //    catch (Exception)
        //    {
        //        panelAdmin.Controls.Remove(lblheaderAdmin);
        //        panelAdmin.Controls.Remove(txtUsernameAdmin);
        //        panelAdmin.Controls.Remove(txtUsernameAdmin);
        //        panelAdmin.Controls.Remove(btnAdminLogin);
        //        Controls.Remove(panelAdmin);



        //    }
        //}
        //catch (Exception) { }
        //finally
        //{
        //    panelCandidate = new Panel();
        //    panelCandidate.Location = new System.Drawing.Point(300, 190);
        //    panelCandidate.Name = "pnlCandidate";
        //    panelCandidate.Size = new System.Drawing.Size(450, 350);
        //    panelCandidate.BackColor = Color.AntiqueWhite;
        //    lblheaderCandidate = new Label();
        //    lblheaderCandidate.Location = new Point(150, 20);
        //    lblheaderCandidate.Size = new Size(350, 350);
        //    lblheaderCandidate.Text = "CANDIDATE LOGIN";

        //    btnExistingUser = new Button();
        //    btnExistingUser.Size = new Size(105, 50);
        //    btnExistingUser.Location = new Point(40, 100);
        //    btnExistingUser.BackColor = Color.AliceBlue;
        //    btnExistingUser.Text = "EXISTING USER";

        //    btnNewUser = new Button();
        //    btnNewUser.Size = new Size(105, 50);
        //    btnNewUser.Location = new Point(40, 180);
        //    btnNewUser.BackColor = Color.AliceBlue;
        //    btnNewUser.Text = "NEW USER";

        //    panelCandidate.Controls.Add(lblheaderCandidate);
        //    panelCandidate.Controls.Add(btnExistingUser);
        //    // Controls.Add(btnExistingUser);
        //    panelCandidate.Controls.Add(btnNewUser);
        //    //Controls.Add(btnNewUser);
        //    Controls.Add(panelCandidate);
        //}

    }
    private void btnCollge_Click(object sender, EventArgs e)
    {
        //try
        //{
        //    // REMOVE ADMIN
        //    try
        //    {
        //        panelAdmin.Controls.Remove(lblheaderAdmin);
        //        panelAdmin.Controls.Remove(txtUsernameAdmin);
        //        panelAdmin.Controls.Remove(btnAdminLogin);
        //        panelAdmin.Controls.Remove(txtPasswordAdmin);
        //        Controls.Remove(panelAdmin);

        //    }

        //    //REMOVE CANDIDATE
        //    catch (Exception)
        //    {
        //        panelCandidate.Controls.Remove(lblheaderCandidate);
        //        panelCandidate.Controls.Remove(btnExistingUser);

        //        panelCandidate.Controls.Remove(btnNewUser);

        //        Controls.Remove(panelCandidate);
        //    }
        //}
        //catch (Exception) { }
        //finally
        //{
        //    panelCollege = new Panel();
        //    panelCollege.Location = new System.Drawing.Point(300, 190);
        //    panelCollege.Name = "pnlCollege";
        //    panelCollege.Size = new System.Drawing.Size(450, 350);
        //    panelCollege.BackColor = Color.AntiqueWhite;

        //    lblheaderCollege = new Label();
        //    lblheaderCollege.Location = new Point(150, 20);
        //    lblheaderCollege.Size = new Size(350, 350);
        //    lblheaderCollege.Text = "COLLEGE  LOGIN";

        //    txtUsernameCollege = new TextBox();
        //    txtUsernameCollege.Location = new Point(50, 80);
        //    txtUsernameCollege.Text = "Username";

        //    txtPasswordCollege = new TextBox();
        //    txtPasswordCollege.Location = new Point(50, 150);
        //    txtPasswordCollege.Text = "Password";

        //    btnCollegelogin = new Button();
        //    btnCollegelogin.Location = new Point(480, 450);
        //    btnCollegelogin.Text = "LOGIN";
        //    btnCollegelogin.BackColor = Color.PaleTurquoise;

        //    panelCollege.Controls.Add(lblheaderCollege);
        //    panelCollege.Controls.Add(txtUsernameCollege);
        //    panelCollege.Controls.Add(txtPasswordCollege);
        //    panelCollege.Controls.Add(btnCollegelogin);


        //    Controls.Add(btnCollegelogin);
        //    Controls.Add(panelCollege);

      //  }

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

            if (ValidateChildren(ValidationConstraints.Enabled))
            {

            }
        }
        //Candidate Login
        private void txtCandidateUsername_MouseEnter(object sender, EventArgs e)
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
               
              txtCandidatePassword.Text = "Password";
                txtCandidatePassword.ForeColor = Color.Gray;
                txtCandidatePassword.Font = new Font(txtCandidatePassword.Font.FontFamily, txtCandidatePassword.Font.Size, FontStyle.Italic);
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
            this.Hide();
            Administrator administrator = new Administrator();
            administrator.Show();
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
    }
}
