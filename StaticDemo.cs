﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class StaticDemo
    {
        public static void Main()
        {
            Console.WriteLine("10+20= " + Calculate.sum(10, 20));

            Calculate objCalculate = new Calculate();
            Console.WriteLine("20-10= " + Calculate.diff(20, 10));

            Console.ReadKey();

        }
    }
}
