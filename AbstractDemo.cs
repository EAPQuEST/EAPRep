using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class AbstractDemo
    {
        public static void Main()
        {
            //ABC abc = new AABC():

            XYZ xyz = new XYZ();
            xyz.display();
            xyz.Print();
            xyz.Check();


            ABC.FindSum(10, 20);
            XYZ.FindSum(30, 40);

            Console.ReadKey();
        }
    }

    abstract class ABC
    {

        int val1;
        static int val2;
        const double PI = 3.14;

        abstract public void display();

        public static int FindSum(int v1, int v2)
        {

            return (v1 + v2);
        }

        public void Print()
        {
            Console.WriteLine("I am in Print Method");
        }
    }

    class XYZ:ABC
    {
        int val3;

        public void Check()
        {
            Console.WriteLine("I am in Check Method");
        }

        public override void display()
        {
            Console.WriteLine("I am in Display Method");
        }
    }
}
