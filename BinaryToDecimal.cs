using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class BinaryToDecimal
    {
        int binary;
        string pow;

        public void ReadData()
        {
            Console.WriteLine("Enter the binary number");
            binary = Convert.ToInt32(Console.ReadLine());
        
        }

        

        public void ToDecimal()
        {
            
            int lastDigit;
            int original = binary;
          
            int exp = 0;
            


            

            do
            {
                 lastDigit = original % 10;
                
                 pow += lastDigit * (int)(Math.Pow(2, exp));

                 original /= 10;
                

                 
                 exp++;
                


            } while (original > 0);
       

        }

        public void DisplayData()
        {
            Console.WriteLine("The input Binary is {0}", binary);

            Console.WriteLine("Decimal:{0}", pow);

        }

        public static void Main()
        {
            BinaryToDecimal objbin = new BinaryToDecimal();

            objbin.ReadData();
            objbin.DisplayData();
            objbin.ToDecimal();
           




            Console.ReadKey();
        }



    }
}
