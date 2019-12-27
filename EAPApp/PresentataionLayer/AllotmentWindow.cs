using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentataionLayer
{
    public partial class AllotmentWindow : Form
    {
        //ADMIN

        Panel panelAdmin;
        Label lblheaderAdmin;
        TextBox txtUsernameAdmin ;
        TextBox txtPasswordAdmin ;
       

        //COLLEGE

        Panel panelCollege;
        Label lblheaderCollege;
        TextBox txtUsernameCollege;
        TextBox txtPasswordCollege;
        Button btnCollegelogin;

        //CANDIDATE

        Panel panelCandidate;
        Label lblheaderCandidate;
        Button btnExistingUser;
        Button btnNewUser;


        public AllotmentWindow()
        {
            InitializeComponent();
        }


        private void btnAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                //REMOVE COLLEGE
                try
                {

                    panelCollege.Controls.Remove(lblheaderCollege);
                    panelCollege.Controls.Remove(txtUsernameCollege);
                    panelCollege.Controls.Remove(btnCollegelogin);
                    panelCollege.Controls.Remove(txtPasswordCollege);
                    Controls.Remove(btnCollegelogin);
                    Controls.Remove(panelCollege);

                }

                //REMOVE CANDIDATE

                catch (Exception)
                {
                    panelCandidate.Controls.Remove(lblheaderCandidate);
                    panelCandidate.Controls.Remove(btnExistingUser);
                    panelCandidate.Controls.Remove(btnNewUser);
                    Controls.Remove(btnExistingUser);
                    Controls.Remove(btnNewUser);
                    Controls.Remove(panelCandidate);
                }

            }
            catch (Exception) { }
           finally
            {

                panelAdmin = new Panel();
                txtUsernameAdmin = new TextBox();
                txtPasswordAdmin = new TextBox();
                panelAdmin.Location = new System.Drawing.Point(300, 190);
                panelAdmin.Name = "pnlAdmin";
                panelAdmin.Size = new System.Drawing.Size(450, 350);
                panelAdmin.BackColor = Color.AntiqueWhite;
                lblheaderAdmin = new Label();
                lblheaderAdmin.Location = new Point(150, 20);
                lblheaderAdmin.Size = new Size(350, 350);
                lblheaderAdmin.Text = "ADMIN LOGIN";


                txtUsernameAdmin.Location = new Point(50, 80);
                txtUsernameAdmin.Text = "Username";

                txtPasswordAdmin.Location = new Point(50, 150);
                txtPasswordAdmin.Text = "Password";



                panelAdmin.Controls.Add(lblheaderAdmin);
                panelAdmin.Controls.Add(txtUsernameAdmin);
                panelAdmin.Controls.Add(txtPasswordAdmin);


                Controls.Add(panelAdmin);
            }
        }

     

        private void btnCandidate_Click(object sender, EventArgs e)
        {
            try
            {
                //REMOVE ADMIN
                try
                {
                    panelCollege.Controls.Remove(lblheaderCollege);
                    panelCollege.Controls.Remove(txtUsernameCollege);
                    panelCollege.Controls.Remove(btnCollegelogin);
                    panelCollege.Controls.Remove(txtPasswordCollege);
                    Controls.Remove(btnCollegelogin);
                    Controls.Remove(panelCollege);
                }
                //REMOVE COLLEGE
                catch (Exception)
                {
                    panelAdmin.Controls.Remove(lblheaderAdmin);
                    panelAdmin.Controls.Remove(txtUsernameAdmin);

                    panelAdmin.Controls.Remove(txtPasswordAdmin);
                    Controls.Remove(panelAdmin);


                   
                }
            }
            catch (Exception) { }
            finally
            {
                panelCandidate = new Panel();
                panelCandidate.Location = new System.Drawing.Point(300, 190);
                panelCandidate.Name = "pnlCandidate";
                panelCandidate.Size = new System.Drawing.Size(450, 350);
                panelCandidate.BackColor = Color.AntiqueWhite;
                lblheaderCandidate = new Label();
                lblheaderCandidate.Location = new Point(150, 20);
                lblheaderCandidate.Size = new Size(350, 350);
                lblheaderCandidate.Text = "CANDIDATE LOGIN";

                btnExistingUser = new Button();
                btnExistingUser.Size = new Size(105, 50);
                btnExistingUser.Location = new Point(40, 100);
                btnExistingUser.BackColor = Color.AliceBlue;
                btnExistingUser.Text = "EXISTING USER";

                btnNewUser = new Button();
                btnNewUser.Size = new Size(105, 50);
                btnNewUser.Location = new Point(40, 180);
                btnNewUser.BackColor = Color.AliceBlue;
                btnNewUser.Text = "NEW USER";

                panelCandidate.Controls.Add(lblheaderCandidate);
                panelCandidate.Controls.Add(btnExistingUser);
                // Controls.Add(btnExistingUser);
                panelCandidate.Controls.Add(btnNewUser);
                //Controls.Add(btnNewUser);
                Controls.Add(panelCandidate);
            }

        }
        private void btnCollge_Click(object sender, EventArgs e)
        {
            try
            {
                // REMOVE ADMIN
                try
                {
                    panelAdmin.Controls.Remove(lblheaderAdmin);
                    panelAdmin.Controls.Remove(txtUsernameAdmin);

                    panelAdmin.Controls.Remove(txtPasswordAdmin);
                    Controls.Remove(panelAdmin);

                }

                //REMOVE CANDIDATE
                catch (Exception)
                {
                    panelCandidate.Controls.Remove(lblheaderCandidate);
                    panelCandidate.Controls.Remove(btnExistingUser);

                    panelCandidate.Controls.Remove(btnNewUser);
                    Controls.Remove(btnExistingUser);
                    Controls.Remove(btnNewUser);
                    Controls.Remove(panelCandidate);
                }
            }
            catch (Exception) { }
            finally
            {
                panelCollege = new Panel();
                panelCollege.Location = new System.Drawing.Point(300, 190);
                panelCollege.Name = "pnlCollege";
                panelCollege.Size = new System.Drawing.Size(450, 350);
                panelCollege.BackColor = Color.AntiqueWhite;

                lblheaderCollege = new Label();
                lblheaderCollege.Location = new Point(150, 20);
                lblheaderCollege.Size = new Size(350, 350);
                lblheaderCollege.Text = "COLLEGE  LOGIN";

                txtUsernameCollege = new TextBox();
                txtUsernameCollege.Location = new Point(50, 80);
                txtUsernameCollege.Text = "Username";

                txtPasswordCollege = new TextBox();
                txtPasswordCollege.Location = new Point(50, 150);
                txtPasswordCollege.Text = "Password";

                btnCollegelogin = new Button();
                btnCollegelogin.Location = new Point(480, 450);
                btnCollegelogin.Text = "LOGIN";
                btnCollegelogin.BackColor = Color.PaleTurquoise;

                panelCollege.Controls.Add(lblheaderCollege);
                panelCollege.Controls.Add(txtUsernameCollege);
                panelCollege.Controls.Add(txtPasswordCollege);
                panelCollege.Controls.Add(btnCollegelogin);


                Controls.Add(btnCollegelogin);
                Controls.Add(panelCollege);
             
            }

        }
    }
}
