using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class LCM
    {
        int number1, number2,lcm1;
        int result;

        public void ReadData()
        {
            Console.WriteLine("Enter the number1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number2");
            number2 = Convert.ToInt32(Console.ReadLine());
        }

        public void lcm()
        {
            int i = 1;
            int duplicate=1;
         
            
            for (i = 1; i <= number1 &&i <= number2; i++)
            {
                if (number1 % i == 0 && number2 % i == 0)
                {
                    duplicate = i;

              
                   


                }
                lcm1 = (number1 * number2) / duplicate;

            }


            result = lcm1;
           


        }

        public void DisplayData()
        {
            Console.WriteLine("The lcm of  {0} and {1} is {2}", number1,number2, result);
        }

        public static void Main()
        {
           LCM p1 = new LCM();
            p1.ReadData();
            p1.lcm();
            p1.DisplayData();
            Console.ReadKey();
        }
    }
}
