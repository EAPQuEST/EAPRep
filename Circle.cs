using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Circle
    {
        const double pi = 3.14;
        double radius; 
        double area, circumfrence;

        public void ReadData()
        {
            Console.WriteLine("Enter the radius");
            radius = Convert.ToInt32(Console.ReadLine());
        }

        public void Area()
        {
            area = pi * radius * radius;
        }

        public void Circumference()
        {
            circumfrence = 2 *pi * radius;
        }

        public void DisplayData()
        {
            Console.WriteLine("The given radius is {0}",radius);
            Console.WriteLine("Area {0}", area);
            Console.WriteLine("circumference {0}", circumfrence);

        }

        public static void Main(string[] args)
        {
            Circle objcircle = new Circle();

            objcircle.ReadData();
            objcircle.Area();
            objcircle.Circumference();
            objcircle.DisplayData();
            Console.ReadKey();

        }
    }

}
