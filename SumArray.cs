using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Arrays
{
    class SumArray
    {
        int number;
        int[] values;
        int sum;

        public SumArray()
        {

        }

        public void ReadData()
        {
            Console.WriteLine("Enter the value of the number");
            number = Convert.ToInt32(Console.ReadLine());
            
        }

        public void DisplayData()
        {
            Console.WriteLine("The sum is {0}", sum);

        }

        public void FindSum()
        {
            int value;
            values = new int[number];
            Console.WriteLine("Enter the number to find sum");
            for (int i = 0; i < number; i++)
            {
                
                value= Convert.ToInt32(Console.ReadLine());
                values[i] = value;
                sum += values[i];


            }



        }

        public static void Main()
        {
            SumArray s = new SumArray();
            s.ReadData();
            s.FindSum();
            s.DisplayData();

            Console.ReadKey();
        }
    }

}
