using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class PerfectNumber
    {
        int number;
        string result;

        public void ReadData()
        {
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());
        }

        public void FindPerfect()
        {
            int i;
            int sum=0;
            for (i = 1; i <= number / 2; i++)
            {
                if (number%i == 0)
                {
                    sum = sum + i;
                }
            }

            if (sum == number)
            {
                result = "Perfect Number";
            }

            else
            {
                result = " Not Perfect Number";
            }
        }

        public void DisplayData()
        {
            Console.WriteLine("The given number  {0} is {1}", number,result);
           
        }

        public static void Main()
        {
            PerfectNumber p1 = new PerfectNumber();
            p1.ReadData();
            p1.FindPerfect();
            p1.DisplayData();
            Console.ReadKey();
        }

    }
}
