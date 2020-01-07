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
    public class EapBL
    {
        //to insert the candidate educational details
        public static int StudentDetailsInsert(CandidateDetails candidateDetails)
        {
            int output = 0;
            try
            {

                output = EapDSL.StudentDetailsInsert(candidateDetails);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBL.cs:StudentDetailsInsert", ex.Message.ToString());
            }
           
            return output;


        }

        //to insert the candidate basic details to register
         public static int CandidateRegistrationInsert(CandidateDetails candidateDetails)
        {
            int output = 0;
            try
            {

                output = EapDSL.CandidateRegistrationInsert(candidateDetails);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBL.cs:CandidateRegistrationInsert", ex.Message.ToString());
            }

            return output;


        }


        //to insert the candidate course preference
        public static int StudentCoursePreferenceInsert(CandidateDetails candidateDetails)
        {
            int output = 0;
            try
            {

                output = EapDSL.StudentCoursePreferenceInsert(candidateDetails);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBL.cs:StudentCoursePreferenceInsert", ex.Message.ToString());
            }
           
            return output;


        }
       

        //check the username and password for login
        public static DataTable CandidateLogin(string user,string password)
        {
            //DataSet dsData = null;
            DataTable dtLogin = null;

            try
            {
                dtLogin = EapDSL.CandidateLogin(user, password);


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBL.cs:CandidateLogin()", ex.Message.ToString());
            }


            return dtLogin;

        }


        //load courses available within a particular college in the combo box
        public static DataSet LoadCollegePreference(string collegeName)
        {
            DataSet dsData = null;

            try
            {
                dsData = EapDSL.LoadCollegePreference(collegeName);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBL.cs:LoadCollegePreference()", ex.Message.ToString());
            }
           

            return dsData;

        }

        //load the educational details of already applied candidates for the allotment in the text box

        public static CandidateDetails LoadCandidateDetails()
        {
           
            CandidateDetails candidateDetails = null;

            try
            {

                candidateDetails = EapDSL.LoadCandidateDetails();


                

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBL.cs:LoadCandidateDetails()", ex.Message.ToString());
            }
            


            return candidateDetails;

        }

        //view the allotment result 
        public static CandidateDetails ViewAllotmentResult()
        {
            CandidateDetails candidateDetails = null;

            try
            {
                candidateDetails = EapDSL.ViewAllotmentResult();

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBL.cs:ViewAllotmentResult()", ex.Message.ToString());
            }
          



            return candidateDetails;

        }


        //to check if the current password is correct or not
        public static DataTable CandidateChangePassword(string password)
        {
            //DataSet dsData = null;
            DataTable dtLogin = null;
            try
            {
                dtLogin = EapDSL.CandidateChangePassword(password);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBL.cs:CandidateChangePassword()", ex.Message.ToString());
            }

            return dtLogin;
        }

        //to change the password if the user credentials entered is correct
        public static int CandidateNewPassword(CandidateDetails candidateDetails)
        {
            int output = 0;
            try
            {
                output = EapDSL.CandidateNewPassword(candidateDetails);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBL.cs:CandidateNewPassword", ex.Message.ToString());
            }
            return output;

        }




        //to check if the candidate has already applied for allotment
        public static int CheckExistingCandidate(string candidateId)
        {
            int output=0;



            try
            {

                output = EapDSL.CheckExistingCandidate(candidateId);
               
            }
            catch (Exception ex)
            {

                Console.Out.WriteLine("*** Error : EapBL.cs:CheckExistingCandidate()", ex.Message.ToString());
            }

            return output;

        }
    }
}
