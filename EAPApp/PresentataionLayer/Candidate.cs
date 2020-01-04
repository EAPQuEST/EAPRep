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
    public partial class Candidate : Form
    {
        public Candidate()
        {
            InitializeComponent();
            lblUserId.Text = LoginInfo.userID;
        }

        private void educationalDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CandidateEducationalDetails candidateEducationalDetails = new CandidateEducationalDetails();
            candidateEducationalDetails.Show();
            candidateEducationalDetails.MdiParent = this;
        }

        private void entranceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CandidateEntrance candidateEntrance = new CandidateEntrance();
            //candidateEntrance.Show();
            //candidateEntrance.MdiParent = this;
        }

        private void viewAllotmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CandidateViewAllotment candidateViewAllotment = new CandidateViewAllotment();
            candidateViewAllotment.Show();
            candidateViewAllotment.MdiParent = this;
        }

        private void Candidate_Load(object sender, EventArgs e)
        {

        }

        private void tspHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllotmentWindow allotmentWindow = new AllotmentWindow();
            allotmentWindow.Show();
        }
    }
}
