using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransactionObject.DTO
{
    class AllotmentObject
    {
        private int generalSeats;

        public int GeneralSeats
        {
            get { return generalSeats; }
            set { generalSeats = value; }
        }
        private int obcSeats;

        public int ObcSeats
        {
            get { return obcSeats; }
            set { obcSeats = value; }
        }

        private int sc_stSeats;

        public int SC_STSeats
        {
            get { return sc_stSeats; }
            set { sc_stSeats = value; }
        }

        private int sportseats;

        public int SportSeats
        {
            get { return sportseats; }
            set { sportseats = value; }
        }


        private string candidateId;

        public string CandidateId
        {
            get { return candidateId; }
            set { candidateId = value; }
        }

        private string collegeId;

        public string CollegeId
        {
            get { return collegeId; }
            set { collegeId = value; }
        }

        private string courseId;

        public string CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }

        private string reservation;

        public string Reservation
        {
            get { return reservation; }
            set { reservation = value; }
        }

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private int total;

        public int Total
        {
            get { return total; }
            set { total = value; }
        }
    }
}
