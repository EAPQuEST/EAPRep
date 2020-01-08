using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class DigitSum
    {
        int number;
        int digitSum;

       

        public DigitSum()
        {
            
        }

        public DigitSum(int n)
        {
            number = n;
        }

        public void ReadData()
        {
            Console.WriteLine("Enter the value of the number");
            number = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayData()
        {
            Console.WriteLine("The given number {0} is {1}", number,digitSum );
        
        }

        public void FindDigitSum()
        {
            int n = number;
            int lastDigit;
            do
            {
                lastDigit = n % 10;
                digitSum += lastDigit;
                n /= 10;
            } while (n > 0);
        }

        public static void Main(String[] args)
        {
            DigitSum objdigitSum = new DigitSum(1121);

            //objdigitSum.ReadData();
            objdigitSum.FindDigitSum();
            objdigitSum.DisplayData();

            DigitSum objdigitSum1 = new DigitSum();

            objdigitSum1.ReadData();
            objdigitSum1.FindDigitSum();
            objdigitSum1.DisplayData();
            Console.ReadKey();
        }


    }
}
