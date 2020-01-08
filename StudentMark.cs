using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_Week5.dto
{
    public class StudentMark
    {
       
        private string studentId;

        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        private string studentName;

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        private int mark1;

        public int Mark1
        {
            get { return mark1; }
            set { mark1 = value; }
        }

        private int mark2;

        public int Mark2
        {
            get { return mark2; }
            set { mark2 = value; }
        }

        private int mark3;

        public int Mark3
        {
            get { return mark3; }
            set { mark3 = value; }
        }

        private int total;

        public int Total
        {
            get { return total; }
            set { total = value; }
        }

        private string result;

        public string Result
        {
            get { return result; }
            set { result = value; }
        }





    }
}
