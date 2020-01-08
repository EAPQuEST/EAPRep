using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Arrays
{
    class Input
    {
        public static int ReadI()
        {
            int value = 0; bool flag = true;
            do
            {
                try
                {
                    value = Convert.ToInt32(Console.ReadLine());
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("Wrong Value| enter a valid integer");
                }
            } while (flag);
            return value;
        }
        public static void Main()
        {
            ReadI();
            Console.ReadKey();
        }
    }
}
