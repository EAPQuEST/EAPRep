using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class InterfaceDemo
    {
        //Base b1 = new Base();

        public static void Main()
        {
            Sub s1 = new Sub();
            s1.Display1();
            Console.ReadKey();

        }
    }

    interface Base1
    {

        void Display1();
    }


    class KLM
    {
      
    }
        

    class Sub : KLM, Base1
    {
        public  void Display1()
        {
            Console.WriteLine("I am in Sub Class");
        }
    }
}
