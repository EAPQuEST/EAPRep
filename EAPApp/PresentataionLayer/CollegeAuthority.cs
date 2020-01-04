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

        }

        private void cmbSearchId_SelectedIndexChanged(object sender, EventArgs e)
        {
            CandidateDetails candidateDetails = null;
            try
            {
                //candidateDetails = EapBL.GetCandidateIds(cmbSearchId);
                
            }
            catch(Exception ex)
            {

            }
        }

        private void LoadCandidateId()
        {
            DataSet dsCandidate = null;
            try
            {
                dsCandidate = EapBL.GetCandidateIds();
                if(dsCandidate != null)
                {
                    cmbSearchId.DataSource = dsCandidate.Tables[0];
                    cmbSearchId.ValueMember = "candidate_id";
                    cmbSearchId.DisplayMember = "candidate_id";
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void CollegeAuthority_Load(object sender, EventArgs e)
        {
            LoadCandidateId();
        }
    }
}
