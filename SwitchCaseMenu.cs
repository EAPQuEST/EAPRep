using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class SwitchCaseMenu
    {
        public static void Main()
        {
            int option;
            do
            {
                Console.WriteLine("*****************************");
                Console.WriteLine("1.Digit Sum");
                Console.WriteLine("2.Check Prime");
                Console.WriteLine("3.Exit");
                Console.WriteLine("*****************************");
                Console.WriteLine("Enter the option (1-3)");
                option = Convert.ToInt32(Console.ReadLine());


                switch (option)
                {
                    case 1:
                        DigitSum objdigitSum1 = new DigitSum();

                        objdigitSum1.ReadData();
                        objdigitSum1.FindDigitSum();
                        objdigitSum1.DisplayData();

                        break;

                    case 2:
                        Prime objprime = new Prime();

                        objprime.ReadData();
                        objprime.Check();
                        objprime.DisplayData();
                        break;

                    case 3:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong option,please enter 1-3");
                        break;



                }


            } while (true);
        }
    }
}
