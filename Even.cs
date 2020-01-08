using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Even
    {
        int number;

        

        public void ReadData()
        {
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());
        }

        public void Even1()
        {

            if (number % 2 == 0)
                Console.WriteLine("The number {0} is even",number);
            else
                Console.WriteLine("The number {0} is odd",number);
        }

        public static void Main(string[] args)
        {
            Even objEvenorodd = new Even();

            objEvenorodd.ReadData();
            objEvenorodd.Even1();
            Console.ReadKey();

        }
    }
}
