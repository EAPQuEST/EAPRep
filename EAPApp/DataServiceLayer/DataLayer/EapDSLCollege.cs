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
    public class EapDSLCollege
    {
        public static int UpdateStatus(string candidateId)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                sql = "update new1allotment  set status ='confirmed' where candidate_id ='"+ candidateId+"'";

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




        public static int CollegeNewPassword(CollegeDetails collegeDetails)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                sql = "update password_details  set ";

                sql = sql + "password ='" + collegeDetails.Password + "'";
                sql = sql + " where username = '" + collegeDetails.Username + "'and user_type='college'";

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




        public static DataTable CollegeChangePassword(string password)
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            //DataSet dsLogin = null;
            DataTable dtLogin = null;


            try
            {
                //sql = "select count(*) as cnt from login_database"
                sql = "select password from password_details where password='" + password + "'and user_type='college'";
                con = DatabaseHelper.GetConnection();
                con.Open();
                //dsLogin = new DataSet();
                dtLogin = new DataTable();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dtLogin);


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSL.cs:CandidateChangePassword()", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }

            return dtLogin;
        }




        public static DataTable CollegeLogin(string user, string password)
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            //DataSet dsLogin = null;
            DataTable dtLogin = null;


            try
            {
                //sql = "select count(*) as cnt from login_database"
                sql = "select username,password from password_details where username='" + user + "'and password='" + password + "'and user_type='college'";
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

        public static DataSet GetCandidateIdLike(string likeId)
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;

            DataSet dsCandidate = null;

            try
            {
                sql = "select * from new1allotment where candidate_id like '" + likeId + "%'";
                con = DatabaseHelper.GetConnection();
                con.Open();
                dsCandidate = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsCandidate);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*****Error : EapDSL.cs::GetCandidateIdLike", ex.Message.ToString());

            }
            finally
            {
                con.Close();
                adapter.Dispose();

            }
            return dsCandidate;
        }


        public static DataSet GetCandidateName(string likeId)
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;

            DataSet dsCandidate = null;

            try
            {
                sql = "select candidate_name from candidate_registration where candidate_id = '" + likeId + "'";
                con = DatabaseHelper.GetConnection();
                con.Open();
                dsCandidate = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsCandidate);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*****Error : EapDSL.cs::GetCandidateIdLike", ex.Message.ToString());

            }
            finally
            {
                con.Close();
                adapter.Dispose();

            }
            return dsCandidate;
        }


    }
}
