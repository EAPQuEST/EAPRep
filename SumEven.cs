using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class SumEven
    {
        int count,result;

        public void ReadData()
        {
            Console.WriteLine("Enter the limit");
            count = Convert.ToInt32(Console.ReadLine());
        }

        public void EvenSum()
        {
            int i;
            for(i=0;i<=2*count;i++)
            {
                if(i%2==0)
                {
                    result += i;
                }
            }
        }

        public void DisplayData()
        {
            Console.WriteLine("The sum of even number {0}  ", result);
        }

        public static void Main(string[] args)
        {
            SumEven objeven = new SumEven();

            objeven.ReadData();
            objeven.EvenSum();
            objeven.DisplayData();
            Console.ReadKey();

        }



    }
}
