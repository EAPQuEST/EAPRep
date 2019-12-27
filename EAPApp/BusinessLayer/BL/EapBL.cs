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
        public static int CollegeDetailsInsert(CollegeDetails collegeDetails)
        {
            int output = 0;
            try
            {

                output = EapDSL.CollegeDetailsInsert(collegeDetails);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBL.cs:CollegeDetailsInsert", ex.Message.ToString());
            }
            return output;

        }
        public static int CollegeCourseInsert(CollegeDetails collegeDetails)
        {
            int output = 0;
            try
            {

                output = EapDSL.CollegeCourseInsert(collegeDetails);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : EapBL.cs:CollegeCourseInsert", ex.Message.ToString());
            }
            return output;

        }
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
    }
}
