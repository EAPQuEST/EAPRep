﻿using System;
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
    public partial class CandidateChangePassword : Form
    {
        public CandidateChangePassword()
        {
            InitializeComponent();
        }

        private void CandidateChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)                                //Change password for candidate login
        {


            CandidateDetails candidateDetails = null;
            int output = 0;

            string password;
         
            
            LoginInfo.password = txtCurrentPassword.Text;
            password = LoginInfo.password;
            
            DataTable dtLogin = null;
           
            try
            {
                candidateDetails = new CandidateDetails();
                dtLogin = EapBL.CandidateChangePassword(password);
               
                if (dtLogin.Rows.Count > 0)
                {
                    lblMessage.Text = "";
                   
                    candidateDetails.CandidateId = txtCandidateChangePasswordID.Text;
                    candidateDetails.CandidatePassword = txtNewPassword.Text;
                    output = EapBL.CandidateNewPassword(candidateDetails);
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
