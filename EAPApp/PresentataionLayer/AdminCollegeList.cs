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
    public partial class AdminCollegeList : Form
    {
        public AdminCollegeList()
        {
            InitializeComponent();
            
        }



        private void LoadCollegeList()                                                      //View college list
        {
            DataSet dsCollegeList = null;
            try
            {
                dsCollegeList = EapBLAdmin.ViewCollegeList();
                if (dsCollegeList != null)
                {
                    dgvCollegeList.DataSource = dsCollegeList.Tables[0];

                }
              

            }
            catch (Exception ex)
            {
               
            }
        }

        private void AdminCollegeList_Load(object sender, EventArgs e)
        {
            LoadCollegeList();
        }

        private void tlsBtnHomeDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllotmentWindow allotmentWindow = new AllotmentWindow();
            allotmentWindow.Show();
        }
    }









}
