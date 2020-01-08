using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using cs_Week5.dto;
using cs_Week5.dao;
using cs_Week5.bl;
using System.Data;

namespace cs_Week5.Student
{
    public partial class StudentMaster : Form
    {
        int countMark1 = 0; bool flagMark1 = false;
        int countMark2 = 0; bool flagMark2 = false;
        int countMark3 = 0; bool flagMark3 = false;

        public StudentMaster()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //SqlConnection con = null;
            //SqlCommand cmd = null;
            //String ConnectionString = null;
            //String sql = null;

            //string student_id, student_name, result;
            //int mark1, mark2, mark3, total;

            //int output = 0;

            //try
            //{
            //    ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\1028283\\Desktop\\raheena\\Week5\\cs_Week5\\cs_Week5\\StudentDB.mdf; Integrated Security = True";
            //    con = new SqlConnection(ConnectionString);

            //    student_id = txtStudentId.Text;
            //    student_name = txtStudentName.Text;
            //    mark1 = Convert.ToInt32(txtMark1.Text);
            //    mark2 = Convert.ToInt32(txtMark2.Text);
            //    mark3 = Convert.ToInt32(txtMark3.Text);

            //    total = mark1 + mark2 + mark3;
            //    if(mark1<50 || mark2<50 || mark3 < 50)
            //    {
            //        result = "Fail";
            //    }
            //    else
            //    {
            //        result = "Pass";
            //    }

            //    sql = "insert into student_mark(student_id,student_name,mark1,mark2,mark3,total,result) values(";
            //    sql = sql + "'" + student_id + "',";
            //    sql = sql + "'" + student_name + "',";
            //    sql = sql +mark1+ ",";
            //    sql = sql + mark2 + ",";
            //    sql = sql + mark3 + ",";
            //    sql = sql + total + ",";
            //    sql = sql + "'"+result + "')";


            //    con.Open();

            //    cmd = new SqlCommand(sql, con);

            //    output = cmd.ExecuteNonQuery();
            //    if (output >0)
            //    {
            //        lblMessage.Text = "Success";
            //    }
            //    else
            //    {
            //        lblMessage.Text = "Fail";
            //    }




            //}
            //catch (Exception ex)
            //{
            //    lblMessage.Text = ex.Message.ToString();


            //}

            //finally
            //{
            //    con.Close();
            //    cmd.Dispose();
            //}

            StudentMark studentMark = null;
            int output = 0;
            try
            {
                if (btnSave.Text == "NEW")
                {
                    btnSave.Text = "SAVE";
                    ClearControl();
                    txtStudentId.Text = StudentMarkBl.GetNewStudentId();

                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;

                    btnClear.Text = "BACK";


                }
                else
                {



                    studentMark = new StudentMark();
                    studentMark.StudentId = txtStudentId.Text;
                    studentMark.StudentName = txtStudentName.Text;
                    studentMark.Mark1 = Convert.ToInt32(txtMark1.Text);
                    studentMark.Mark2 = Convert.ToInt32(txtMark2.Text);
                    studentMark.Mark3 = Convert.ToInt32(txtMark3.Text);

                    if (studentMark.Mark1 < 0 || studentMark.Mark1 > 100 && studentMark.Mark2 < 0 || studentMark.Mark2 > 100 && studentMark.Mark3 < 0 || studentMark.Mark3 > 100)
                    {
                        lblMessage.Text = "Mark should be between 0-100";
                    }
                    else
                    {

                        output = StudentMarkBl.StudentMarkInsert(studentMark);
                        if (output > 0)
                        {
                            lblMessage.Text = "Successfully added";
                            LoadStudents();

                            btnSave.Text = "NEW";
                            btnDelete.Enabled = true;
                            btnUpdate.Enabled = true;

                            btnClear.Text = "CLEAR";

                        }
                        else
                        {
                            lblMessage.Text = "Fail";
                        }

                    }
                }
            }
            catch (FormatException ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (btnClear.Text == "BACK")
            {
                btnSave.Text = "NEW";
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnClear.Text = "CLEAR";
            }
            else
            {
                ClearControl();
            }
           
        }

        private void StudentMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet.student_mark' table. You can move, or remove it, as needed.
            this.student_markTableAdapter.Fill(this.studentDBDataSet.student_mark);
            LoadStudenIds();
            LoadStudents();
        }
        private void LoadStudenIds()
        {
            DataSet dsStudentIds = null;
            try
            {
                 dsStudentIds = StudentMarkBl.GetStudentIds();
                if (dsStudentIds != null)
                {
                   
                    cmbstudentId.DataSource = dsStudentIds.Tables[0];
                    cmbstudentId.ValueMember= "student_id";
                    cmbstudentId.DisplayMember = "student_id";
                }
                else
                {
                    lblMessage.Text = "No students Available";
                }

            }
             catch (FormatException ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }

        private void LoadStudents()
        {
            DataSet dsStudents = null;
            try
            {
                dsStudents = StudentMarkBl.GetStudents();
                if (dsStudents != null)
                {

                    dgvStudent.DataSource = dsStudents.Tables[0];
                   
                }
                else
                {
                    lblMessage.Text = "No students Available";
                }

            }
            catch (FormatException ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }
        private void cmbstudentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(cmbstudentId.Text);

            StudentMark studentMark = null;
            try
            {
                studentMark = StudentMarkBl.GetStudentById(cmbstudentId.Text);

                if (studentMark != null)
                {
                    txtStudentId.Text = studentMark.StudentId;
                    txtStudentName.Text = studentMark.StudentName;
                    txtMark1.Text = studentMark.Mark1.ToString();
                    txtMark2.Text = studentMark.Mark2.ToString();
                    txtMark3.Text = studentMark.Mark3.ToString();

                }
            }
            catch(Exception ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int output = 0;
            try
            {
                if (MessageBox.Show("Do you want to delete ?", "S I S", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    output = StudentMarkBl.StudentMarkDelete(cmbstudentId.Text);

                    if (output > 0)
                    {
                        lblMessage.Text = "Student details deleted successfully";
                        LoadStudenIds();
                        LoadStudents();
                    }
                    else
                    {
                        lblMessage.Text = "Please try again later";
                    }
                }
                
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StudentMark studentMark = null;
            int output = 0;
            try
            {

                studentMark = new StudentMark();
                studentMark.StudentId = txtStudentId.Text;
                studentMark.StudentName = txtStudentName.Text;
                studentMark.Mark1 = Convert.ToInt32(txtMark1.Text);
                studentMark.Mark2 = Convert.ToInt32(txtMark2.Text);
                studentMark.Mark3 = Convert.ToInt32(txtMark3.Text);

                if (studentMark.Mark1 < 0 || studentMark.Mark1 > 100 && studentMark.Mark2 < 0 || studentMark.Mark2 > 100 && studentMark.Mark3 < 0 || studentMark.Mark3 > 100)
                {
                    lblMessage.Text = "Mark1 should be between 0-100";
                    txtMark1.Focus();
                }
                else
                {

                    output = StudentMarkBl.StudentMarkUpdate(studentMark);
                    if (output > 0)
                    {
                        lblMessage.Text = "Student Detail Updated Successfully";
                        LoadStudents();
                    }
                    else
                    {
                        lblMessage.Text = "Please try again later";
                    }

                }

            }
            catch (FormatException ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }

        }
        private void ClearControl()
        {
            txtMark1.Text = "";
            txtMark2.Text = "";
            txtMark3.Text = "";
            txtStudentId.Text = "";
            txtStudentName.Text = "";
            lblMessage.Text = "";
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
                DataSet dsStudents = null;
                try
                {
                    dsStudents = StudentMarkBl.GetStudentsLike(txtNameSearch.Text);
                    if (dsStudents != null)
                    {

                        dgvStudent.DataSource = dsStudents.Tables[0];

                    }
                    else
                    {
                        lblMessage.Text = "No students Available";
                    }

                }
                catch (FormatException ex)
                {
                    lblMessage.Text = ex.Message.ToString();
                }
            
        }

        private void txtMark1_KeyDown(object sender, KeyEventArgs e)
        {
            flagMark1 = false;

            if(!txtMark1.Text.Contains(".") && countMark1 > 0)
            {
                countMark1--;
            }

            if((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 )||
                (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) ||
                ((e.KeyCode == Keys.Decimal || e.KeyCode ==Keys.OemPeriod) && countMark1 <1) ||
                e.KeyCode == Keys.Back)
            {
                flagMark1 = true;

                if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
                {
                    countMark1++;
                }
            }
        }

        private void txtMark1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!flagMark1)
            {
                e.Handled = true;  
            }
        }

        private void dgvStudent_SelectionChanged(object sender, EventArgs e)  //selected details from the grid will be displayed in the corresponding textbox field in the form 
        {
            string studentId, student_name;
            int mark1, mark2, mark3;

            if (dgvStudent.SelectedCells.Count > 0)
            {
                int Selectedrowindex = dgvStudent.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvStudent.Rows[Selectedrowindex];

                studentId = Convert.ToString(selectedRow.Cells["student_id"].Value);
                student_name = Convert.ToString(selectedRow.Cells["student_name"].Value);
                mark1=Convert.ToInt32(selectedRow.Cells["mark1"].Value);
                mark2 = Convert.ToInt32(selectedRow.Cells["mark2"].Value);
                mark3 = Convert.ToInt32(selectedRow.Cells["mark3"].Value);

                txtStudentId.Text = studentId;
                txtStudentName.Text = student_name;
                txtMark1.Text = mark1.ToString();
                txtMark2.Text = mark2.ToString();
                txtMark3.Text = mark3.ToString();
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

