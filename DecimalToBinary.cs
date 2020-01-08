using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class DecimalToBinary
    {
        int decimalNumber;
        string pow;
        

        public void ReadData()
        {
            Console.WriteLine("Enter the decimal number");
            decimalNumber = Convert.ToInt32(Console.ReadLine());

        }

        public void ToBinary()
        {
            int lastDigit;
            int original = decimalNumber;

            int exp = 0;
            while (original > 0)
            {
                lastDigit = original % 2;


                //pow += lastDigit * (int)(Math.Pow(10, exp));
                pow = lastDigit.ToString() + pow;

                original /= 2;




                exp++;
                




            }
            
            Console.WriteLine(pow);
        }
        public void DisplayData()
        {
            Console.WriteLine("The input decimal is {0}", decimalNumber);

            Console.WriteLine("Binary:{0}", pow);

        }

        public static void Main()
        {
            DecimalToBinary objdeci = new DecimalToBinary();

            objdeci.ReadData();
            objdeci.DisplayData();
            objdeci.ToBinary();





            Console.ReadKey();
        }

    }
}
