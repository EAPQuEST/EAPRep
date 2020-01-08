using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Ncr
    {
        int r,number,result;

        public void ReadData()
        {
            Console.WriteLine("Enter the value of r");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());
        }

        public void Ncr1()
        {
            int i = 1,j=1,k=1;
            int result1;
            int fact = 1;
            int fact1 = 1;
            int fact3 = 1;
            int value;

            while (i <= number)
            {
                fact = fact * i;
                i++;


            }

            while (k <= r)
            {
                fact3 = fact3 * k;
                k++;


            }

            value = number - r;
            while (j <= value)
            {
                fact1 = fact1 * j;
                j++;


            }
            result1 = fact3*fact1;
            result = fact / result1;
        }

        public void DisplayData()
        {
           Console.WriteLine("The ncr is {0} ", result);

        }

        public static void Main()
        {
                Ncr objncr = new Ncr();

                objncr.ReadData();
                objncr.Ncr1();

                objncr.DisplayData();
                Console.ReadKey();

        }




        
    }
}
