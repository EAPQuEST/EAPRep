﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.BL;
using DataTransactionObject.DTO;

namespace PresentataionLayer
{
    public partial class AddCollege : Form
    {
        public AddCollege()
        {
            InitializeComponent();
        }

        private void AddCollege_Load(object sender, EventArgs e)
        {

        }

        private void pnlCollegeDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCollege_Click(object sender, EventArgs e)
        {
            CollegeDetails collegeDetails = null;
            int output = 0;

            try
            {
                collegeDetails = new CollegeDetails();
                collegeDetails.CollegeID = txtCollegeID.Text;
                collegeDetails.CollegeName = txtCollegeName.Text;
                collegeDetails.TotalSeats =Convert.ToInt32( txtTotalSeat.Text);
                collegeDetails.CollegeAddress = txtAddress.Text;
                collegeDetails.CollegePhone = Convert.ToInt32(txtContactNumber.Text);

                output = EapBL.CollegeDetailsInsert(collegeDetails);
                if(output>0)
                {
                    lblMessage.Text = "Successfully added";
                }
                else
                {
                    lblMessage.Text = "Failed";
                }
            }
            catch(Exception ex)
            {

            }

         
        }
    }
}