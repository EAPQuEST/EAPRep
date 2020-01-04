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
            int outputAllotment = 0;
            int outputentrance = 0;

            try
            {
                candidateDetails = new CandidateDetails();
                candidateDetails.RegisterNumber = Convert.ToInt32(txtRegisterNumber.Text);
                candidateDetails.EntranceRank = Convert.ToInt32(txtRank.Text);
                candidateDetails.EntranceScienceMark = Convert.ToInt32(txtScienceMark.Text);
                candidateDetails.EntranceMathsMark = Convert.ToInt32(txtMathsMark.Text);
                //CandidateEducationalDetails cd = new CandidateEducationalDetails();
           
                
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

                outputAllotment = EapBLAdmin.GenerateAllotment(candidateDetails);
                outputentrance = EapBL.StudentDetailsInsert(candidateDetails);
                output = EapBL.StudentCoursePreferenceInsert(candidateDetails);
                
               
                if (output > 0 && outputentrance > 0)
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

        private void btnView_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register Number \t\t:" + candidateDetails.RegisterNumber + "\nRank\t:" + candidateDetails.EntranceRank + "\nDepartment\t:" +
                candidateDetails.EntranceScienceMark + "\nEmail\t\t:" + candidateDetails.EntranceMathsMark + "\nMob\t\t :" + candidateDetails.Collegeprefernce1 + "\nDOB\t\t:" + candidateDetails.Collegeprefernce2 + "\nGender\t\t:" +
                candidateDetails.CollegePrefernce3 + "\nHobbies\t\t:" + candidateDetails.CollegeCourse11);


        }

        public void LoadCoursePreference11()
        {

            //CollegeDetails collegeDetails = null;
            DataSet dsCoursePreference = new DataSet();
            try
            {
                dsCoursePreference = EapBL.LoadCollegePreference(cmbCollegePreference1.SelectedValue.ToString());
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
        public void LoadCoursePreference12()
        {

            //CollegeDetails collegeDetails = null;
            DataSet dsCoursePreference = new DataSet();
            try
            {
                dsCoursePreference = EapBL.LoadCollegePreference(cmbCollegePreference1.SelectedValue.ToString());
                if (dsCoursePreference != null)
                {


                    

                    cmbCoursePreference12.DataSource = dsCoursePreference.Tables[0];
                    cmbCoursePreference12.ValueMember = "course_name";
                    cmbCoursePreference12.DisplayMember = "course_name";

                    
                }


            }
            catch (FormatException ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }
        public void LoadCoursePreference13()
        {

            //CollegeDetails collegeDetails = null;
            DataSet dsCoursePreference = new DataSet();
            try
            {
                dsCoursePreference = EapBL.LoadCollegePreference(cmbCollegePreference1.SelectedValue.ToString());
                if (dsCoursePreference != null)
                {




                    cmbCoursePreference13.DataSource = dsCoursePreference.Tables[0];
                    cmbCoursePreference13.ValueMember = "course_name";
                    cmbCoursePreference13.DisplayMember = "course_name";


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
            //MessageBox.Show(String.Format("Index: [{0}]  Value={1}", selectedIndex, selectedValue));
       // }


            LoadCoursePreference11();
            LoadCoursePreference12();
            LoadCoursePreference13();
        }

        private void CandidateEntrance_Load(object sender, EventArgs e)
        {
            LoadCollegeName();
            LoadCollegeName1();
            LoadCollegeName3();
        }
        private void LoadCollegeName()
        {
           
            DataSet dsCollegeName = new DataSet();
            try
            {
                dsCollegeName = EapBLAdmin.GetCollegeName();
                if (dsCollegeName != null)
                {
                    
                    cmbCollegePreference1.DataSource = dsCollegeName.Tables[0];
                    cmbCollegePreference1.ValueMember = "college_id";
                    cmbCollegePreference1.DisplayMember = "college_name";

                    
                }


            }
            catch (FormatException ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }
        private void LoadCollegeName1()
        {

            DataSet dsCollegeName = new DataSet();
            try
            {
                dsCollegeName = EapBLAdmin.GetCollegeName();
                if (dsCollegeName != null)
                {



                    cmbCollegePreference2.DataSource = dsCollegeName.Tables[0];
                    cmbCollegePreference2.ValueMember = "college_id";
                    cmbCollegePreference2.DisplayMember = "college_name";


                }


            }
            catch (FormatException ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }
        private void LoadCollegeName3()
        {

            DataSet dsCollegeName = new DataSet();
            try
            {
                dsCollegeName = EapBLAdmin.GetCollegeName();
                if (dsCollegeName != null)
                {



                    cmbCollegePreference3.DataSource = dsCollegeName.Tables[0];
                    cmbCollegePreference3.ValueMember = "college_id";
                    cmbCollegePreference3.DisplayMember = "college_name";


                }


            }
            catch (FormatException ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }

        private void cmbCollegePreference2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbCollegePreference2.SelectedValue.ToString();

            ComboBox cmb1 = (ComboBox)sender;
            int selectedIndex = cmb1.SelectedIndex;
           


            LoadCoursePreference21();
            LoadCoursePreference22();
            LoadCoursePreference23();

        }
        public void LoadCoursePreference21()
        {

            //CollegeDetails collegeDetails = null;
            DataSet dsCoursePreference = new DataSet();
            try
            {
                dsCoursePreference = EapBL.LoadCollegePreference(cmbCollegePreference2.SelectedValue.ToString());
                if (dsCoursePreference != null)
                {


                    cmbCoursePreference21.DataSource = dsCoursePreference.Tables[0];
                    cmbCoursePreference21.ValueMember = "course_name";
                    cmbCoursePreference21.DisplayMember = "course_name";

                    cmbCoursePreference22.DataSource = dsCoursePreference.Tables[0];
                    cmbCoursePreference22.ValueMember = "course_name";
                    cmbCoursePreference22.DisplayMember = "course_name";

                    cmbCoursePreference23.DataSource = dsCoursePreference.Tables[0];
                    cmbCoursePreference23.ValueMember = "course_name";
                    cmbCoursePreference23.DisplayMember = "course_name";
                }


            }
            catch (FormatException ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }
        public void LoadCoursePreference22()
        {

            //CollegeDetails collegeDetails = null;
            DataSet dsCoursePreference = new DataSet();
            try
            {
                dsCoursePreference = EapBL.LoadCollegePreference(cmbCollegePreference2.SelectedValue.ToString());
                if (dsCoursePreference != null)
                {




                    cmbCoursePreference22.DataSource = dsCoursePreference.Tables[0];
                    cmbCoursePreference22.ValueMember = "course_name";
                    cmbCoursePreference22.DisplayMember = "course_name";


                }


            }
            catch (FormatException ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }

        public void LoadCoursePreference23()
        {

            //CollegeDetails collegeDetails = null;
            DataSet dsCoursePreference = new DataSet();
            try
            {
                dsCoursePreference = EapBL.LoadCollegePreference(cmbCollegePreference2.SelectedValue.ToString());
                if (dsCoursePreference != null)
                {


                    
                    cmbCoursePreference23.DataSource = dsCoursePreference.Tables[0];
                    cmbCoursePreference23.ValueMember = "course_name";
                    cmbCoursePreference23.DisplayMember = "course_name";
                }


            }
            catch (FormatException ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }

        private void cmbCollegePreference3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbCollegePreference3.SelectedValue.ToString();

            ComboBox cmb2 = (ComboBox)sender;
            int selectedIndex = cmb2.SelectedIndex;


            LoadCoursePreference31();
            LoadCoursePreference32();
            LoadCoursePreference33();

        }

        public void LoadCoursePreference31()
        {

            //CollegeDetails collegeDetails = null;
            DataSet dsCoursePreference = new DataSet();
            try
            {
                dsCoursePreference = EapBL.LoadCollegePreference(cmbCollegePreference3.SelectedValue.ToString());
                if (dsCoursePreference != null)
                {


                    cmbCoursePreference31.DataSource = dsCoursePreference.Tables[0];
                    cmbCoursePreference31.ValueMember = "course_name";
                    cmbCoursePreference31.DisplayMember = "course_name";

                    cmbCoursePreference32.DataSource = dsCoursePreference.Tables[0];
                    cmbCoursePreference32.ValueMember = "course_name";
                    cmbCoursePreference32.DisplayMember = "course_name";

                    cmbCoursePreference33.DataSource = dsCoursePreference.Tables[0];
                    cmbCoursePreference33.ValueMember = "course_name";
                    cmbCoursePreference33.DisplayMember = "course_name";
                }


            }
            catch (FormatException ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }

        public void LoadCoursePreference32()
        {

            //CollegeDetails collegeDetails = null;
            DataSet dsCoursePreference = new DataSet();
            try
            {
                dsCoursePreference = EapBL.LoadCollegePreference(cmbCollegePreference3.SelectedValue.ToString());
                if (dsCoursePreference != null)
                {


                   

                    cmbCoursePreference32.DataSource = dsCoursePreference.Tables[0];
                    cmbCoursePreference32.ValueMember = "course_name";
                    cmbCoursePreference32.DisplayMember = "course_name";

                    
                }


            }
            catch (FormatException ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }

        public void LoadCoursePreference33()
        {

            //CollegeDetails collegeDetails = null;
            DataSet dsCoursePreference = new DataSet();
            try
            {
                dsCoursePreference = EapBL.LoadCollegePreference(cmbCollegePreference3.SelectedValue.ToString());
                if (dsCoursePreference != null)
                {


                   

                    cmbCoursePreference33.DataSource = dsCoursePreference.Tables[0];
                    cmbCoursePreference33.ValueMember = "course_name";
                    cmbCoursePreference33.DisplayMember = "course_name";
                }


            }
            catch (FormatException ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }
    }
}
