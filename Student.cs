using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Student
    {
        int id;
        double mark;
        string name;
        string result;
       


        static int minimum = 10;
        static int maximum = 100;
        static int pass = 45;

        public void ReadData()
        {
            Console.WriteLine("Enter the id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name:");
            name = Console.ReadLine();

        }

        public void DisplayData()
        {
            Console.WriteLine("Student id: {0}",id);
            Console.WriteLine("Student name: {0}", name);
            Console.WriteLine("Mark Scored {0}",mark);
            Console.WriteLine("{0}", result);
        }

        public void Find()
        {
            

            
            bool flag = false;

            do
            {
                flag = false;

                Console.WriteLine("Enter the mark:");
                mark = Convert.ToInt32(Console.ReadLine());

                if (mark<minimum || mark>maximum)
                {
                    flag = true;
                    Console.WriteLine("Enter the correct  mark");
                    
                    
                }

            } while(flag);


            if (mark>=pass)
            {
                result = "PASSED";
            }

            else
            {
                result = "FAILED";
            }
        }

        public static void Main()
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            Student student4 = new Student();

            student1.ReadData();
            student1.Find();
            student1.DisplayData();

            student2.ReadData();
            student2.Find();
            student2.DisplayData();

            student3.ReadData();
            student3.Find();
            student3.DisplayData();

            student4.ReadData();
            student4.Find();
            student4.DisplayData();



            Console.ReadKey();





        }


    }
}
