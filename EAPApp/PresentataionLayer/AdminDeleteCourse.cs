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
    public partial class AdminDeleteCourse : Form
    {
        public AdminDeleteCourse()
        {
            InitializeComponent();
        }


        private void LoadCollegeName()                                                      //Load college names in to combobox
        {
            DataSet dsCollegeName = null;
            try
            {
                dsCollegeName = EapBLAdmin.GetCollegeName();
                if (dsCollegeName != null)
                {
                    cmbCollegeNameSearch.DataSource = dsCollegeName.Tables[0];
                    cmbCollegeNameSearch.ValueMember = "college_name";

                    cmbCollegeNameSearch.DisplayMember = "college_name";

                }
                else
                {
                    lblMessage.Text = "No College available";
                }

            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }
        private void LoadCourseName()                                                           //Load course names in to combobox
        {
            DataSet dsCourseName =new DataSet();
            try
            {
                dsCourseName = EapBLAdmin.GetCourseName(cmbCollegeNameSearch.Text);
                if (dsCourseName != null)
                {
                    cmbCourseName.DataSource = dsCourseName.Tables[0];
                    cmbCourseName.ValueMember = "course_name";

                    cmbCourseName.DisplayMember = "course_name";

                }
                else
                {
                    lblMessage.Text = "No Course available";
                }

            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }


        private void LoadCourseNameAdd()                                                              //Load course names in to combobox
        {
            DataSet dsCourseNameAdd = new DataSet();
            try
            {
                dsCourseNameAdd = EapBLAdmin.GetCourseShowAll();
                if (dsCourseNameAdd != null)
                {
                    cmbAddCourse.DataSource = dsCourseNameAdd.Tables[0];
                    cmbAddCourse.ValueMember = "course_name";

                    cmbAddCourse.DisplayMember = "course_name";

                }
                else
                {
                    lblMessage.Text = "No Course available";
                }

            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }




        private void AdminDeleteCourse_Load(object sender, EventArgs e)
        {
            LoadCollegeName();
            LoadCourseNameAdd();


        }

        private void cmbCollegeNameSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCourseName();
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)                              //Delete course from course list
        {
            int output = 0;
            try
            {
                if (MessageBox.Show("Do you want to delete ?", "S I S", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    output = EapBLAdmin.CourseDelete(cmbCourseName.Text);


                    if (output > 0)
                    {
                        lblMessage.Text = "Course deleted successfully!!!!";
                       
                    }
                    else
                    {
                        lblMessage.Text = "Select a valid course !!!!!";
                    }
                }

            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)                                     //To add new courses
        {


            CollegeDetails collegeDetails = null;
            int output = 0;
           
            try
            {
                collegeDetails = new CollegeDetails();
                collegeDetails.CollegeName = cmbCollegeNameSearch.Text;
                collegeDetails.CourseName = cmbAddCourse.Text;
              

               // output = EapBLAdmin.CollegeDetailsUpdate(collegeDetails);

                if (MessageBox.Show("Do you want to add ?", "S I S", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    //
                    //ADD COURSE FUNTION TO THE TABLE
                    //
                    output = EapBLAdmin.CourseAdd(collegeDetails);


                    if (output > 0)
                    {
                        lblMessage.Text = "Course added successfully!!!!";

                    }
                    else
                    {
                        lblMessage.Text = "Select a valid course !!!!!";
                    }
                }

            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }

        private void cmbCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void cmbCollegeNameSearch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadCourseName();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlsBtnHomeDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllotmentWindow allotmentWindow = new AllotmentWindow();
            allotmentWindow.Show();
        }
    }
}
