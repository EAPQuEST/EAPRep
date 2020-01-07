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


        //to insert the details of college 
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


        //insert the courses available in allotment
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

        //to get the college id
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

        //to get the details of the college using college id
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


        //update the college details
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



        //add courses in a college
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

        //to get college details
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

        //get college details of the input college name
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

        //to delete a college 
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

        //to get college name and college id
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

        //to generate allotment of the candidates
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

        //to allot students 
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


        //to get details of the allotted students
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


        //to check the current password of the admin is correct or not
        public static DataTable AdminChangePassword(string password)
        {
            //DataSet dsData = null;
            DataTable dtLogin = null;
            try
            {
                dtLogin = EapDSLAdmin.AdminChangePassword(password);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBL.cs:AdminChangePassword()", ex.Message.ToString());
            }

            return dtLogin;
        }


        //to change password if the user credentials entered is correct
        public static int AdminNewPassword(string username, string password)
        {
            int output = 0;
            try
            {
                output = EapDSLAdmin.AdminNewPassword(username, password);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBL.cs:AdminNewPassword", ex.Message.ToString());
            }
            return output;

        }


        //to view all the details of all the college in the grid view
        public static DataSet ViewCollegeList()
        {

            DataSet dsCollegeList = null;
            try
            {
                dsCollegeList = EapDSLAdmin.ViewCollegeList();

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*****Error : EapBLAdmin.cs::ViewCollegeList", ex.Message.ToString());
            }
            return dsCollegeList;
        }


        //to get the name of the course in a particular college
        public static DataSet GetCourseName(string collegeName)
        {
            DataSet dsCourseName = null;
            try
            {
                dsCourseName = EapDSLAdmin.GetCourseName(collegeName);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBLAdmin.cs:GetCourseName()", ex.Message.ToString());
            }
            return dsCourseName;
        }

        //to get all the available courses
        public static DataSet GetCourseShowAll()
        {
            DataSet dsCourseName = null;
            try
            {
                dsCourseName = EapDSLAdmin.GetCourseShowAll();

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBLAdmin.cs:GetCourseShowAll()", ex.Message.ToString());
            }
            return dsCourseName;
        }


        //to delete courses from a college
        public static int CourseDelete(string courseName)
        {
            int output = 0;
            try
            {
                output = EapDSLAdmin.CourseDelete(courseName);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBLAdmin.cs: CourseDelete", ex.Message.ToString());
            }
            return output;

        }



        //add courses to a college
        public static int CourseAdd(CollegeDetails collegeDetails)
        {
            int output = 0;
            try
            {
                output = EapDSLAdmin.CourseAdd(collegeDetails);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBLAdmin.cs: CourseAdd", ex.Message.ToString());
            }
            return output;

        }


        //check user credentials for the admin to login
        public static DataTable AdminLogin(string user, string password)
        {
            //DataSet dsData = null;
            DataTable dtLogin = null;
            try
            {
                dtLogin = EapDSLAdmin.AdminLogin(user, password);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBL.cs:AdminLogin()", ex.Message.ToString());
            }

            return dtLogin;
        }
    }
}
