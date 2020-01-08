using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class SumProc
    {
        public static void Main(string[] args)
        {
            int value1, value2, value3;
            Console.WriteLine("Enter the value1");
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value2");
            value2 = Convert.ToInt32(Console.ReadLine());
            value3 = value1 + value2;
            Console.WriteLine("value 1 : " + value1);
            Console.WriteLine("value 2 : " + value2);
            Console.WriteLine("value 3 : " + value3);
            Console.ReadKey();
        }
    }
}
