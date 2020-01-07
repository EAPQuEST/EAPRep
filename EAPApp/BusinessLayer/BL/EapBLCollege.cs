using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransactionObject.DTO;
using DataServiceLayer.DataLayer;
using System.Data;

namespace BusinessLayer.BL
{
   public class EapBLCollege
    {

        //update status of the allotted candidates to confirmed
        public static int UpdateStatus(string candidateId)
        {
            int output = 0;

            try
            {
                output = EapDSLCollege.UpdateStatus(candidateId);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*****Error : EapBL.cs::GetCandidateIdLike", ex.Message.ToString());

            }

            return output;
        }

        //check the current password of the college is correct

        public static DataTable CollegeChangePassword(string password)
        {
            //DataSet dsData = null;
            DataTable dtLogin = null;

            try
            {
                dtLogin = EapDSLCollege.CollegeChangePassword(password);


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBL.cs:CollegeChangePassword()", ex.Message.ToString());
            }


            return dtLogin;

        }

        //change the old password and set new password
        public static int CollegeNewPassword(CollegeDetails collegeDetails)
        {
            int output = 0;
            try
            {

                output = EapDSLCollege.CollegeNewPassword(collegeDetails);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBL.cs:CollegeNewPassword", ex.Message.ToString());
            }

            return output;


        }


        //login to college page if the user credentials are correct
        public static DataTable CollegeLogin(string user, string password)
        {
            //DataSet dsData = null;
            DataTable dtLogin = null;

            try
            {
                dtLogin = EapDSLCollege.CollegeLogin(user, password);


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBL.cs:CandidateLogin()", ex.Message.ToString());
            }


            return dtLogin;

        }

        //to get the details of the candidates using their id
        public static DataSet GetCandidateIdLike(string likeId)
        {


            DataSet dsCandidate = null;

            try
            {
                dsCandidate = EapDSLCollege.GetCandidateIdLike(likeId);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*****Error : EapBL.cs::GetCandidateIdLike", ex.Message.ToString());

            }

            return dsCandidate;
        }

        //get name of the candidates using their id
        public static DataSet GetCandidateName(string likeId)
        {


            DataSet dsCandidate = null;

            try
            {
                dsCandidate = EapDSLCollege.GetCandidateName(likeId);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*****Error : EapBL.cs::GetCandidateName", ex.Message.ToString());

            }

            return dsCandidate;
        }


    }
}
