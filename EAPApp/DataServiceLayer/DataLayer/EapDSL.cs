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
    public class EapDSL
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
                Console.Out.WriteLine("*** Error : EapDSL.cs:CollegeDetailsInsert", ex.Message.ToString());
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
                sql = sql + "(" + sqlnested + "))" ;
                //sql = sql + "" + collegeDetails.CourseSeat+ ")";
              

                con = DatabaseHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);

                output = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSL.cs:CollegeCourseInsert", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return output;

        }
        public static int StudentDetailsInsert(CandidateDetails candidateDetails)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                sql = "insert into candidate_details (candidate_10th_school,candidate_10th_percentage,candidate_12th_school,candidate_12th_percentage," +
                    "candiate_physics,candiate_chemistry,candiate_maths) values(";
              
                sql = sql + "'" + candidateDetails.CandidateSchoolName10 + "',";
                sql = sql  + candidateDetails.Candidatemark10 + ",";
                sql = sql + "'" + candidateDetails.CandidateSchoolName12 + "',";
                sql = sql  + candidateDetails.Candidatemark12 + ",";
                sql = sql + candidateDetails.CandidatePhysics + ",";
                sql = sql  + candidateDetails.CandidateChemistry + ",";
                sql = sql  + candidateDetails.CandidateMaths + ")";
              

                con = DatabaseHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);

                output = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSL.cs:StudentDetailsInsert", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return output;


        }
        public static int CandidateRegistrationInsert(CandidateDetails candidateDetails)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                sql = "insert into candidate_registration(candidate_id,candidate_name,candidate_gender,candidate_DOB," +
                      "candidate_phone,candidate_email,candidate_address) values(";

                sql = sql + "'" + candidateDetails.CandidateId + "',";
                sql = sql + "'" + candidateDetails.CandidateName + "',";
                sql = sql + "'" + candidateDetails.CandidateGender + "',";
                sql = sql + "'" + candidateDetails.CandidateDOB + "',";
                sql = sql + "'" + candidateDetails.CandidateNumber + "',";
                sql = sql + "'" + candidateDetails.CandidateEmail + "',";
                sql = sql + "'" + candidateDetails.CandidateAddress + "')";

                con = DatabaseHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);

                output = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSL.cs:CandidateRegistrationInsert", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }

            return output;

        }
        public static int StudentCoursePreferenceInsert(CandidateDetails candidateDetails)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                sql = "insert into candidate_preference(candidate_id,college_preference1,college_preference2,college_preference3,course_preference11,course_preference12,course_preference13,course_preference21,course_preference22,course_preference23,course_preference31,course_preference32,course_preference33) values(";
                sql = sql + "'" + candidateDetails.CandidateId + "',";
                sql = sql + "'" + candidateDetails.Collegeprefernce1 + "',";
                sql = sql + "'" + candidateDetails.Collegeprefernce2 + "',";
                sql = sql + "'" + candidateDetails.CollegePrefernce3 + "',";
                sql = sql + "'" + candidateDetails.CollegeCourse11+ "',";
                sql = sql + "'" + candidateDetails.CollegeCourse12 + "',";
                sql = sql + "'" + candidateDetails.CollegeCourse13 + "',";
                sql = sql + "'" + candidateDetails.CollegeCourse21 + "',";
                sql = sql + "'" + candidateDetails.CollegeCourse22 + "',";
                sql = sql + "'" + candidateDetails.CollegeCourse23 + "',";
                sql = sql + "'" + candidateDetails.CollegeCourse31 + "',";
                sql = sql + "'" + candidateDetails.CollegeCourse32 + "',";
                sql = sql + "'" + candidateDetails.CollegeCourse33 + "')";


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSL.cs:StudentCoursePreferenceInsert", ex.Message.ToString());
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
                Console.Out.WriteLine("*** Error : EapDSL.cs:CollegeDetailsUpdate()", ex.Message.ToString());
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
                Console.Out.WriteLine("*** Error : EapDSL.cs:CollegeDetailsUpdate()", ex.Message.ToString());
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
                Console.Out.WriteLine("*** Error : EapDSL.cs:GetCollegeIds()", ex.Message.ToString());
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
                Console.Out.WriteLine("*** Error : EapDSL.cs:GetCollegeDetailsUsingId()", ex.Message.ToString());
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
                Console.Out.WriteLine("*** Error : EapDSL.cs:GetCollegeDetails()", ex.Message.ToString());
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
                Console.Out.WriteLine("*** Error : EapDSL.cs:GetDataLike", ex.Message.ToString());
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
                Console.Out.WriteLine("*** Error : EapDSL.cs:CollegeDelete", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }


            return output;
        }
        public static DataTable CandidateLogin(string user, string password)
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            //DataSet dsLogin = null;
            DataTable dtLogin = null;


            try
            {
                //sql = "select count(*) as cnt from login_database"
                sql = "select candidate_id,candidate_dob from candidate_registration where candidate_id='" + user + "'and candidate_dob='" + password + "'";
                con = DatabaseHelper.GetConnection();
                con.Open();
                //dsLogin = new DataSet();
                dtLogin = new DataTable();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dtLogin);


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSL.cs:CandidateLogin()", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }

            return dtLogin;
        }

            public static DataSet LoadCollegePreference(string collegeName)
            {
                string sql = "";
                string nestedsql;
                SqlConnection con = null;
                SqlDataAdapter adapter = null;
                DataSet dsPreference = null;

                try
                {
                    string sql1="select college_id from college_details where college_name='" + collegeName + "'";
                    nestedsql = "select course_id from college_coures where college_id='" + sql1 + "'";
                    sql = "select course_name from course_details where course_id'"+nestedsql+"'";
                    con = DatabaseHelper.GetConnection();
                    con.Open();
                    dsPreference = new DataSet();
                    adapter = new SqlDataAdapter(sql, con);
                    adapter.Fill(dsPreference);


                }
                catch (Exception ex)
                {
                    Console.Out.WriteLine("*** Error : EapDSL.cs:LoadCollegePreference()", ex.Message.ToString());
                }
                finally
                {
                    con.Close();
                    adapter.Dispose();
                }

                return dsPreference;

            }

        }
    }

