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


namespace PresentataionLayer
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void addCollegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addCollegeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            AddCollege addCollege = new AddCollege();
            addCollege.Show();
            addCollege.MdiParent = this;
        }

        private void Administrator_Load(object sender, EventArgs e)
        {

        }

        private void deleteCollegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCollege deleteCollege = new DeleteCollege();
            deleteCollege.Show();
            deleteCollege.MdiParent = this;
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCollege updateCollege = new UpdateCollege();
            updateCollege.Show();
            updateCollege.MdiParent = this;
        }

        private void viewCollegeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminCollegeList adminCollegeList = new AdminCollegeList();
            adminCollegeList.Show();
            adminCollegeList.MdiParent = this;
        }

        private void viewAllottedListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAlottedList adminAlottedList = new AdminAlottedList();
            adminAlottedList.Show();
            adminAlottedList.MdiParent = this;
        }

        private void deleteCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCollege updateCollege = new UpdateCollege();
            updateCollege.Show();
            updateCollege.MdiParent = this;
        }

        private void btnGenerateAllotment_Click(object sender, EventArgs e)
        {
           
        }

        private void allotmentProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllotmentProcess allotmentProcess = new AllotmentProcess();
            allotmentProcess.Show();
            allotmentProcess.MdiParent = this;
        }

        private void tlsBtnHomeDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllotmentWindow allotmentWindow = new AllotmentWindow();
            allotmentWindow.Show();
        }

        private void updateCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminDeleteCourse adminDeleteCourse = new AdminDeleteCourse();
            adminDeleteCourse.Show();
            adminDeleteCourse.MdiParent = this;
        }
    }
}
