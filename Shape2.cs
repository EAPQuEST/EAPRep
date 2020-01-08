using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Shape2
    {
        double area;

        public static void Area(double radius)
        {
            double area = 3.14 * radius * radius;
            Console.WriteLine("Area of circle {0}", area);
        }

        public static void Area(int length,int breadth)
        {
            double area = length * breadth;
            Console.WriteLine("Area of rectangle  {0}", area);
        }

        public static void Area(int side)
        {
            double area =side * side;
            Console.WriteLine("Area of square {0}", area);
        }

        

        

        public static void Main()
        {
            Area(10);
            Area(10, 20);
            Area(5.5);
            Console.ReadKey();
        }
    }
}
