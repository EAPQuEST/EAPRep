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
            this.Hide();
            AllotmentWindow allotmentWindow = new AllotmentWindow();
            allotmentWindow.Show();
        }

        private void btnAddCollege_Click(object sender, EventArgs e)                            //Adding College details and Course details
        {
            CollegeDetails collegeDetails = null;
            int output = 0;
            int outputcourse = 0;

            try
            {
                if (txtCollegeID.Text == string.Empty || txtCollegeName.Text == string.Empty ||  
                      txtAddress.Text == string.Empty || txtContactNumber.Text == string.Empty)
                {
                    // MessageBox.Show("Enter all the details");
                    foreach (Control control in this.Controls)
                    {
                        if (!Validate())
                        {
                            DialogResult = DialogResult.None;
                            return;
                        }
                    }
                }

                else
                {

                    collegeDetails = new CollegeDetails();

                    if (txtCollegeID.Text == string.Empty)                          
                    {
                        lblMessage.Text = "Enter the College ID";
                        return;
                    }
                    else
                    {
                        collegeDetails.CollegeID = txtCollegeID.Text;
                    }
                    if (txtCollegeName.Text == string.Empty)
                    {
                        lblMessage.Text = "Enter the College Name";
                        return;
                    }
                    else
                    {
                        collegeDetails.CollegeName = txtCollegeName.Text;
                    }
                   
                    if (txtAddress.Text == string.Empty)
                    {
                        lblMessage.Text = "Enter the address";
                        return;
                    }
                    else
                    {
                        collegeDetails.CollegeAddress = txtAddress.Text;
                    }
                    if (txtContactNumber.Text == string.Empty)
                    {
                        lblMessage.Text = "Enter the contact number";
                        return;
                    }
                    else
                    {
                        collegeDetails.CollegePhone = Convert.ToInt64(txtContactNumber.Text);
                    }
                    if (clbCoursesAvailable.Items.Count <0)
                    {
                        lblMessage.Text = "Select the courses available";
                        return;
                    }
                    else
                    {
                        for (int i = 0; i < clbCoursesAvailable.Items.Count; i++)
                        {
                            if (clbCoursesAvailable.GetItemChecked(i))
                            {
                                collegeDetails.CourseName = (string)clbCoursesAvailable.Items[i];
                                outputcourse = EapBLAdmin.CollegeCourseInsert(collegeDetails);

                            }
                        }
                    }

                    output = EapBLAdmin.CollegeDetailsInsert(collegeDetails);
                    if (output > 0 || outputcourse > 0)
                    {
                        lblMessage.Text = "Successfully added";
                    }
                    else
                    {
                        lblMessage.Text = "Failed";
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message.ToString();

            }

         
        }

        private void pnlCourseDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlsBtnHomeDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllotmentWindow allotmentWindow = new AllotmentWindow();
            allotmentWindow.Show();
        }

        private void lblCourseDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
