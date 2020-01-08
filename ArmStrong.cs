using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class ArmStrong
    {
        int number;
        double sum;
        string result;

        public void ReadData()
        {
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayData()
        {


            Console.WriteLine("The given number {0} is {1}",number,result);


        }






        public void Arm()
        {
            int n = number;
            int lastDigit;
            
            int exp = 0;
            int original = number;



            while (n > 0)
            {
                lastDigit = n % 10;
                exp+= 1;
                n /= 10;
            }

           

            while (original > 0)
            {
                lastDigit = original % 10;
                original /= 10;
                double pow = Math.Pow(lastDigit, exp);

                sum = sum + pow;




                
               

            }
        }

            public void Check()
            {
                if (sum == number)
                {
                    result = "Armstrong";
                }

                else
                {
                    result = "Not Armstrong ";
                }



            }




        

        public static void Main()
        {
            ArmStrong objarm = new ArmStrong();

            objarm.ReadData();
            objarm.Arm();
            objarm.Check();
            objarm.DisplayData();


            Console.ReadKey();
        }
    }
}
