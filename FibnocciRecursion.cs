using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class FibnocciRecursion
    {
        
       public  static void Main(string[] args)
       {
            int number;
            int count = 0;
            Console.WriteLine("Enter the number of terms");
            number = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("The Fibnocci series is");
            for(int increment = 1; increment <= number; increment++)
            {
                int result = Fibnocci(increment);
            
                Console.Write(result + " \t");
                count++;
            }

            Console.ReadKey();

            
       }
        public static int Fibnocci(int no)
        {
            if (no == 0)
            {
                return 0;

            }
            else if (no == 1)
            {
                return 1;

            }
            else
            {
                return (Fibnocci(no - 1) + Fibnocci(no - 2));
            }
        }
    }
}
