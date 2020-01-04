using BusinessLayer.BL;
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

namespace PresentataionLayer
{
    public partial class AllotmentProcessWindow : Form
    {
        public AllotmentProcessWindow()
        {
            InitializeComponent();
        }

        private void btnGenerateAllotment_Click(object sender, EventArgs e)
        {
            int output = 0;
            output = EapBLAllotment.FetchByRow();
            if (output > 0)
            {
                LoadStudents();
                MessageBox.Show("Allottment Successfull");
            }
            else
            {
                MessageBox.Show("Try Again");
            }


        }



        private void LoadStudents()
        {
            DataSet dsStudents = null;
            try
            {
                dsStudents = EapBLAdmin.GetStudents();
                if (dsStudents != null)
                {

                    dgvAllotedTable.DataSource = dsStudents.Tables[0];

                }
                else
                {
                    Console.WriteLine("Loadstudents()Error");
                }

            }
            catch (FormatException ex)
            {
               // lblMessage.Text = ex.Message.ToString();
            }
        }

        private void AllotmentProcessWindow_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }
    }
}
