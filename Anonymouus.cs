using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Delegates
{
    public delegate void Print1(int value);
    class Anonymouus
    {
        public static void PrintHelperMethod(Print printDel,int val)
        {
            val += 10;
            printDel(val);
        }
        public static void Main()
        {
            PrintHelperMethod(delegate (int val)
            {
                Console.WriteLine("Inside Anonymous method. Value:{0}", val);
            }, 100);
           

            Console.ReadKey();

        }
    }
}
