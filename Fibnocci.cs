using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Fibnocci
    {

        int number;
        int first = 0;
        int second = 1;

        public void ReadData()
        {
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());
        }

        public void Fib()
        {

            int n = number;
            int third;
            Console.WriteLine("{0}", first);
            Console.WriteLine("{0}", second);

            while (n-2>0)
            {
                
                third = first + second;
                
                Console.WriteLine("{0}", third);
                
                first = second;
                second = third;
                n--;
                
            }

        }
        
        /*public void DisplayData()
        {
            
            Console.WriteLine("{0}", first);
            Console.WriteLine("{0}", second);
        }*/

        public static void Main()
        {
          Fibnocci   objfib = new Fibnocci();

            objfib.ReadData();
            objfib.Fib();
           // objfib.DisplayData();


            Console.ReadKey();
        }
    }
}
