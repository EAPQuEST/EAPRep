using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Strings
{
    class NumberNaming
    {
        string number;
        string result;
        char[] arr;
        public void ReadData()
        {
            Console.WriteLine("Enter the number");
            number = (Console.ReadLine());
        }

        public void Naming()
        {
            char[] arr = number.ToCharArray();
        }
    }

}
