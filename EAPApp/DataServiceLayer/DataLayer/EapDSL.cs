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
                string sqltmp = "select course_id from course_details where course_name='" + collegeDetails.CourseName + "'";
                sql = "insert into college_coures(collegeid,courseid) values(";

                sql = sql + "'" + collegeDetails.CollegeID + "',";
                //sql = sql + "'" + collegeDetails.CourseId + "')";
                sql = sql + "("+ sqltmp +"))";
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
                sql = "insert into candidate_details(candidate_id,candidate_name,candidate_dob,candidate_address," +
                    "candidate_10th_school,candidate_10th_percentage,candidate_12th_school,candidate_12th_percentage," +
                    "candiate_physics,candiate_chemistry,candiate_maths) values(";
                sql = sql + "'" + candidateDetails.CandidateId + "',";
                sql = sql + "'" + candidateDetails.CandidateName + "',";
                sql = sql + "'" + candidateDetails.CandidateDOB + "',";
                sql = sql + "'" + candidateDetails.CandidateAddress + "',";
                sql = sql + "'" + candidateDetails.CandidateSchoolName10 + "',";
                sql = sql  + candidateDetails.Candidatemark10 + ",";
                sql = sql + "'" + candidateDetails.CandidateSchoolName12 + "',";
                sql = sql  + candidateDetails.Candidatemark12 + ",";
                sql = sql + candidateDetails.CandidatePhysics + ",";
                sql = sql  + candidateDetails.CandidateChemistry + ",";
                sql = sql  + candidateDetails.CandidateMaths + ")";


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

    }
}
