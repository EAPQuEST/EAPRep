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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'engineeringAllotmentDatabaseDataSet1.candidate_details' table. You can move, or remove it, as needed.
            this.candidate_detailsTableAdapter.Fill(this.engineeringAllotmentDatabaseDataSet1.candidate_details);

        }
    }
}
