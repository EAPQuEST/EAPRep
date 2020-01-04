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
    public partial class CandidateEntrance : Form
    {
        CandidateDetails candidateDetails = null;
        public CandidateEntrance()
        {
            InitializeComponent();
            lblUserId.Text = LoginInfo.userID;
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

            int output = 0;
            int outputentrance = 0;
            int outputAllotment = 0;

            try
            {
                candidateDetails = new CandidateDetails();


                candidateDetails.RegisterNumber = Convert.ToInt32(txtRegisterNumber.Text);
                candidateDetails.EntranceRank = Convert.ToInt32(txtRank.Text);


                candidateDetails.EntranceScienceMark = Convert.ToInt32(txtScienceMark.Text);
                candidateDetails.EntranceMathsMark = Convert.ToInt32(txtMathsMark.Text);


                if (cmbCollegePreference1.SelectedIndex == -1)
                {
                    lblMessage.Text = "Please select a college Preference 1 !!!";
                    return;

                }
                else
                {
                    candidateDetails.Collegeprefernce1 = cmbCollegePreference1.Text;
                }
                if (cmbCollegePreference2.SelectedIndex == -1)
                {
                    lblMessage.Text = "Please select a college Preference 2 !!!";
                    return;

                }
                else
                {
                    candidateDetails.Collegeprefernce2 = cmbCollegePreference2.Text;
                }

                if (cmbCollegePreference3.SelectedIndex == -1)
                {
                    lblMessage.Text = "Please select a college Preference 1 !!!";
                    return;

                }
                else
                {
                    candidateDetails.CollegePrefernce3 = cmbCollegePreference3.Text;
                }
                if (cmbCoursePreference11.SelectedIndex == -1)
                {
                    lblMessage.Text = "Please select a course Preference !!!";
                    return;

                }
                else
                {
                    candidateDetails.CollegeCourse11 = cmbCoursePreference11.Text;
                }
                if (cmbCoursePreference12.SelectedIndex == -1)
                {
                    lblMessage.Text = "Please select a course Preference !!!";
                    return;

                }
                else
                {
                    candidateDetails.CollegeCourse12 = cmbCoursePreference12.Text;
                }

                if (cmbCoursePreference13.SelectedIndex == -1)
                {
                    lblMessage.Text = "Please select a course Preference !!!";
                    return;

                }
                else
                {
                    candidateDetails.CollegeCourse13 = cmbCoursePreference13.Text;
                }


                               


                if (cmbCoursePreference21.SelectedIndex == -1)
                {
                    lblMessage.Text = "Please select a course Preference !!!";
                    return;

                }
                else
                {
                    candidateDetails.CollegeCourse21 = cmbCoursePreference21.Text;
                }
                if (cmbCoursePreference22.SelectedIndex == -1)
                {
                    lblMessage.Text = "Please select a course Preference !!!";
                    return;

                }
                else
                {
                    candidateDetails.CollegeCourse22 = cmbCoursePreference22.Text;
                }
                if (cmbCoursePreference23.SelectedIndex == -1)
                {
                    lblMessage.Text = "Please select a course Preference !!!";
                    return;

                }
                else
                {
                    candidateDetails.CollegeCourse23 = cmbCoursePreference23.Text;
                }





                if (cmbCoursePreference31.SelectedIndex == -1)
                {
                    lblMessage.Text = "Please select a course Preference !!!";
                    return;

                }
                else
                {
                    candidateDetails.CollegeCourse31 = cmbCoursePreference31.Text;
                }
                if (cmbCoursePreference32.SelectedIndex == -1)
                {
                    lblMessage.Text = "Please select a course Preference !!!";
                    return;

                }
                else
                {
                    candidateDetails.CollegeCourse32 = cmbCoursePreference32.Text;
                }
                if (cmbCoursePreference33.SelectedIndex == -1)
                {
                    lblMessage.Text = "Please select a course Preference !!!";
                    return;

                }
                else
                {
                    candidateDetails.CollegeCourse33 = cmbCoursePreference33.Text;
                }
                               


                if (candidateDetails.EntranceScienceMark > 100 || candidateDetails.EntranceScienceMark < 0 ||
                    candidateDetails.EntranceMathsMark > 100 || candidateDetails.EntranceMathsMark < 0  )
                {
                    lblMessage.Text = "Enter a valid mark (0-100) !!!";
                    return;
                }
                else
                {
                    outputentrance = EapBL.StudentDetailsInsert(candidateDetails);
                }


                    outputAllotment = EapBLAdmin.GenerateAllotment(candidateDetails);
                output = EapBL.StudentCoursePreferenceInsert(candidateDetails);
               
                if (output > 0 && outputentrance > 0)
                {
                    MessageBox.Show("Successfully added");

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
                ex.Message.ToString();
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
           


        }

        public void LoadCoursePreference()
        {

            //CollegeDetails collegeDetails = null;
            DataSet dsCoursePreference = new DataSet();
            try
            {
                dsCoursePreference = EapBL.LoadCollegePreference(cmbCollegePreference1.SelectedValue.ToString());
               // collegeDetails = EapBL.LoadCollegePreference(cmbCollegePreference1.Text);
                if (dsCoursePreference != null)
                {

                   
                    cmbCoursePreference11.DataSource = dsCoursePreference.Tables[0];
                    cmbCoursePreference11.ValueMember = "course_name";
                    cmbCoursePreference11.DisplayMember = "course_name";
                }


            }
            catch (FormatException ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }

        private void cmbCollegePreference1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string selectedValue = cmbCollegePreference1.SelectedValue.ToString();

            ComboBox cmb = (ComboBox)sender;
            int selectedIndex = cmb.SelectedIndex;
            // string selectedValue = (string)cmb.SelectedValue;

            //  ComboboxItem selectedCar = (ComboboxItem)cmb.SelectedItem;
            MessageBox.Show(String.Format("Index: [{0}]  Value={1}", selectedIndex, selectedValue));
            // }


            LoadCoursePreference();




        }

        private void CandidateEntrance_Load(object sender, EventArgs e)
        {
            LoadCollegeName();
        }
        /// <summary>
        /// 
        /// </summary>
        private void LoadCollegeName()
        {
           
            DataSet dsCollegeName = new DataSet();
            try
            {
                dsCollegeName = EapBLAdmin.GetCollegeName();
                if (dsCollegeName != null)
                {
                    
                   cmbCollegePreference1.DataSource = dsCollegeName.Tables[0];
                    cmbCollegePreference1.ValueMember = "college_name";
                    cmbCollegePreference1.DisplayMember = "college_name";
                }


            }
            catch (FormatException ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }

        private void txtRegisterNumber_Validating(object sender, CancelEventArgs e)
        {
            if (txtRegisterNumber.Text == string.Empty)
            {
                epValidation.SetError(txtRegisterNumber, "Register Number  is required !");
            }
            else
            {
                epValidation.SetError(txtRegisterNumber, string.Empty);
            }
        }

        private void txtRank_Validating(object sender, CancelEventArgs e)
        {
            if (txtRank.Text == string.Empty)
            {
                epValidation.SetError(txtRank, "Rank is required !");
            }
            else
            {
                epValidation.SetError(txtRank, string.Empty);
            }
        }

        private void txtScienceMark_Validating(object sender, CancelEventArgs e)
        {
            if (txtScienceMark.Text == string.Empty)
            {
                epValidation.SetError(txtScienceMark, "Mark is required !");
            }
            else
            {
                epValidation.SetError(txtScienceMark, string.Empty);
            }
        }

        private void txtMathsMark_Validating(object sender, CancelEventArgs e)
        {
            if (txtMathsMark.Text == string.Empty)
            {
                epValidation.SetError(txtMathsMark, "Mark is required !");
            }
            else
            {
                epValidation.SetError(txtMathsMark, string.Empty);
            }
        }
    }
}
