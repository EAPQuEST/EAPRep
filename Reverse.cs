using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Reverse
    {
        int number;
        int reverse;

        public void ReadData()
        {
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayData()
        {
            Console.WriteLine("The given number is {0}", number);
            Console.WriteLine("Reversed result is {0}", reverse);
            
        }

        public void ReverseNumber()
        {
            
            int n = number;
            int lastDigit;
            reverse = 0;

            do
            {
                lastDigit = n % 10;
                reverse =reverse*10+lastDigit;
                n /= 10;
            } while (n > 0);
            

        }

        public static void Main()
        {
            Reverse objreverse = new Reverse();

            objreverse.ReadData();
            objreverse.ReverseNumber();
            objreverse.DisplayData();

            
            Console.ReadKey();
        }
    }
}
