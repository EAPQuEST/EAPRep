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
        //public static int CollegeDetailsInsert(CollegeDetails collegeDetails)  //college insert
        //{
        //    int output = 0;
        //    string sql = "";
        //    SqlConnection con = null;
        //    SqlCommand cmd = null;
        //    try
        //    {
        //        sql = "insert into college_details(college_id,college_name,total_seats,college_address,college_phone) values(";
               
        //        sql = sql + "'" + collegeDetails.CollegeID + "',";
        //        sql = sql + "'" + collegeDetails.CollegeName + "',";
        //        sql = sql + "" + collegeDetails.TotalSeats + ",";
        //        sql = sql + "'" + collegeDetails.CollegeAddress + "',";   
        //        sql = sql + "'" + collegeDetails.CollegePhone + "')";

        //        con = DatabaseHelper.GetConnection();
        //        con.Open();
        //        cmd = new SqlCommand(sql, con);

        //        output = cmd.ExecuteNonQuery();

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Out.WriteLine("*** Error : EapDSL.cs:CollegeDetailsInsert", ex.Message.ToString());
        //    }
        //    finally
        //    {
        //        con.Close();
        //        cmd.Dispose();
        //    }
        //    return output;

        //}
        //public static int CollegeCourseInsert(CollegeDetails collegeDetails)
        //{
        //    int output = 0;
        //    string sql = "";
        //    SqlConnection con = null;
        //    SqlCommand cmd = null;
        //    try
        //    {
        //        string sqlnested = "select course_id from course_details where course_name='" + collegeDetails.CourseName + "'";
        //        sql = "insert into college_coures(collegeid,courseid) values(";

        //        sql = sql + "'" + collegeDetails.CollegeID + "',";
        //        //sql = sql + "'" + collegeDetails.CourseId + "')";
        //        sql = sql + "(" + sqlnested + "))" ;
        //        //sql = sql + "" + collegeDetails.CourseSeat+ ")";
              

        //        con = DatabaseHelper.GetConnection();
        //        con.Open();
        //        cmd = new SqlCommand(sql, con);

        //        output = cmd.ExecuteNonQuery();

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Out.WriteLine("*** Error : EapDSL.cs:CollegeCourseInsert", ex.Message.ToString());
        //    }
        //    finally
        //    {
        //        con.Close();
        //        cmd.Dispose();
        //    }
        //    return output;

        //}
        public static int StudentDetailsInsert(CandidateDetails candidateDetails)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                sql = "insert into candidate_details (candidate_id,candidate_10th_school,candidate_10th_percentage,candidate_12th_school,candidate_12th_percentage," +
                    "candiate_physics,candiate_chemistry,candiate_maths,reservation) values(";
                sql = sql + "'" + LoginInfo.userID + "',";
                sql = sql + "'" + candidateDetails.CandidateSchoolName10 + "',";
                sql = sql  + candidateDetails.Candidatemark10 + ",";
                sql = sql + "'" + candidateDetails.CandidateSchoolName12 + "',";
                sql = sql  + candidateDetails.Candidatemark12 + ",";
                sql = sql + candidateDetails.CandidatePhysics + ",";
                sql = sql  + candidateDetails.CandidateChemistry + ",";
                sql = sql  + candidateDetails.CandidateMaths + ",";
                sql = sql + "'" + candidateDetails.Reservation + "')";


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
        //public static int CollegeDetailsUpdate(CollegeDetails collegeDetails)
        //{
        //    int output = 0;
        //    string sql = "";
        //    SqlConnection con = null;
        //    SqlCommand cmd = null;

        //    try
        //    {
        //        sql = "update college_details set ";
        //       // sql = sql + "college_id ='" + collegeDetails.CollegeID + "',";
        //        sql = sql + "college_name ='" + collegeDetails.CollegeName + "',";
        //        sql = sql + "total_seats ='" + collegeDetails.TotalSeats + "',";
        //        sql = sql + "college_address ='" + collegeDetails.CollegeAddress + "',";
        //        sql = sql + "college_phone =" + collegeDetails.CollegePhone + " ";
                
        //        sql = sql + "where college_id = '" + collegeDetails.CollegeID + "'";

        //        con = DatabaseHelper.GetConnection();
        //        con.Open();
        //        cmd = new SqlCommand(sql, con);

        //        output = cmd.ExecuteNonQuery();


        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Out.WriteLine("*** Error : EapDSL.cs:CollegeDetailsUpdate()", ex.Message.ToString());
        //    }
        //    finally
        //    {
        //        con.Close();
        //        cmd.Dispose();
        //    }
        //    return output;
        //}

        //public static int CollegeCourseUpdate(CollegeDetails collegeDetails)
        //{
        //    int output = 0;
        //    string sql = "";
        //    SqlConnection con = null;
        //    SqlCommand cmd = null;

        //    try
        //    {
        //        string sqlnested = "select course_id from course_details where course_name='" + collegeDetails.CourseName + "'";
        //        sql = "update college_coures set ";
               
           
        //        sql = sql + "(" + sqlnested + ")";
        //        sql = sql + "where college_id = '" + collegeDetails.CollegeID + "'";

        //        con = DatabaseHelper.GetConnection();
        //        con.Open();
        //        cmd = new SqlCommand(sql, con);

        //        output = cmd.ExecuteNonQuery();


        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Out.WriteLine("*** Error : EapDSL.cs:CollegeDetailsUpdate()", ex.Message.ToString());
        //    }
        //    finally
        //    {
        //        con.Close();
        //        cmd.Dispose();
        //    }
        //    return output;
        //}

        //public static DataSet GetCollegeIds()
        //{
        //    string sql = "";
        //    SqlConnection con = null;
        //    SqlDataAdapter adapter = null;
        //    DataSet dsCollegeIds = null;

        //    try
        //    {
        //        sql = "select college_id  from college_details";
        //        con = DatabaseHelper.GetConnection();
        //        con.Open();
        //        dsCollegeIds = new DataSet();
        //        adapter = new SqlDataAdapter(sql, con);
        //        adapter.Fill(dsCollegeIds);

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Out.WriteLine("*** Error : EapDSL.cs:GetCollegeIds()", ex.Message.ToString());
        //    }
        //    finally
        //    {
        //        con.Close();
        //        adapter.Dispose();
        //    }
        //    return dsCollegeIds;
        //}

        //public static CollegeDetails GetCollegeDetailsUsingId(string collegeId)
        //{
        //    string sql = "";
        //    SqlConnection con = null;
        //    SqlDataAdapter adapter = null;
        //    DataSet dsCollegeDetails = null;
        //    CollegeDetails collegeDetails = null;
           

        //    try
        //    {
        //        sql = "select *  from college_details where college_id='" + collegeId + "'";
        //        string s = "select courseid from college_coures where collegeid'" + collegeId + "'";
        //        string t = "select course_name from course_details where course_id'" + s + "'";
        //        con = DatabaseHelper.GetConnection();
        //        con.Open();
        //        dsCollegeDetails = new DataSet();
        //        adapter = new SqlDataAdapter(sql, con);
        //        adapter.Fill(dsCollegeDetails);
        //        Object[] Data = null;

        //        if (dsCollegeDetails.Tables[0].Rows.Count > 0)
        //        {
        //            Data = dsCollegeDetails.Tables[0].Rows[0].ItemArray;
        //            collegeDetails = new CollegeDetails();
        //            collegeDetails.CollegeID = Data[0].ToString();
        //            collegeDetails.CollegeName = Data[1].ToString();
        //            collegeDetails.TotalSeats = Convert.ToInt32(Data[2].ToString());
        //            collegeDetails.CollegeAddress = Data[3].ToString();
        //            collegeDetails.CollegePhone = Convert.ToInt64(Data[4].ToString());
        //            collegeDetails.CourseName = Data[5].ToString();
                    


        //        }



        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Out.WriteLine("*** Error : EapDSL.cs:GetCollegeDetailsUsingId()", ex.Message.ToString());
        //    }
        //    finally
        //    {
        //        con.Close();
        //        adapter.Dispose();
        //    }
        //    return collegeDetails;
        //}
        //public static DataSet GetCollegeDetails()
        //{
        //    string sql = "";
        //    SqlConnection con = null;
        //    SqlDataAdapter adapter = null;
        //    DataSet dsCollege = null;

        //    try
        //    {
        //        sql = "select * from college_details";
        //        con = DatabaseHelper.GetConnection();
        //        con.Open();
        //        dsCollege = new DataSet();
        //        adapter = new SqlDataAdapter(sql, con);
        //        adapter.Fill(dsCollege);


        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Out.WriteLine("*** Error : EapDSL.cs:GetCollegeDetails()", ex.Message.ToString());
        //    }
        //    finally
        //    {
        //        con.Close();
        //        adapter.Dispose();
        //    }

        //    return dsCollege;

        //}
        //public static DataSet GetDataLike(string likeCollegeName)
        //{
        //    string sql = "";
        //    SqlConnection con = null;
        //    SqlDataAdapter adapter = null;
        //    DataSet dsData = null;

        //    try
        //    {
        //        sql = "select * from college_details where college_name like '" + likeCollegeName + "%'";
        //        con = DatabaseHelper.GetConnection();
        //        con.Open();
        //        dsData = new DataSet();
        //        adapter = new SqlDataAdapter(sql, con);
        //        adapter.Fill(dsData);

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Out.WriteLine("*** Error : EapDSL.cs:GetDataLike", ex.Message.ToString());
        //    }
        //    finally
        //    {
        //        con.Close();
        //        adapter.Dispose();
        //    }
        //    return dsData;
        //}
        //public static int CollegeDelete(string collegeName)
        //{
        //    int output = 0;
        //    string sql = "";
        //    SqlConnection con = null;
        //    SqlCommand cmd = null;

        //    try
        //    {
        //        sql = "delete from college_details where college_name='" + collegeName + "'";



        //        con = DatabaseHelper.GetConnection();
        //        con.Open();
        //        cmd = new SqlCommand(sql, con);

        //        output = cmd.ExecuteNonQuery();


        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Out.WriteLine("*** Error : EapDSL.cs:CollegeDelete", ex.Message.ToString());
        //    }
        //    finally
        //    {
        //        con.Close();
        //        cmd.Dispose();
        //    }


        //    return output;
        //}
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
                sql = "select candidate_id,candidate_dob from candidate_registration where candidate_id='" + user + "'and candidate_DOB='" + password + "'";
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
                //CollegeDetails collegeDetails = null;


            try
            {
                //select course_name from course_details where course_id IN(SELECT  college_coures.courseid
                //   FROM college_coures
                //  WHERE collegeid = 'jtmgm')
                //string sql1="select college_id from college_details where college_name='" + collegeName + "'";
                //nestedsql = "select courseid from college_coures where collegeid=";
                //nestedsql = nestedsql + "(" + sql1 + ")";
                //sql = "select course_name from course_details where course_id=";
                //sql=sql + "(" + nestedsql + ")";
                    sql = "select course_name from course_details where course_id IN(SELECT  college_coures.courseid FROM college_coures WHERE collegeid ='" + collegeName + "')";
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
        public static CandidateDetails LoadCandidateDetails()
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsCandidate = null;
            CandidateDetails candidateDetails = null;
            int count = 0;

            try
            {
                sql ="select * from candidate_details where candidate_id='"+LoginInfo.userID+"'";
                con = DatabaseHelper.GetConnection();
                con.Open();
                dsCandidate = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsCandidate);
                Object[] Data = null;
                count = dsCandidate.Tables[0].Rows.Count;
                if (count>0)
                {
                    Data = dsCandidate.Tables[0].Rows[0].ItemArray;
                    candidateDetails = new CandidateDetails();
                    candidateDetails.CandidateSchoolName10 = Data[0].ToString();
                    candidateDetails.Candidatemark10 = Convert.ToInt32(Data[1].ToString());
                    candidateDetails.CandidateSchoolName12 = Data[2].ToString();
                    candidateDetails.Candidatemark12 = Convert.ToInt32(Data[3].ToString());
                    candidateDetails.CandidatePhysics = Convert.ToInt32(Data[4].ToString());
                    candidateDetails.CandidateChemistry = Convert.ToInt32(Data[5].ToString());
                    candidateDetails.CandidateMaths = Convert.ToInt32(Data[6].ToString());
                    candidateDetails.CandidateId = Data[7].ToString();
                    candidateDetails.Reservation = Data[8].ToString();
                    
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



            return candidateDetails;

        }


        public static CandidateDetails ViewAllotmentResult()
        {
            string sql1 = "";
            string sql2 = "";
            string sql3 = "";
            SqlConnection con = null;
            SqlDataAdapter adapter1 = null;
            SqlDataAdapter adapter2 = null;
            SqlDataAdapter adapter3 = null;
            DataSet dsCandidate = null;
            DataSet dsCandidate2 = null;
            DataSet dsCandidate3 = null;
            CandidateDetails candidateDetails = null;
            int count = 0;

            try
            {
                sql1 = "select college_id,course_id from new1allotment where candidate_id='" + LoginInfo.userID + "' and status='Alloted'";
                con = DatabaseHelper.GetConnection();
                con.Open();
                
                adapter1 = new SqlDataAdapter(sql1, con);
                dsCandidate = new DataSet();
                adapter1.Fill(dsCandidate);
                Object[] Data = null;
                Object[] Data2 = null;
                Object[] Data3 = null;
                count = dsCandidate.Tables[0].Rows.Count;
                if (count > 0)
                {
                    candidateDetails = new CandidateDetails();
                    
                    Data = dsCandidate.Tables[0].Rows[0].ItemArray;
                    candidateDetails.College_ID = Data[0].ToString();
                    candidateDetails.Course_ID = Data[1].ToString();

                    sql2 = "select college_name from college_details where college_id='"+candidateDetails.College_ID+ "'";
                    dsCandidate2 = new DataSet();
                    adapter2 = new SqlDataAdapter(sql2, con);
                    adapter2.Fill(dsCandidate2);
                   
                    Data2 = dsCandidate2.Tables[0].Rows[0].ItemArray;

                    candidateDetails.College_Name = Data2[0].ToString();

                   

                    sql3 = "select course_name from course_details where course_id='"+candidateDetails.Course_ID+"'";
                    dsCandidate3 = new DataSet();
                    adapter3 = new SqlDataAdapter(sql3, con);
                    adapter3.Fill(dsCandidate3);
                    Data3 = dsCandidate3.Tables[0].Rows[0].ItemArray;

                    candidateDetails.Course_Name = Data3[0].ToString();



                }

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSL.cs:ViewAllotmentResult()", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter1.Dispose();
                adapter2.Dispose();
                adapter3.Dispose();
            }



            return candidateDetails;

        }


    }
    }

