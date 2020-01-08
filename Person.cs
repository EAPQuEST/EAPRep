using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Person
    {
        


        public static void Main()
        {
            Student1 objS1 = new Student1();
            objS1.ReadData();
            objS1.FindResult();
            objS1.DisplayData();
            Console.ReadKey();
        }

    }

    class Person1
    {
        public int id;
        public string name;

        public  Person1()
        {
            this.id = id;
            this.name = name;
        }
        

        public void ReadData()
        {
            Console.WriteLine("Enter the id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name:");
            name = Console.ReadLine();
        }


    }
        
    

    class Student1 : Person1
    {
        int mark1, mark2, mark3,total;
        string result;

        public Student1()
        {
            this.mark1 = mark1;
            this.mark2 = mark2;
            this.mark3 = mark3;
        }

        public void ReadData()
        {
            Console.WriteLine("Enter the id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter the mark1:");
            mark1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the mark2:");
            mark2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the mark3:");
            mark3 = Convert.ToInt32(Console.ReadLine());
        }


        public void DisplayData()
        {
            Console.WriteLine("Id:" + id);
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Mark1:" + mark1);
            Console.WriteLine("Mark2:" + mark2);
            Console.WriteLine("Mark3:" + mark3);
            Console.WriteLine("Total Mark Scored:" + total);
            Console.WriteLine("" + result);


        }

        public void FindResult()
        {
            

            total = mark1 + mark2 + mark3;
            if (total >= 45)
            {
                result="PASSED";
            }
            else
            {
                result="FAILED";
            }
        }
    }
}
