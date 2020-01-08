using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class StaticDemo1
    {
        int i = 50;
        static int j = 10;


        public  void Dec()
        {
            Console.WriteLine("int i : {0}", +i);
            Console.WriteLine("static int j: {0}", +j);


            i--;
            j--;
        }

        public static void Main()
        {
            StaticDemo1 objdemo = new StaticDemo1();
            StaticDemo1 objdemo1 = new StaticDemo1();
            StaticDemo1 objdemo2 = new StaticDemo1();
            StaticDemo1 objdemo3 = new StaticDemo1();

            objdemo.Dec();
            objdemo1.Dec();
            objdemo2.Dec();
            objdemo3.Dec();

            Console.ReadKey();





        }

    }

}
