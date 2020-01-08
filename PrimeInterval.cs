using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class PrimeInterval
    {
        int upper, lower;
        string result;

        public void ReadData()
        {
            Console.WriteLine("Enter the lower limit");
            lower = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the upper limit");
            upper = Convert.ToInt32(Console.ReadLine());
           

        }

        public void Check()
        {

           
            int i;
            for (i = lower; i <upper; i++)
            
            {
                bool flag = true;
                for (int no = 2; no < i; no++)
                {
                    if (i % no == 0)
                    {

                        flag = false;
                        break;


                    }

                }

                   
                if (flag)
                {


                    Console.WriteLine("{0} is Prime",i);
                }


                   
               

            }
        }
        public static void Main(string[] args)
        {
            PrimeInterval objprime1= new PrimeInterval();

            objprime1.ReadData();
            objprime1.Check();
            //objprime.DisplayData();
            Console.ReadKey();

        }
    }
}
