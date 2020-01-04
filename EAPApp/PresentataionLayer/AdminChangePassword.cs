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
    public partial class AdminChangePassword : Form
    {
        public AdminChangePassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            
            int output = 0;

            string usernameAdmin;
            string passwordAdmin;
            string newPasswordAdmin;


            LoginInfo.password = txtCurrentPassword.Text;
            passwordAdmin = LoginInfo.password;
            //DataSet dsLogin = null;
            DataTable dtLogin = null;
            //if (dsLogin.Rows[0][0].ToString() == "1")
            

               
          
            //if (dsLogin.Rows[0][0].ToString() == "1")
            try
            {
                dtLogin = EapBLAdmin.AdminChangePassword(passwordAdmin);
               
                //if (dtLogin.Rows[0][0].ToString() == "1")
                if (dtLogin.Rows.Count > 0)
                {
                    lblMessage.Text = "";

                    LoginInfo.userID = txtAdminChangePasswordID.Text;
                    usernameAdmin = LoginInfo.userID;
                    LoginInfo.Newpassword = txtNewPassword.Text;
                    newPasswordAdmin = LoginInfo.Newpassword;
                    output = EapBLAdmin.AdminNewPassword(usernameAdmin, newPasswordAdmin);
                    if (output > 0)
                    {


                        MessageBox.Show("Password Changed successfully");
                    }
                    else
                    {
                        lblMessage.Text = "Failed";
                    }
                    this.Hide();
                    AllotmentWindow allotmentWindow = new AllotmentWindow();
                    allotmentWindow.Show();

                }
                else
                {
                    lblMessage.Text = "Invalid Username/Password !!!";
                }

            }
            catch (FormatException ex)
            {
                //lblMessage.Text = ex.Message.ToString();
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
        }
    }
}
