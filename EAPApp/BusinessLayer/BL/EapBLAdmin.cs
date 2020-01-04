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
    public class EapBLAdmin
    {
        public static int CollegeDetailsInsert(CollegeDetails collegeDetails)
        {
            int output = 0;
            try
            {

                output = EapDSLAdmin.CollegeDetailsInsert(collegeDetails);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBLAdmin.cs:CollegeDetailsInsert", ex.Message.ToString());
            }
            return output;

        }
        public static int CollegeCourseInsert(CollegeDetails collegeDetails)
        {
            int output = 0;
            try
            {

                output = EapDSLAdmin.CollegeCourseInsert(collegeDetails);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBLAdmin.cs:CollegeCourseInsert", ex.Message.ToString());
            }
            return output;

        }
        public static DataSet GetCollegeIds()
        {
            string sql = "";

            DataSet dsCollegeId = null;

            try
            {
                dsCollegeId = EapDSLAdmin.GetCollegeIds();

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBLAdmin.cs:GetCollegeIds()", ex.Message.ToString());
            }

            return dsCollegeId;
        }

        public static CollegeDetails GetCollegeDetailsUsingId(string courseId)
        {

            CollegeDetails collegeDetails = null;

            try
            {
                collegeDetails = EapDSLAdmin.GetCollegeDetailsUsingId(courseId);


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBLAdmin.cs:GetCollegeDetailsUsingId()", ex.Message.ToString());
            }

            return collegeDetails;
        }
        public static int CollegeDetailsUpdate(CollegeDetails collegeDetails)
        {
            int output = 0;


            try
            {

                output = EapDSLAdmin.CollegeDetailsUpdate(collegeDetails);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBLAdmin.cs:CollegeDetailsUpdate()", ex.Message.ToString());
            }

            return output;
        }
        public static int CollegeCourseUpdate(CollegeDetails collegeDetails)
        {
            int output = 0;


            try
            {

                output = EapDSLAdmin.CollegeCourseUpdate(collegeDetails);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBLAdmin.cs:CollegeCourseUpdate()", ex.Message.ToString());
            }

            return output;
        }
        public static DataSet GetCollegeDetails()
        {
            string sql = "";
            DataSet dsCollegeDetails = null;


            try
            {

                dsCollegeDetails = EapDSLAdmin.GetCollegeDetails();
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBLAdmin.cs:GetCollegeDetails()", ex.Message.ToString());
            }


            return dsCollegeDetails;

        }
        public static DataSet GetDataLike(string likeCollegeName)
        {

            DataSet dsData = null;

            try
            {
                dsData = EapDSLAdmin.GetDataLike(likeCollegeName);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBLAdmin.cs:GetDataLike()", ex.Message.ToString());
            }

            return dsData;
        }
        public static int CollegeDelete(string collegeName)
        {
            int output = 0;
            try
            {

                output = EapDSLAdmin.CollegeDelete(collegeName);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBLAdmin.cs: CollegeDelete", ex.Message.ToString());
            }
            return output;


        }




        public static DataSet GetCollegeName()
        {
           
            DataSet dsCollegeName = null;

            try
            {

                dsCollegeName = EapDSLAdmin.GetCollegeName();


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBLAdmin.cs:GetCollegeName()", ex.Message.ToString());
            }
           
            return dsCollegeName;
        }


        public static int GenerateAllotment(CandidateDetails candidateDetails)
        {
            int output = 0;
            string sql = "";

            try
            {
               
                candidateDetails.Total = candidateDetails.CandidatePhysics + candidateDetails.CandidateChemistry + candidateDetails.CandidateMaths+candidateDetails.EntranceScienceMark+candidateDetails.EntranceMathsMark;
                output = EapDSLAdmin.GenerateAllotment(candidateDetails);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBLAdmin.cs:GenerateAllotment()", ex.Message.ToString());
            }
           
            return output;
        }

        public static int AllotStudents()
        {
            
            int output = 0;
            
            try
            {
                output = EapDSLAdmin.AllotStudents();
            }


            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBLAdmin.cs.cs:AllotStudents", ex.Message.ToString());
            }
           
            return output;

        }



        public static DataSet GetStudents()
        {
            string sql = "";

            DataSet dsStudents = null;

            try
            {
                dsStudents = EapDSLAdmin.GetStudents();
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapDSLAdmin.cs:GetStudents", ex.Message.ToString());
            }

            return dsStudents;
        }

    }
}
