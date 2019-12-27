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
        Panel dynamicPanel;
        Label lblheader;
        TextBox txtUsername;
        TextBox txtPassword;
        Button btnadminlogin;

        public AllotmentWindow()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Panel dynamicPanel = new Panel();
            dynamicPanel.Location = new System.Drawing.Point(300, 190);
            dynamicPanel.Name = "Panel1";
            dynamicPanel.Size = new System.Drawing.Size(450, 350);
            dynamicPanel.BackColor = Color.AntiqueWhite;

            Label lblheader = new Label();
            lblheader.Location = new Point(150, 20);
            lblheader.Size = new Size(350, 350);
            lblheader.Text = "ADMIN LOGIN";

            TextBox txtUsername = new TextBox();
            txtUsername.Location = new Point(50, 80);
            txtUsername.Text = "Username";

            TextBox txtPassword = new TextBox();
            txtPassword.Location = new Point(50, 150);
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.Text = "Password";

            Button btnadminlogin = new Button();
            //btnadminlogin.Location = new Point(120, 250);
            btnadminlogin.Size = new Size(100, 45);
            btnadminlogin.Location = new Point(480, 450);

            btnadminlogin.Text = "LOGIN";
            btnadminlogin.BackColor = Color.PaleTurquoise;


            dynamicPanel.Controls.Add(lblheader);
            dynamicPanel.Controls.Add(txtUsername);
            dynamicPanel.Controls.Add(txtPassword);
            dynamicPanel.Controls.Add(btnadminlogin);

            Controls.Add(btnadminlogin);
            Controls.Add(dynamicPanel);
           
            
        }
    }
}
