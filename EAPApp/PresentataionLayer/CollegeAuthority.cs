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
    public partial class CollegeAuthority : Form
    {
        public CollegeAuthority()
        {
            InitializeComponent();

        }

        private void btnConfirmCandidate_Click(object sender, EventArgs e)
        {
         
            int output = 0;
            string searchId = txtSearchID.Text;
            

            try
            {
               


                
                output = EapBLCollege.UpdateStatus(searchId);
                if (output > 0)
                {
                    //lblMessage.Text = "Successfully updated";



                }
                else
                {
                    //lblMessage.Text = "Try again later";
                }

            }
            catch (Exception ex)
            {
                //lblMessage.Text = ex.Message.ToString();
            }
        }

        private void cmbSearchId_SelectedIndexChanged(object sender, EventArgs e)
        {
            CandidateDetails candidateDetails = null;
            try
            {
                //candidateDetails = EapBL.GetCandidateIds(cmbSearchId);

            }
            catch (Exception ex)
            {

            }
        }

        //private void LoadCandidateId()
        //{
        //    DataSet dsCandidate = null;
        //    try
        //    {
        //        dsCandidate = EapBL.GetCandidateIds();
        //        if(dsCandidate != null)
        //        {
        //            cmbSearchId.DataSource = dsCandidate.Tables[0];
        //            cmbSearchId.ValueMember = "candidate_id";
        //            cmbSearchId.DisplayMember = "candidate_id";
        //        }
        //        else
        //        {

        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        private void CollegeAuthority_Load(object sender, EventArgs e)
        {
            //LoadCandidateId();
        }

        private void tspHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllotmentWindow allotmentWindow = new AllotmentWindow();
            allotmentWindow.Show();
        }

        private void tspBtnBack_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchID_TextChanged(object sender, EventArgs e)
        {
            DataSet dsCandidateId = null;
            try
            {
                dsCandidateId = EapBLCollege.GetCandidateIdLike(txtSearchID.Text);
                if (dsCandidateId != null)
                {
                    dgvCollegeAllotedList.DataSource = dsCandidateId.Tables[0];


                }
                else
                {
                    MessageBox.Show("No students available");
                }

            }
            catch (Exception ex)
            {

                //lblMessage.Text = ex.Message.ToString();
            }
        }


        

        private void dgvCollegeAllotedList_SelectionChanged(object sender, EventArgs e)
        {
            string candidateId, entranceId;
            int output = 0;

            if (dgvCollegeAllotedList.SelectedCells.Count > 0)
            {

                int seletedrowindex = dgvCollegeAllotedList.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvCollegeAllotedList.Rows[seletedrowindex];

                candidateId = Convert.ToString(selectedRow.Cells["candidate_id"].Value);

                entranceId = Convert.ToString(selectedRow.Cells["entrance_id"].Value);

                    

                    txtViewID.Text = candidateId;
                    txtViewEntrance.Text = entranceId;


              
            }
        }
    }
}

