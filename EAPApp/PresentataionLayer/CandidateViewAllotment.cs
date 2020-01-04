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
    public partial class CandidateViewAllotment : Form
    {
        public CandidateViewAllotment()
        {
            InitializeComponent();
        }

        private void CandidateViewAllotment_Load(object sender, EventArgs e)
        {
            CandidateAllotmentResult();
        }
        private void CandidateAllotmentResult()
        {
            DataSet ds = null;
            string userId = LoginInfo.userID;
            string college_Name = null;
            string course_Name = null;

            CandidateEducationalDetails loadForm = new CandidateEducationalDetails();
            CandidateDetails candidateDetails = null;
            try
            {
                candidateDetails = new CandidateDetails();

                candidateDetails = EapBL.ViewAllotmentResult();

                college_Name = candidateDetails.College_Name;
                course_Name = candidateDetails.Course_Name;

                MessageBox.Show("Congratulations, You got allotted to "+college_Name+" to the course "+course_Name+" ");
             

            }
            catch (Exception ex)
            {
                MessageBox.Show("Better Luck Next Time");
            }


        }


       


    }
}
