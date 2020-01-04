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
    public partial class AllotmentProcess : Form
    {
        public AllotmentProcess()
        {
            InitializeComponent();
        }

        private void btnGenerateAllotment_Click(object sender, EventArgs e)
        {
            int output = 0;
            output = EapBLAllotment.FetchByRow();
            if (output > 0)
            {
                MessageBox.Show("Allottment Successfull");
            }
            else
            {
                MessageBox.Show("Try Again");
            }
        }

        private void tlsBtnHomeDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllotmentWindow allotmentWindow = new AllotmentWindow();
            allotmentWindow.Show();
        }
    }
}
