using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Factorial
    {
        int number,fact=1;

        public void ReadData()
        {
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());
        }

        public void Fact()
        {
           
            int i=1;
           
            while(i<=number)
            {
                fact= fact*i;
                i++;


            }
        }

        public void DisplayData()
        {
            Console.WriteLine("The factorial of {0} is {1}", number,fact);
            
        }

        public static void Main(string[] args)
        {
            Factorial objfact = new Factorial();

            objfact.ReadData();
            objfact.Fact();
            
            objfact.DisplayData();
            Console.ReadKey();

        }
    }
}
