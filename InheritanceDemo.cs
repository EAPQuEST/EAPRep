using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class InheritanceDemo
    {
        public static void Main()
        {
            //A a1 = new A();
            B b1 = new B();
            //a1.displayA();
            b1.displayB();
            Console.ReadKey();

        }
    }
    class A
    {
        public int val1;

        public A()
        {
            val1 = 10;
        }

        public void displayA()
        {
            Console.WriteLine("I am in class A val1:" + val1);
        }
    }

    class B : A
    {
        int val2;

        public B()
        {
            val2 = 100;

        }
        public void displayB()
        {
            Console.WriteLine("I am in class B val1:" + val1);
            Console.WriteLine("I am in class B val1:" + val2);
        }
    }
}
