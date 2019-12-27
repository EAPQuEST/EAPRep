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
        Panel dynamicPanel = new Panel();
        Label lblheaderAdmin = new Label();
        TextBox txtUsername = new TextBox();
        TextBox txtPassword = new TextBox();
        public AllotmentWindow()
        {
            InitializeComponent();
        }
        
        private void btnAdmin_Click(object sender, EventArgs e)
        {

        
            dynamicPanel.Location = new System.Drawing.Point(300, 190);
            dynamicPanel.Name = "pnlAdmin";
            dynamicPanel.Size = new System.Drawing.Size(450, 350);
            dynamicPanel.BackColor = Color.AntiqueWhite;
           
            lblheaderAdmin.Location = new Point(150, 20);
            lblheaderAdmin.Size = new Size(350, 350);
            lblheaderAdmin.Text = "ADMIN LOGIN";

           
            txtUsername.Location = new Point(50, 80);
            txtUsername.Text = "Username";




           
            txtPassword.Location = new Point(50, 150);
            txtPassword.Text = "Password";


            dynamicPanel.Controls.Add(lblheaderAdmin);
            dynamicPanel.Controls.Add(txtUsername);

            dynamicPanel.Controls.Add(txtPassword);

            Controls.Add(dynamicPanel);
          
        }

        private void btnCandidate_Click(object sender, EventArgs e)
        {
            dynamicPanel.Controls.Remove(lblheaderAdmin);
            dynamicPanel.Controls.Remove(txtUsername);

            dynamicPanel.Controls.Remove(txtPassword);
            Controls.Remove(dynamicPanel);
            Panel dynamicPanel1 = new Panel();
            dynamicPanel1.Location = new System.Drawing.Point(300, 190);
            dynamicPanel1.Name = "pnlCandidate";
            dynamicPanel1.Size = new System.Drawing.Size(450, 350);
            dynamicPanel1.BackColor = Color.AntiqueWhite;
            Label lblheader = new Label();
            lblheader.Location = new Point(150, 20);
            lblheader.Size = new Size(350, 350);
            lblheader.Text = "CANDIDATE LOGIN";

            Button btnExistingUser = new Button();
            btnExistingUser.Size = new Size(105, 50);
            btnExistingUser.Location = new Point(40, 100);
            btnExistingUser.BackColor = Color.AliceBlue;
            btnExistingUser.Text = "EXISTING USER";

            Button btnNewUser = new Button();
            btnNewUser.Size = new Size(105, 50);
            btnNewUser.Location = new Point(40, 180);
            btnNewUser.BackColor = Color.AliceBlue;
            btnNewUser.Text = "NEW USER";

            dynamicPanel1.Controls.Add(lblheader);
            dynamicPanel1.Controls.Add(btnExistingUser);
           // Controls.Add(btnExistingUser);
            dynamicPanel1.Controls.Add(btnNewUser);
            //Controls.Add(btnNewUser);
            Controls.Add(dynamicPanel1);
        }
    }
}
