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
    public class EapDSLAllotment
    {
        public static DataTable GetEachRow()
        {
            string sql = "";

            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataTable dt = null;

            try
            {
                sql = "select * from allotment order by total_marks desc";
                con = DatabaseHelper.GetConnection();
                con.Open();
                dt = new DataTable();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSLAllotment.cs:GetEachRow()", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }
            return dt;
        }

        //to get the details according to a row from the allotted details
        public static int  FetchByRow()
        {
            int output = 0;
            DataTable dt = null;
            AllotmentObject allotmentObject = null;
            try
            {


                dt = GetEachRow();
                foreach (DataRow dr in dt.Rows)
                {
                    allotmentObject = new AllotmentObject();

                    allotmentObject.CandidateId = dr["candidate_id"].ToString();
                    allotmentObject.Reservation = dr["reservation"].ToString();
                    allotmentObject.Total = Convert.ToInt32(dr["total_marks"]);
                    allotmentObject.CollegeId = dr["college_id"].ToString();
                    allotmentObject.CourseId = dr["course_id"].ToString();
                    allotmentObject.Status = dr["status"].ToString();

                    GetTotalSeats(allotmentObject);

                    if (allotmentObject.GeneralSeats > 0 && allotmentObject.Total >= 200 && allotmentObject.Status == "WL")
                    {

                        allotmentObject.Status = "Allotted";
                        allotmentObject.GeneralSeats--;
                        output = UpdateStatus(allotmentObject);
                    }
                    else if (allotmentObject.Reservation.Equals("OBC") && allotmentObject.ObcSeats > 0 && allotmentObject.Total >= 200 && allotmentObject.Status == "WL")
                    {
                        allotmentObject.Status = "Allotted";
                        allotmentObject.ObcSeats--;
                        output = UpdateStatus(allotmentObject);

                    }
                    else if (allotmentObject.Reservation.Equals("SC/ST") && allotmentObject.SC_STSeats > 0 && allotmentObject.Total >= 200 && allotmentObject.Status == "WL")
                    {
                        allotmentObject.Status = "Allotted";
                        allotmentObject.SC_STSeats--;
                        output = UpdateStatus(allotmentObject);

                    }
                    else if (allotmentObject.Reservation.Equals("Sport") && allotmentObject.SportSeats > 0 && allotmentObject.Total >= 200 && allotmentObject.Status == "WL")
                    {
                        allotmentObject.Status = "Allotted";
                        allotmentObject.SportSeats--;
                        output = UpdateStatus(allotmentObject);
                    }
                    else
                    {
                        Console.WriteLine("Allotment Completed ");
                    }


                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("EapDSLAllotment.FetchByRow()");

            }
            return output;

        }

        public static AllotmentObject GetTotalSeats(AllotmentObject allotmentObject)
        {
            
            SqlConnection con = null;
            
            DataTable dt = null;
            SqlDataAdapter adapter = null;
            
            string sql = "";
            try
            {
                sql = "select numberof_seats,obc,sc_st,sports from college_coures where collegeid='" + allotmentObject.CollegeId + "' and courseid='"+allotmentObject.CourseId+"'";
                con = DatabaseHelper.GetConnection();
                con.Open();
                dt = new DataTable();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dt);

                con = DatabaseHelper.GetConnection();
                con.Open();

                foreach (DataRow dr in dt.Rows)
                {

                    allotmentObject.GeneralSeats =Convert.ToInt32( dr["numberof_seats"]);
                    allotmentObject.ObcSeats = Convert.ToInt32(dr["obc"]);
                    allotmentObject.SC_STSeats= Convert.ToInt32(dr["sc_st"]);
                    allotmentObject.SportSeats = Convert.ToInt32(dr["sports"]);


                }


                }


            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSLAllotment.cs:GetTotal()", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }
           


            return allotmentObject;


        }





        public static int UpdateStatus(AllotmentObject allotmentObject)
        {
            int output = 0;
         
            string sql1 = "";
            string sql2 = "";
            string sql3 = "";
            SqlConnection con = null;
            SqlCommand cmd0 = null;
            SqlCommand cmd1 = null;
            SqlCommand cmd2 = null;
            SqlCommand cmd3 = null;

            try
            {

                sql1 = "update allotment set status='N/A' where candidate_id='" + allotmentObject.CandidateId + "'";


                if (allotmentObject.Reservation.Equals("OBC"))
                {

                    sql2 = "update college_coures set obc=" + allotmentObject.ObcSeats + " where collegeid='" + allotmentObject.CollegeId + "' and courseid='" + allotmentObject.CourseId + "'";
                    sql3 = "update allotment set status='Alloted',reservation='OBC' where candidate_id='" + allotmentObject.CandidateId + "' and college_id='" + allotmentObject.CollegeId + "' and course_id='" + allotmentObject.CourseId + "'";
                }
                else if (allotmentObject.Reservation.Equals("SC/ST"))
                {
                    sql2 = "update college_coures set sc_st=" + allotmentObject.SC_STSeats + " where collegeid='" + allotmentObject.CollegeId + "' and courseid='" + allotmentObject.CourseId + "'";
                    sql3 = "update allotment set status='Alloted',reservation='SC/ST' where candidate_id='" + allotmentObject.CandidateId + "' and college_id='" + allotmentObject.CollegeId + "' and course_id='" + allotmentObject.CourseId + "'";

                }
                else if (allotmentObject.Reservation.Equals("Sport"))
                {
                    sql2 = "update college_coures set sports=" + allotmentObject.SportSeats + " where collegeid='" + allotmentObject.CollegeId + "' and courseid='" + allotmentObject.CourseId + "'";
                    sql3 = "update allotment set status='Sport',reservation='OBC' where candidate_id='" + allotmentObject.CandidateId + "' and college_id='" + allotmentObject.CollegeId + "' and course_id='" + allotmentObject.CourseId + "'";
                }
                else
                {
                    sql2 = "update college_coures set numberof_seats=" + allotmentObject.GeneralSeats + " where collegeid='" + allotmentObject.CollegeId + "' and courseid='" + allotmentObject.CourseId + "'";
                    sql3 = "update allotment set status='Alloted',reservation='General' where candidate_id='" + allotmentObject.CandidateId + "' and college_id='" + allotmentObject.CollegeId + "' and course_id='" + allotmentObject.CourseId + "'";
                }
                
                
                



                con = DatabaseHelper.GetConnection();
                con.Open();
              
                cmd1 = new SqlCommand(sql1, con);
                cmd2 = new SqlCommand(sql2, con);
                cmd3 = new SqlCommand(sql3, con);



               
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();

                output = 1;

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSLAllotment.cs:UpdateStatus()", ex.Message.ToString());
            }
            finally
            {
                con.Close();
                
                cmd1.Dispose();
                cmd2.Dispose();
                cmd3.Dispose();
            }
            return output;
            
        }




    }
}
