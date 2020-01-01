using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataTransactionObject.DTO;
using DataServiceLayer.Helper;
using System.Data;

namespace DataServiceLayer.DataLayer
{
    public class EapDSLAdmin
    {
        public static int CollegeDetailsInsert(CollegeDetails collegeDetails)  //college insert
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                sql = "insert into college_details(college_id,college_name,total_seats,college_address,college_phone) values(";

                sql = sql + "'" + collegeDetails.CollegeID + "',";
                sql = sql + "'" + collegeDetails.CollegeName + "',";
                sql = sql + "" + collegeDetails.TotalSeats + ",";
                sql = sql + "'" + collegeDetails.CollegeAddress + "',";
                sql = sql + "'" + collegeDetails.CollegePhone + "')";

                con = DatabaseHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);

                output = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSLAdmin.cs:CollegeDetailsInsert", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return output;

        }
        public static int CollegeCourseInsert(CollegeDetails collegeDetails)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                string sqlnested = "select course_id from course_details where course_name='" + collegeDetails.CourseName + "'";
                sql = "insert into college_coures(collegeid,courseid) values(";

                sql = sql + "'" + collegeDetails.CollegeID + "',";
                //sql = sql + "'" + collegeDetails.CourseId + "')";
                sql = sql + "(" + sqlnested + "))";
                //sql = sql + "" + collegeDetails.CourseSeat+ ")";


                con = DatabaseHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);

                output = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSLAdmin.cs:CollegeCourseInsert", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return output;

        }
        public static int CollegeDetailsUpdate(CollegeDetails collegeDetails)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                sql = "update college_details set ";
                // sql = sql + "college_id ='" + collegeDetails.CollegeID + "',";
                sql = sql + "college_name ='" + collegeDetails.CollegeName + "',";
                sql = sql + "total_seats ='" + collegeDetails.TotalSeats + "',";
                sql = sql + "college_address ='" + collegeDetails.CollegeAddress + "',";
                sql = sql + "college_phone =" + collegeDetails.CollegePhone + " ";

                sql = sql + "where college_id = '" + collegeDetails.CollegeID + "'";

                con = DatabaseHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);

                output = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSLAdmin.cs:CollegeDetailsUpdate()", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return output;
        }

        public static int CollegeCourseUpdate(CollegeDetails collegeDetails)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                string sqlnested = "select course_id from course_details where course_name='" + collegeDetails.CourseName + "'";
                sql = "update college_coures set ";


                sql = sql + "(" + sqlnested + ")";
                sql = sql + "where college_id = '" + collegeDetails.CollegeID + "'";

                con = DatabaseHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);

                output = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSLAdmin.cs:CollegeDetailsUpdate()", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return output;
        }

        public static DataSet GetCollegeIds()
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsCollegeIds = null;

            try
            {
                sql = "select college_id  from college_details";
                con = DatabaseHelper.GetConnection();
                con.Open();
                dsCollegeIds = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsCollegeIds);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSLAdmin.cs:GetCollegeIds()", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }
            return dsCollegeIds;
        }

        public static CollegeDetails GetCollegeDetailsUsingId(string collegeId)
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsCollegeDetails = null;
            CollegeDetails collegeDetails = null;


            try
            {
                sql = "select *  from college_details where college_id='" + collegeId + "'";
                string s = "select courseid from college_coures where collegeid'" + collegeId + "'";
                string t = "select course_name from course_details where course_id'" + s + "'";
                con = DatabaseHelper.GetConnection();
                con.Open();
                dsCollegeDetails = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsCollegeDetails);
                Object[] Data = null;

                if (dsCollegeDetails.Tables[0].Rows.Count > 0)
                {
                    Data = dsCollegeDetails.Tables[0].Rows[0].ItemArray;
                    collegeDetails = new CollegeDetails();
                    collegeDetails.CollegeID = Data[0].ToString();
                    collegeDetails.CollegeName = Data[1].ToString();
                    collegeDetails.TotalSeats = Convert.ToInt32(Data[2].ToString());
                    collegeDetails.CollegeAddress = Data[3].ToString();
                    collegeDetails.CollegePhone = Convert.ToInt64(Data[4].ToString());
                    collegeDetails.CourseName = Data[5].ToString();



                }
                


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSLAdmin.cs:GetCollegeDetailsUsingId()", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }
            return collegeDetails;
        }
        public static DataSet GetCollegeDetails()
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsCollege = null;

            try
            {
                sql = "select * from college_details";
                con = DatabaseHelper.GetConnection();
                con.Open();
                dsCollege = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsCollege);


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSLAdmin.cs:GetCollegeDetails()", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }

            return dsCollege;

        }
        public static DataSet GetDataLike(string likeCollegeName)
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsData = null;

            try
            {
                sql = "select * from college_details where college_name like '" + likeCollegeName + "%'";
                con = DatabaseHelper.GetConnection();
                con.Open();
                dsData = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsData);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSLAdmin.cs:GetDataLike", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }
            return dsData;
        }
        public static int CollegeDelete(string collegeName)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                sql = "delete from college_details where college_name='" + collegeName + "'";



                con = DatabaseHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);

                output = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSLAdmin.cs:CollegeDelete", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }


            return output;
        }
        public static DataSet GetCollegeName()
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsCollegeName = null;

            try
            {
                sql = "select college_name  from college_details";
                con = DatabaseHelper.GetConnection();
                con.Open();
                dsCollegeName = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsCollegeName);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSLAdmin.cs:GetCollegeName()", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }
            return dsCollegeName;
        }
    }
}
