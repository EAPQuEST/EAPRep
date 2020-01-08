using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Delegates
{
    public delegate void Calcute(int val1, int val2);
    class DelegateDemo
    {
        static void Main()
        {
            Calculator1 calc = new Calculator1();
            Calcute calculate = new Calcute(Calculator1.Sum);
            calculate += Calculator2.Sub;
            calculate += Calculator1.Mul;
            calculate -= Calculator2.Sub; //To delete a method 
            calculate(10, 20);
            Console.ReadLine();
        }
    }
    class Calculator1
    {
        public static void Sum(int value1, int value2)
        {
            Console.WriteLine(value1 + value2);
        }
        public static void Mul(int value1, int value2)
        {
            Console.WriteLine(value1 *value2);
        }
    }

    class Calculator2
    {
        public static void Sub(int value1, int value2)
        {
            Console.WriteLine(value1 - value2);
        }
    }
}
