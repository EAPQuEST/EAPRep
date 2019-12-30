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
    public partial class CandidateEntrance : Form
    {
        public CandidateEntrance()
        {
            InitializeComponent();
        }

        private void tspHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllotmentWindow allotmentWindow = new AllotmentWindow();
            allotmentWindow.Show();
        }

        private void tspBtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CandidateEducationalDetails candidateEducationalDetails = new CandidateEducationalDetails();
            candidateEducationalDetails.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCandidateEntranceSubmit_Click(object sender, EventArgs e)
        {
            CandidateDetails candidateDetails = null;
            int output = 0;
            int outputentrance = 0;

            try
            {
                candidateDetails = new CandidateDetails();
                candidateDetails.RegisterNumber = Convert.ToInt32(txtRegisterNumber.Text);
                candidateDetails.EntranceRank = Convert.ToInt32(txtRank.Text);
                candidateDetails.EntranceScienceMark = Convert.ToInt32(txtScienceMark.Text);
                candidateDetails.EntranceMathsMark = Convert.ToInt32(txtMathsMark.Text);

                candidateDetails.Collegeprefernce1 = cmbCollegePreference1.Text;
                candidateDetails.Collegeprefernce2 = cmbCollegePreference2.Text;
                candidateDetails.CollegePrefernce3 = cmbCollegePreference3.Text;
                candidateDetails.CollegeCourse11 = cmbCoursePreference11.Text;
                candidateDetails.CollegeCourse12 = cmbCoursePreference12.Text;
                candidateDetails.CollegeCourse13 = cmbCoursePreference13.Text;
                candidateDetails.CollegeCourse21 = cmbCoursePreference21.Text;
                candidateDetails.CollegeCourse22 = cmbCoursePreference22.Text;
                candidateDetails.CollegeCourse23 = cmbCoursePreference23.Text;
                candidateDetails.CollegeCourse31 = cmbCoursePreference31.Text;
                candidateDetails.CollegeCourse32 = cmbCoursePreference32.Text;
                candidateDetails.CollegeCourse33 = cmbCoursePreference33.Text;


                output = EapBL.StudentCoursePreferenceInsert(candidateDetails);
                outputentrance = EapBL.StudentDetailsInsert(candidateDetails);
                if (output > 0 && outputentrance>0)
                {
                    lblMessage.Text = "Successfully added";
                    this.Hide();
                    AllotmentWindow allotmentWindow = new AllotmentWindow();
                    allotmentWindow.Show();
                }
                else
                {
                    lblMessage.Text = "Failed";
                }
                
            }
            catch (Exception ex)
            {

            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}