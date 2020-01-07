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
       


        //to change password if the user credentials entered is correct
        public static int AdminNewPassword(string username, string password)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                sql = "update password_details  set ";

                sql = sql + "password ='" + password + "'";
                sql = sql + " where username = '" + username + "'and user_type='admin'";

                con = DatabaseHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);

                output = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSL.cs:AdminNewPassword", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return output;


        }


        //to check the current password of the admin is correct or not

        public static DataTable AdminChangePassword(string password)
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            //DataSet dsLogin = null;
            DataTable dtLogin = null;


            try
            {
                //sql = "select count(*) as cnt from login_database"
                sql = "select password from password_details where password='" + password + "'and user_type='admin'";
                con = DatabaseHelper.GetConnection();
                con.Open();
                //dsLogin = new DataSet();
                dtLogin = new DataTable();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dtLogin);


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSL.cs:AdminChangePassword()", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }

            return dtLogin;
        }


        //to insert the details of college into the database

        public static int CollegeDetailsInsert(CollegeDetails collegeDetails)  //college insert
        {
            int output = 0;
            string sql = "";
            string sqlPassword = "";
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlCommand cmd1= null;
            try
            {
                sql = "insert into college_details(college_id,college_name,college_address,college_phone) values(";

                sql = sql + "'" + collegeDetails.CollegeID + "',";
                sql = sql + "'" + collegeDetails.CollegeName + "',";

                sql = sql + "'" + collegeDetails.CollegeAddress + "',";
                sql = sql + "'" + collegeDetails.CollegePhone + "')";

                sqlPassword = "insert into password_details(username,password,user_type) values(";
                sqlPassword = sqlPassword + "'" + collegeDetails.CollegeID + "',";
                sqlPassword = sqlPassword + "'" + collegeDetails.CollegeID + "',";
                sqlPassword = sqlPassword+"'college')";


                con = DatabaseHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd1 = new SqlCommand(sqlPassword, con);
                
                output = cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSLAdmin.cs:CollegeDetailsInsert", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
                cmd1.Dispose();
            }
            return output;

        }


        //check user credentials for the admin to login
        public static DataTable AdminLogin(string user, string password)
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            //DataSet dsLogin = null;
            DataTable dtLogin = null;


            try
            {
                //sql = "select count(*) as cnt from login_database"
                sql = "select username,password from password_details where username='" + user + "'and password='" + password + "'and user_type='admin'";
                con = DatabaseHelper.GetConnection();
                con.Open();
                //dsLogin = new DataSet();
                dtLogin = new DataTable();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dtLogin);


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSL.cs:AdminLogin()", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }

            return dtLogin;
        }



        //to get the name of the course in a particular college


        public static DataSet GetCourseName(string collegeName)
        {
            string sql = "";
           // string nestedsql;
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsCourseName = null;
          


            try
            {
   
                sql = "select course_name from course_details where course_id IN(SELECT  college_coures.courseid FROM college_coures WHERE collegeid IN(select college_details.college_id FROM college_details where college_name='" + collegeName + "'))";


                con = DatabaseHelper.GetConnection();
                con.Open();
                dsCourseName = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsCourseName);


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSL.cs:GetCourseName()", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }

            return dsCourseName;

        }


        //to view all the details of all the college in the grid view
        public static DataSet ViewCollegeList()
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;


            DataSet dsCollegeList = null;

            try
            {
                sql = "SELECT college_coures.collegeid,college_details.college_name,college_coures.courseid," +
                    "college_details.college_phone,college_details.college_address FROM college_details " +
                    "JOIN college_coures ON college_details.college_id = college_coures.collegeid ORDER BY " +
                    "college_coures.collegeid ASC";
                con = DatabaseHelper.GetConnection();
                con.Open();
                dsCollegeList = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsCollegeList);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*****Error : EapDSLAdmin.cs::ViewCollegeList", ex.Message.ToString());

            }
            finally
            {
                con.Close();
                adapter.Dispose();

            }
            return dsCollegeList;
        }

        //insert the courses available in allotment

        public static int CollegeCourseInsert(CollegeDetails collegeDetails)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                string sqlnested = "select course_id from course_details where course_name='" + collegeDetails.CourseName + "'";
                sql = "insert into college_coures(collegeid,courseid,numberof_seats,sc_st,obc,sports) values(";

                sql = sql + "'" + collegeDetails.CollegeID + "',";
                //sql = sql + "'" + collegeDetails.CourseId + "')";
                sql = sql + "(" + sqlnested + ")";
                sql = sql+"45,";
                sql = sql + "5,";
                sql = sql + "5,";
                sql = sql + "5)";
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

        //update the college details
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
                //sql = sql + "college_name ='" + collegeDetails.CollegeName + "',";
                
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

        //add or delete courses in a college
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


        //to get the college id
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


        //to get the details of the college using college id
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
                //string s = "select courseid from college_coures where collegeid'" + collegeId + "'";
               // string t = "select course_name from course_details where course_id'" + s + "'";
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
                   // collegeDetails.TotalSeats = Convert.ToInt32(Data[2].ToString());
                    collegeDetails.CollegeAddress = Data[2].ToString();
                    collegeDetails.CollegePhone = Convert.ToInt64(Data[3].ToString());
                    //collegeDetails.CourseName = Data[5].ToString();



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


        //to get college details
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

        //get college details of the input college name
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

        //to delete a college from the database
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


        public static int CourseDelete(string courseName)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                sql = "delete from college_coures where courseid IN(select course_id from course_details where course_name='" + courseName + "')";



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


        //to get all the available courses
        public static DataSet GetCourseShowAll()
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsCollegeName = null;

            try
            {
                sql = "select course_name  from course_details";
                con = DatabaseHelper.GetConnection();
                con.Open();
                dsCollegeName = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsCollegeName);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSLAdmin.cs:GetCollegeShowAll()", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }
            return dsCollegeName;
        }


        public static int CourseAdd(CollegeDetails collegeDetails)
        {

            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {

                string sqlnested = "(select college_id from college_details where college_name = '" + collegeDetails.CollegeName + "')";
                string s = "(select course_id from course_details where course_name = '" + collegeDetails.CourseName + "')";
                sql = "insert into college_coures(collegeid, courseid) values";


                sql = sql + "(" + sqlnested + "," + s + ")";


                con = DatabaseHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);

                output = cmd.ExecuteNonQuery();





            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSLAdmin.cs:CollegeAdd", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }


            return output;
        }


        //to get college name and college id

        public static DataSet GetCollegeName()
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsCollegeName = null;

            try
            {
                sql = "select college_name,college_id  from college_details";
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

        //to generate allotment of the candidates
        public static int GenerateAllotment(CandidateDetails candidateDetails)
        {
            int output = 0;
            string sql = "";
            string sql1 = "";
            string sql2 = "";
            string sql3 = "";
            string sql4 = "";
            string sql5 = "";
            string sql6 = "";
            string sql7 = "";
            string sql8 = "";

            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlCommand cmd1 = null;
            SqlCommand cmd2 = null;
            SqlCommand cmd3 = null;
            SqlCommand cmd4 = null;
            SqlCommand cmd5 = null;
            SqlCommand cmd6 = null;
            SqlCommand cmd7 = null;
            SqlCommand cmd8 = null;


            try
            {
                sql = "insert into allotment(candidate_id,entrance_id,reservation,total_marks,college_id,course_id,status) values(";
                sql = sql + "'" + LoginInfo.userID + "',";
                sql = sql + "'" + candidateDetails.RegisterNumber + "',";
                sql = sql + "(select reservation from candidate_details where candidate_id='" + LoginInfo.userID + "'),";
                sql = sql + "(select candiate_physics+candiate_chemistry+candiate_maths+'" + candidateDetails.Total + "'from candidate_details where candidate_id='" + LoginInfo.userID + "'),";
                sql = sql + "(select college_id from college_details where college_name='" + candidateDetails.Collegeprefernce1 + "'),";
                sql = sql + "(select course_id from course_details where course_name='" + candidateDetails.CollegeCourse11 + "'),";
                sql = sql + "'waitlist')";


                sql1 = "insert into allotment(candidate_id,entrance_id,reservation,total_marks,college_id,course_id,status) values(";
                sql1 = sql1 + "'" + LoginInfo.userID + "',";
                sql1 = sql1 + "'" + candidateDetails.RegisterNumber + "',";
                sql1 = sql1 + "(select reservation from candidate_details where candidate_id='" + LoginInfo.userID + "'),";
                sql1 = sql1 + "(select candiate_physics+candiate_chemistry+candiate_maths+'" + candidateDetails.Total + "'from candidate_details where candidate_id='" + LoginInfo.userID + "'),";
                sql1 = sql1 + "(select college_id from college_details where college_name='" + candidateDetails.Collegeprefernce1 + "'),";
                sql1 = sql1 + "(select course_id from course_details where course_name='" + candidateDetails.CollegeCourse12 + "'),";
                sql1 = sql1 + "'waitlist')";

                sql2 = "insert into allotment(candidate_id,entrance_id,reservation,total_marks,college_id,course_id,status) values(";
                sql2 = sql2 + "'" + LoginInfo.userID + "',";
                sql2 = sql2 + "'" + candidateDetails.RegisterNumber + "',";
                sql2 = sql2 + "(select reservation from candidate_details where candidate_id='" + LoginInfo.userID + "'),";
                sql2 = sql2 + "(select candiate_physics+candiate_chemistry+candiate_maths+'" + candidateDetails.Total + "'from candidate_details where candidate_id='" + LoginInfo.userID + "'),";
                sql2 = sql2 + "(select college_id from college_details where college_name='" + candidateDetails.Collegeprefernce1 + "'),";
                sql2 = sql2 + "(select course_id from course_details where course_name='" + candidateDetails.CollegeCourse13 + "'),";
                sql2 = sql2 + "'waitlist')";

                sql3 = "insert into allotment(candidate_id,entrance_id,reservation,total_marks,college_id,course_id,status) values(";
                sql3 = sql3 + "'" + LoginInfo.userID + "',";
                sql3 = sql3 + "'" + candidateDetails.RegisterNumber + "',";
                sql3 = sql3 + "(select reservation from candidate_details where candidate_id='" + LoginInfo.userID + "'),";
                sql3 = sql3 + "(select candiate_physics+candiate_chemistry+candiate_maths+'" + candidateDetails.Total + "'from candidate_details where candidate_id='" + LoginInfo.userID + "'),";
                sql3 = sql3 + "(select college_id from college_details where college_name='" + candidateDetails.Collegeprefernce2 + "'),";
                sql3 = sql3 + "(select course_id from course_details where course_name='" + candidateDetails.CollegeCourse21 + "'),";
                sql3 = sql3 + "'waitlist')";

                sql4 = "insert into allotment(candidate_id,entrance_id,reservation,total_marks,college_id,course_id,status) values(";
                sql4 = sql4 + "'" + LoginInfo.userID + "',";
                sql4 = sql4 + "'" + candidateDetails.RegisterNumber + "',";
                sql4 = sql4 + "(select reservation from candidate_details where candidate_id='" + LoginInfo.userID + "'),";
                sql4 = sql4 + "(select candiate_physics+candiate_chemistry+candiate_maths+'" + candidateDetails.Total + "'from candidate_details where candidate_id='" + LoginInfo.userID + "'),";
                sql4 = sql4 + "(select college_id from college_details where college_name='" + candidateDetails.Collegeprefernce2 + "'),";
                sql4 = sql4 + "(select course_id from course_details where course_name='" + candidateDetails.CollegeCourse22 + "'),";
                sql4 = sql4 + "'waitlist')";

                sql5 = "insert into allotment(candidate_id,entrance_id,reservation,total_marks,college_id,course_id,status) values(";
                sql5 = sql5 + "'" + LoginInfo.userID + "',";
                sql5 = sql5 + "'" + candidateDetails.RegisterNumber + "',";
                sql5 = sql5 + "(select reservation from candidate_details where candidate_id='" + LoginInfo.userID + "'),";
                sql5 = sql5 + "(select candiate_physics+candiate_chemistry+candiate_maths+'" + candidateDetails.Total + "'from candidate_details where candidate_id='" + LoginInfo.userID + "'),";
                sql5 = sql5 + "(select college_id from college_details where college_name='" + candidateDetails.Collegeprefernce2 + "'),";
                sql5 = sql5 + "(select course_id from course_details where course_name='" + candidateDetails.CollegeCourse23 + "'),";
                sql5 = sql5 + "'waitlist')";

                sql6 = "insert into allotment(candidate_id,entrance_id,reservation,total_marks,college_id,course_id,status) values(";
                sql6 = sql6 + "'" + LoginInfo.userID + "',";
                sql6 = sql6 + "'" + candidateDetails.RegisterNumber + "',";
                sql6 = sql6 + "(select reservation from candidate_details where candidate_id='" + LoginInfo.userID + "'),";
                sql6 = sql6 + "(select candiate_physics+candiate_chemistry+candiate_maths+'" + candidateDetails.Total + "'from candidate_details where candidate_id='" + LoginInfo.userID + "'),";
                sql6 = sql6 + "(select college_id from college_details where college_name='" + candidateDetails.CollegePrefernce3 + "'),";
                sql6 = sql6 + "(select course_id from course_details where course_name='" + candidateDetails.CollegeCourse31 + "'),";
                sql6 = sql6 + "'waitlist')";

                sql7 = "insert into allotment(candidate_id,entrance_id,reservation,total_marks,college_id,course_id,status) values(";
                sql7 = sql7 + "'" + LoginInfo.userID + "',";
                sql7 = sql7 + "'" + candidateDetails.RegisterNumber + "',";
                sql7 = sql7 + "(select reservation from candidate_details where candidate_id='" + LoginInfo.userID + "'),";
                sql7 = sql7 + "(select candiate_physics+candiate_chemistry+candiate_maths+'" + candidateDetails.Total + "'from candidate_details where candidate_id='" + LoginInfo.userID + "'),";
                sql7 = sql7 + "(select college_id from college_details where college_name='" + candidateDetails.CollegePrefernce3 + "'),";
                sql7 = sql7 + "(select course_id from course_details where course_name='" + candidateDetails.CollegeCourse32 + "'),";
                sql7 = sql7 + "'waitlist')";

                sql8 = "insert into allotment(candidate_id,entrance_id,reservation,total_marks,college_id,course_id,status) values(";
                sql8 = sql8 + "'" + LoginInfo.userID + "',";
                sql8 = sql8 + "'" + candidateDetails.RegisterNumber + "',";
                sql8 = sql8 + "(select reservation from candidate_details where candidate_id='" + LoginInfo.userID + "'),";
                sql8 = sql8 + "(select candiate_physics+candiate_chemistry+candiate_maths+'" + candidateDetails.Total + "'from candidate_details where candidate_id='" + LoginInfo.userID + "'),";
                sql8 = sql8 + "(select college_id from college_details where college_name='" + candidateDetails.CollegePrefernce3 + "'),";
                sql8 = sql8 + "(select course_id from course_details where course_name='" + candidateDetails.CollegeCourse33 + "'),";
                sql8 = sql8 + "'waitlist') ";







                con = DatabaseHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd1 = new SqlCommand(sql1, con);
                cmd2 = new SqlCommand(sql2, con);
                cmd3 = new SqlCommand(sql3, con);
                cmd4 = new SqlCommand(sql4, con);
                cmd5 = new SqlCommand(sql5, con);
                cmd6 = new SqlCommand(sql6, con);
                cmd7 = new SqlCommand(sql7, con);
                cmd8 = new SqlCommand(sql8, con);

                output = cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
                cmd5.ExecuteNonQuery();
                cmd6.ExecuteNonQuery();
                cmd7.ExecuteNonQuery();
                cmd8.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSLAdmin.cs:GenerateAllotment()", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
                cmd1.Dispose();
                cmd2.Dispose();
                cmd3.Dispose();
                cmd4.Dispose();
                cmd5.Dispose();
                cmd6.Dispose();
                cmd7.Dispose();
                cmd8.Dispose();
            }
            return output;
        }

        //to allot students 
        public static int AllotStudents()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            int output = 0;
            string sql1 = "";
            try
            {
                //string s = "select candidate_id,entrance_id,reservation,total_marks,college_id,course_id,status from allotment where total_marks >= 200 order by total_marks desc";
                sql1 = "create table newTable as select * from allotment where total_marks >=200 order by total_marks desc";
                // sql1 = "insert into viewallotment (candidate_id,entrance_id,reservation,total_marks,college_id,course_id,status) select candidate_id,entrance_id,reservation,total_marks,college_id,course_id,status from allotment where total_marks >=200 order by total_marks desc";
                con = DatabaseHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql1, con);

                output = cmd.ExecuteNonQuery();
            }


            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSLAdmin.cs:AllotStudents()", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return output;

        }

        //to get details of the allotted students
        public static DataSet GetStudents()
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsStudents = null;

            try
            {
                sql = "select candidate_id,college_id,course_id,reservation from allotment where status='Alloted'";
                con = DatabaseHelper.GetConnection();
                con.Open();
                dsStudents = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsStudents);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSLAdmin.cs:GetStudents", ex.Message.ToString());
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