using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Sum
    {
        int value1, value2, value3;

        public void DisplayData()
        {
            Console.WriteLine("value 1 : " + value1);
            Console.WriteLine("value 2 : " + value2);
            Console.WriteLine("value 3 : " + value3);
        }

        public void ReadData()
        {
            Console.WriteLine("Enter the value1");
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value2");
            value2 = Convert.ToInt32(Console.ReadLine());

        }

        public void FindSum()
        {
            value3 = value1 + value2;
        }

        public static void Main(string[] args)
        {
            Sum objSum = new Sum();
            
            objSum.ReadData();
            objSum.FindSum();
            objSum.DisplayData();
            Console.ReadKey();

        }
    }
}
