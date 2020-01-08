using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Delegates
{
    public delegate void Print(int value);
    class AnonymsMethod
    {
        public static void Main()
        {
            Print print = delegate (int val)
            {
                Console.WriteLine("Inside Anonymous method. Value:{0}", val);
            };
            print(100);

            Console.ReadKey();

        }
    }
}
