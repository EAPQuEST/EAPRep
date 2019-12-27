using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
