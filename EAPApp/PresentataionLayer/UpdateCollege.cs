using System;
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
    public partial class UpdateCollege : Form
    {
        public UpdateCollege()
        {
            InitializeComponent();
            LoadAddressId();
        }

        private void btnUpdateCollege_Click(object sender, EventArgs e)
        {
            
        }

        private void LoadAddressId()
        {
            DataSet dsCollegeIds = null;
            dsCollegeIds = EapBLAdmin.GetCollegeIds();

            try
            {
                dsCollegeIds = EapBLAdmin.GetCollegeIds();
                if (dsCollegeIds != null)
                {

                    cmbCollegeId.DataSource = dsCollegeIds.Tables[0];
                    cmbCollegeId.ValueMember = "college_id";
                    cmbCollegeId.DisplayMember = "college_id";
                }
                else
                {
                    lblMessage.Text = "No students Available";
                }

            }
            catch (FormatException ex)
            {
               lblMessage.Text = ex.Message.ToString();
            }
        }

        private void cmbCollegeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbCollegeId_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CollegeDetails collegeDetails = null;
            DataSet dsCollegeDetails = new DataSet();
            try
            {
                collegeDetails = EapBLAdmin.GetCollegeDetailsUsingId(cmbCollegeId.Text);
                if (collegeDetails != null)
                {
                    txtCollegeName.Text = collegeDetails.CollegeName;
                  
                    txtContactNumber.Text = collegeDetails.CollegePhone.ToString();
                    txtAddress.Text = collegeDetails.CollegeAddress;
                  

                }

            }
            catch (Exception ex)
            {

            }

        }

        private void btnUpdateCollege_Click_1(object sender, EventArgs e)
        {
            

        }

        //private void btnUpdateCourse_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnUpdateCollegeDetails_Click(object sender, EventArgs e)
        //{

        //}

        private void btnUpdateCourse_Click_1(object sender, EventArgs e)
        {
            //CollegeDetails collegeDetails = null;
            //int output = 0;
            //int outputcourse = 0;

            //try
            //{
            //    clbCoursesAvailable.Items.Clear();
            //    foreach (String s in clbCoursesAvailable.CheckedItems)
            //    {
            //       // collegeDetails.Items.Add(s);
            //    }
            //    output = EapBLAdmin.CollegeDetailsInsert(collegeDetails);
            //}
            //catch (Exception ex)
            //{

            //}02153
            
        }
            private void btnUpdateCollege_Click_2(object sender, EventArgs e)
        {
            CollegeDetails collegeDetails = null;
            int output = 0;
            int outputcourse = 0;
            try
            {
                collegeDetails = new CollegeDetails();
                collegeDetails.CollegeID = cmbCollegeId.Text;
                collegeDetails.CollegeName = txtCollegeName.Text;
               
                collegeDetails.CollegeAddress = txtAddress.Text;
                collegeDetails.CollegePhone = Convert.ToInt32(txtContactNumber.Text);
                //for (int i = 0; i < clbCoursesAvailable.Items.Count; i++)
                //{
                //    if (clbCoursesAvailable.GetItemChecked(i))
                //    {
                //        collegeDetails.CourseName = (string)clbCoursesAvailable.Items[i];
                //        outputcourse = EapBLAdmin.CollegeCourseUpdate(collegeDetails);

                //    }
                //}


                output = EapBLAdmin.CollegeDetailsUpdate(collegeDetails);
                if (output > 0)
                {
                    lblMessage.Text = "Successfully updated";



                }
                else
                {
                    lblMessage.Text = "Try again later";
                }

            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }

        }

        private void cmbCollegeId_SelectedIndexChanged_2(object sender, EventArgs e)                //Load details of the selected college id from the combobox 
        {
            CollegeDetails collegeDetails = null;
            DataSet dsCollegeDetails = new DataSet();
            try
            {
                collegeDetails = EapBLAdmin.GetCollegeDetailsUsingId(cmbCollegeId.Text);
                if (collegeDetails != null)
                {
                    txtCollegeName.Text = collegeDetails.CollegeName;
                    
                    txtContactNumber.Text = collegeDetails.CollegePhone.ToString();
                    txtAddress.Text = collegeDetails.CollegeAddress;
                    //for (int i = 0; i < dsCollegeDetails.Tables[0].Rows.Count; i++)
                    //{
                    //    var item = dsCollegeDetails.Tables[0].Rows[i]["course_name"].ToString();
                    //    for (int j = 0; j < clbCoursesAvailable.Items.Count; j++)
                    //    {
                    //        if (clbCoursesAvailable.Items[j].ToString() == item)
                    //        {
                    //            clbCoursesAvailable.SetItemChecked(j, true);
                    //            break;
                    //        }
                    //    }
                    //}

                }

            }
            catch (Exception ex)
            {

            }





            //    }
            //    catch (Exception ex)
            //    {
            //        lblMessage.Text = ex.Message.ToString();
            //    }
        }

        private void tlsBtnHomeDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllotmentWindow allotmentWindow = new AllotmentWindow();
            allotmentWindow.Show();
        }

        private void pnlCollegeDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateCollege_Load(object sender, EventArgs e)
        {
            txtCollegeName.ReadOnly = true;
        }

        private void lblCollegeDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
