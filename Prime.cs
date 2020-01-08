using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Prime
    {
        int p;
        String result;

        public void ReadData()
        {
            Console.WriteLine("Enter the number");
            p = Convert.ToInt32(Console.ReadLine());
        }

        public void Check()
        {
            
            bool flag = true;
            for (int no = 2; no < p; no++)
            {
                if (p % no == 0)
                {

                    flag = false;
                    break;


                }

            }
            if (p == 1)
            {
                result = "neither prime nor composite";

            }
            else if (flag)
            {


                result = "Prime";
            }


            else
            {

                result = "Not Prime";



            }
        }
        public void DisplayData()
        {
                Console.WriteLine("The given number {0} is {1}", p, result);
        }

        public static void Main(string[] args)
        {
            Prime objprime = new Prime();

            objprime.ReadData();
            objprime.Check();
            objprime.DisplayData();
            Console.ReadKey();

        }

        
           
    }
}
