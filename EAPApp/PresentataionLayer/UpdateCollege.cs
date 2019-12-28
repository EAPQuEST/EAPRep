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
            CollegeDetails collegeDetails = null;
            int output = 0;
            try
            {
                collegeDetails = new CollegeDetails();
                collegeDetails.CollegeID = cmbCollegeId.Text;
                collegeDetails.CollegeName = txtCollegeName.Text;
                collegeDetails.TotalSeats = Convert.ToInt32(txtTotalSeats.Text);
                collegeDetails.CollegeAddress = txtAddress.Text;
                collegeDetails.CollegePhone = Convert.ToInt32(txtContactNumber.Text);

                output = EapBL.CollegeDetailsUpdate(collegeDetails);
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

        private void LoadAddressId()
        {
            DataSet dsCollegeIds = null;
            dsCollegeIds = EapBL.GetCollegeIds();

            try
            {
                dsCollegeIds = EapBL.GetCollegeIds();
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
            CollegeDetails collegeDetails = null;
            DataSet dsCollegeDetails = new DataSet();
            try
            {
                collegeDetails = EapBL.GetCollegeDetailsUsingId(cmbCollegeId.Text);
                if (collegeDetails != null)
                {
                    txtCollegeName.Text = collegeDetails.CollegeName;
                    txtTotalSeats.Text = collegeDetails.TotalSeats.ToString();
                    txtContactNumber.Text = collegeDetails.CollegePhone.ToString();
                    txtAddress.Text = collegeDetails.CollegeAddress;
                    //for(int i=0;i< dsCollegeDetails.Tables[0].Rows.Count; i++)
                    //{
                    //    var item = dsCollegeDetails.Tables[0].Rows[i]["Courses Available"].ToString();
                    //    for(int j=0; j < clbCoursesAvailable.Items.Count; j++)
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
            catch(Exception ex)
            {

            }

        }
    }
}
