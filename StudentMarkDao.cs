using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using cs_Week5.dto;
using System.Data;

namespace cs_Week5.dao
{
    class StudentMarkDao
    {

        public static int StudentMarkInsert(StudentMark studentMark)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                sql = "insert into student_mark(student_id,student_name,mark1,mark2,mark3,total,result) values(";
                sql = sql + "'" + studentMark.StudentId + "',";
                sql = sql + "'" + studentMark.StudentName + "',";
                sql = sql + studentMark.Mark1 + ",";
                sql = sql + studentMark.Mark2 + ",";
                sql = sql + studentMark.Mark3 + ",";
                sql = sql + studentMark.Total + ",";
                sql = sql + "'" + studentMark.Result + "')";


                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);

                output = cmd.ExecuteNonQuery();
                

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : StudentMarkDao.cs:StudentMarkInsert", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
           

            return output;
        }
        public static int StudentMarkUpdate(StudentMark studentMark)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                sql = "update  student_mark set ";
                sql = sql +"student_name = '" + studentMark.StudentName + "',";
                sql = sql + "mark1 = "+studentMark.Mark1 + ",";
                sql = sql + "mark2 = " + studentMark.Mark1 + ",";
                sql = sql + "mark3 = " + studentMark.Mark2 + ",";
                sql = sql + "total = " + studentMark.Total + ",";
                sql = sql + "result='" + studentMark.Result+ "' ";
                sql = sql + "where student_id ='" + studentMark.StudentId + "'";







              


                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);

                output = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : StudentMarkDao.cs:StudentMarkDelete", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }


            return output;
        }
        public static int StudentMarkDelete(String studentId)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                sql = "delete from student_mark where student_id='" + studentId + "'";
                


                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);

                output = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : StudentMarkDao.cs:StudentMarkDelete", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }


            return output;
        }
        public static DataSet GetStudentIds()
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsStudents = null;

            try
            {
                sql = "select student_id from student_mark";
                con = DBHelper.GetConnection();
                con.Open();
                dsStudents = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsStudents);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : StudentMarkDao.cs:StudentMarkInsert", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }
            return dsStudents;
        }

        public static DataSet GetStudents()
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsStudents = null;

            try
            {
                sql = "select * from student_mark";
                con = DBHelper.GetConnection();
                con.Open();
                dsStudents = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsStudents);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : StudentMarkDao.cs:GetStudents", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }
            return dsStudents;
        }
        public static StudentMark GetStudentById(string studentId)
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsStudent = null;
            StudentMark studentMark= null;

            try
            {
                sql = "select *  from student_mark where student_id='"+studentId+"'"; 
                con = DBHelper.GetConnection();
                con.Open();
                dsStudent = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsStudent);
                Object []Data = null;

                if (dsStudent.Tables[0].Rows.Count > 0)
                {
                    Data = dsStudent.Tables[0].Rows[0].ItemArray;
                    studentMark = new StudentMark();
                    studentMark.StudentId = Data[0].ToString();
                    studentMark.StudentName = Data[1].ToString();
                    studentMark.Mark1 = Convert.ToInt32(Data[2].ToString());
                    studentMark.Mark2 = Convert.ToInt32(Data[3].ToString());
                    studentMark.Mark3 = Convert.ToInt32(Data[4].ToString());
                    studentMark.Total = Convert.ToInt32(Data[5].ToString());
                    studentMark.Result = Data[6].ToString();


                }

             

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : StudentMarkDao.cs:StudentMarkInsert", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }
            return studentMark;
        }
        public static string GetLastStudentId()
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsStudent = null;
            
            string lastStudentId = null;
            Object[] Data = null;

            try
            {
                sql = " select student_id  from student_mark order by student_id desc";
                con = DBHelper.GetConnection();
                con.Open();
                dsStudent = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsStudent);
               

                if (dsStudent.Tables[0].Rows.Count > 0)
                {
                    Data = dsStudent.Tables[0].Rows[0].ItemArray;
                    lastStudentId = Data[0].ToString();
                   


                }



            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : StudentMarkDao.cs:GetLastStudentId", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }
            return lastStudentId;
        }
        public static DataSet GetStudentsLike(string likeName)
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsStudents = null;

            try
            {
                sql = "select * from student_mark where student_name like '" +likeName+ "%'";
                con = DBHelper.GetConnection();
                con.Open();
                dsStudents = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsStudents);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : StudentMarkDao.cs:GetStudentsLik", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }
            return dsStudents;
        }
    }
}
