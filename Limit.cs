using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Limit
    {
        int lower;
        int upper;

        public void ReadData()
        {
            Console.WriteLine("Enter the lower limit");
            lower = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the upper limit");
            upper = Convert.ToInt32(Console.ReadLine());

        }

        public void Interval()
        {
            int i;
            for(i=lower+1;i<=upper;i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("The number {0} is even", i);
                else
                    Console.WriteLine("The number {0} is odd", i);
            }
        }

        public static void Main(string[] args)
        {
            Limit objinterval = new Limit();

            objinterval.ReadData();
            objinterval.Interval();
            Console.ReadKey();

        }



    }
}
