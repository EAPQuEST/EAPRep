using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Arrays
{
    class BinarySearch
    {
        int number,limit;
        
        int[] values = new int[100];
        

        public void ReadData()
        {
            Console.WriteLine("Enter the limit");
            limit = Convert.ToInt32(Console.ReadLine());

           

            Console.WriteLine("Enter the Element");
            for (int i = 0; i < limit; i++)
            {

                values[i] = Convert.ToInt32(Console.ReadLine());


            }


            Console.WriteLine("Enter the number to be searched");
            number = Convert.ToInt32(Console.ReadLine());


        }

        public void SearchData()
        {
            int low, high, middle;
            int tmp;
            for (int i = 0; i < limit; i++)
            {
                for (int j = i + 1; j < limit; j++)
                {
                    if (values[i] > values[j])
                    {
                        tmp = values[i];
                        values[i] = values[j];
                        values[j] = tmp;
                    }
                }
            }

            low = 0;
            high = limit - 1;
           
            bool flag = false;
            do
            {
              
                middle = (low + high) / 2;

                if (values[middle] == number)
                {

                    flag = true;
                    break;
                }
                else if (number< values[middle])
                {
                    high = middle - 1;
                  
                }
                else
                {
                    low = middle + 1;
                   
                }
            } while (low <= high);

            if (flag)
            {
                Console.WriteLine("The given number {0} is Present ", number);
            }
            else
            {
                Console.WriteLine("The given number {0} is Not Present ", number);
            }

        }
        
        

       

        public static void Main()
        {
            BinarySearch s = new BinarySearch();
            s.ReadData();
            s.SearchData();
        
            Console.ReadKey();

        }
    }
}
