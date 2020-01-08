using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Gcd
    {
        int number1, number2, gcd1;
        int result;

        public void ReadData()
        {
            Console.WriteLine("Enter the number1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number2");
            number2 = Convert.ToInt32(Console.ReadLine());
        }
        public void gcd()
        {
            int i = 1;
            int duplicate = 1;


            for (i = 1; i <= number1 && i <= number2; i++)
            {
                if (number1 % i == 0 && number2 % i == 0)
                {
                    gcd1 = i;





                }
               

            }


            result = gcd1;



        }
        public void DisplayData()
        {
            Console.WriteLine("The lcm of  {0} and {1} is {2}", number1, number2, result);
        }

        public static void Main()
        {
            Gcd g1 = new Gcd();
            g1.ReadData();
            g1.gcd();
            g1.DisplayData();
            Console.ReadKey();
        }
    }
}

