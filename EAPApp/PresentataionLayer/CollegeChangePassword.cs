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
    public partial class CollegeChangePassword : Form
    {
        public CollegeChangePassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)                        //To change password for college login
        {
            CollegeDetails collegeDetails = null;
            int output = 0;

            string password;


            LoginInfo.password = txtCurrentPassword.Text;
            password = LoginInfo.password;
            //DataSet dsLogin = null;
            DataTable dtLogin = null;
            //if (dsLogin.Rows[0][0].ToString() == "1")
            try
            {
                collegeDetails = new CollegeDetails();
                dtLogin = EapBLCollege.CollegeChangePassword(password);
                //if (dtLogin.Rows[0][0].ToString() == "1")
                if (dtLogin.Rows.Count > 0)
                {
                    lblMessage.Text = "";

                    collegeDetails.Username = txtCollegeChangePasswordID.Text;
                    collegeDetails.Password = txtNewPassword.Text;
                    output = EapBLCollege.CollegeNewPassword(collegeDetails);
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
    }
}
