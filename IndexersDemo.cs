using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Strings
{
    class IndexersDemo
    {
        public static void Main()
        {
            Marks marks = new Marks();
            marks[0] = 100;
            for (int i = 1; i < 10; i++)
            {
                marks[i] = marks[i - 1] + 10;
            }

            for (int i = 1; i < 10; i++)
            {
                Console.Write(marks[i] + " ");
            }

            Console.ReadKey();
        }
       

        
       

            

    }

    class Marks
    {
        static int noOfStudents = 10;
        public int[] mark = new int[noOfStudents];

        public int[] values = new int[10];

        public int this[int index]
        {
            get { return mark[index]; }
            set { mark[index] = value; }
        }

    }
}
