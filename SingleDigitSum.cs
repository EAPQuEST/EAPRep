using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class SingleDigitSum
    {
        int number;
        int sum1,sum;
       

        public SingleDigitSum()
        {

        }
       

        public void ReadData()
        {
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());

        }

        public void DigitSum()
        {
            int lastDigit;
            int original=number;
            //sum1=0;
            


            do
                {
                    lastDigit = original % 10;
                    sum += lastDigit;

                    original /= 10;


                } while (original > 0);
               //      Console.WriteLine("The sum is {0}", sum);

            if (sum > 9)
            {
                do
                {
                    lastDigit = sum % 10;
                    sum1 += lastDigit;

                    sum /= 10;
                } while (sum > 0);
                
                

            }

            else
            {
                sum1 = sum;
            }
           
            //Console.WriteLine("The sum is {0}", sum1);
            //return sum1;

        }

        public void DisplayData()
        {
            
            Console.WriteLine("The number is {0} ", number);
            Console.WriteLine("The sum is {0}",sum1);
           

        }

        public static void Main()
        {
            SingleDigitSum objbin = new SingleDigitSum();

            objbin.ReadData();
            objbin.DigitSum();
          
            objbin.DisplayData();
          




            Console.ReadKey();
        }
    }
}
