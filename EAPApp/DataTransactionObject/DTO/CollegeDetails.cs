using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransactionObject.DTO
{
    public class CollegeDetails
    {
        private string collegeId;

        public string CollegeID
        {
            get { return collegeId; }
            set { collegeId = value; }
        }

        private string collegeName;

        public string CollegeName
        {
            get { return collegeName; }
            set { collegeName = value; }
        }

        private int totalSeats;

        public int TotalSeats
        {
            get { return totalSeats; }
            set { totalSeats = value; }
        }

        private string collegeAddress;

        public  string CollegeAddress
        {
            get { return collegeAddress; }
            set { collegeAddress = value; }
        }

        private string collegePhone;

        public string CollegePhone
        {
            get { return collegePhone; }
            set { collegePhone = value; }
        }

        private string courseId;

        public  string CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }

        private string courseName;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        private int courseSeat;

        public int CourseSeat
        {
            get { return courseSeat; }
            set { courseSeat = value; }
        }









    }
}
