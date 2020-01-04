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
        //public static int CollegeDetailsInsert(CollegeDetails collegeDetails)
        //{
        //    int output = 0;
        //    try
        //    {

        //        output = EapDSL.CollegeDetailsInsert(collegeDetails);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Out.WriteLine("*** Error : EapBL.cs:CollegeDetailsInsert", ex.Message.ToString());
        //    }
        //    return output;

        //}
        //public static int CollegeCourseInsert(CollegeDetails collegeDetails)
        //{
        //    int output = 0;
        //    try
        //    {

        //        output = EapDSL.CollegeCourseInsert(collegeDetails);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Out.WriteLine("*** Error : EapBL.cs:CollegeCourseInsert", ex.Message.ToString());
        //    }
        //    return output;

        //}
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
        //public static DataSet GetCollegeIds()
        //{
        //    string sql = "";

        //    DataSet dsCollegeId = null;

        //    try
        //    {
        //        dsCollegeId = EapDSL.GetCollegeIds();

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Out.WriteLine("*** Error : EapBL.cs:GetCollegeIds()", ex.Message.ToString());
        //    }

        //    return dsCollegeId;
        //}

        //public static CollegeDetails GetCollegeDetailsUsingId(string courseId)
        //{

        //    CollegeDetails collegeDetails = null;

        //    try
        //    {
        //        collegeDetails = EapDSL.GetCollegeDetailsUsingId(courseId);
                

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Out.WriteLine("*** Error : EapBL.cs:GetCollegeDetailsUsingId()", ex.Message.ToString());
        //    }
            
        //    return collegeDetails;
        //}
        //public static int CollegeDetailsUpdate(CollegeDetails collegeDetails)
        //{
        //    int output = 0;
           

        //    try
        //    {

        //        output = EapDSL.CollegeDetailsUpdate(collegeDetails);

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Out.WriteLine("*** Error : EapBL.cs:CollegeDetailsUpdate()", ex.Message.ToString());
        //    }
           
        //    return output;
        //}
        //public static int CollegeCourseUpdate(CollegeDetails collegeDetails)
        //{
        //    int output = 0;


        //    try
        //    {

        //        output = EapDSL.CollegeCourseUpdate(collegeDetails);

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Out.WriteLine("*** Error : EapBL.cs:CollegeCourseUpdate()", ex.Message.ToString());
        //    }

        //    return output;
        //}
        //public static DataSet GetCollegeDetails()
        //{
        //    string sql = "";
        //    DataSet dsCollegeDetails = null;


        //    try
        //    {

        //        dsCollegeDetails = EapDSL.GetCollegeDetails();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Out.WriteLine("*** Error : EapBL.cs:GetCollegeDetails()", ex.Message.ToString());
        //    }


        //    return dsCollegeDetails;

        //}
        //public static DataSet GetDataLike(string likeCollegeName)
        //{

        //    DataSet dsData = null;

        //    try
        //    {
        //        dsData = EapDSL.GetDataLike(likeCollegeName);

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Out.WriteLine("*** Error : EapBL.cs:GetDataLike()", ex.Message.ToString());
        //    }

        //    return dsData;
        //}
        //public static int CollegeDelete(string collegeName)
        //{
        //    int output = 0;
        //    try
        //    {

        //        output = EapDSL.CollegeDelete(collegeName);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Out.WriteLine("*** Error : EapBL.cs: CollegeDelete", ex.Message.ToString());
        //    }
        //    return output;


        //}
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


        public static DataTable CandidateChangePassword( string password)
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



        public static DataTable AdminLogin(string user, string password)
        {
            //DataSet dsData = null;
            DataTable dtLogin = null;

            try
            {
                dtLogin = EapDSL.AdminLogin(user, password);


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBL.cs:AdminLogin()", ex.Message.ToString());
            }


            return dtLogin;

        }


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

        public static DataSet GetCandidateIds()
        {
            string sql = "";

            DataSet dsCandidateId = null;

            try
            {
                dsCandidateId = EapDSL.GetCandidateId();

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBL.cs:GetCandidateIds()", ex.Message.ToString());
            }

            return dsCandidateId;
        }

    }
}
