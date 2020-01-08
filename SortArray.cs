using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Arrays
{
    class SortArray
    {

        int number;
        int[] values = new int[100];
       






        public void ReadMatrix()
        {
            Console.WriteLine("Enter the limit");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Element");
            for (int i = 0; i < number; i++)
            {

                values[i] = Convert.ToInt32(Console.ReadLine());
     

            }

            

        }

        public void Sort()
        {
          
            int tmp;
            for (int i = 0; i < number; i++)
            {
                for(int j = i+1; j < number; j++)
                {
                    if (values[i] > values[j])
                    {
                        tmp = values[i];
                        values[i] = values[j];
                        values[j] = tmp;
                    }
                }
            }
            


        }


        public void DisplayMatrix()
        {
            Console.WriteLine("Sorted Array");
            for (int j = 0; j < number; j++)
            {
                Console.Write(values[j]+" \t");
            }

        }

        public static void Main()
        {
            SortArray s = new SortArray();
            s.ReadMatrix();
            s.Sort();
            s.DisplayMatrix();
            Console.ReadKey();
        }
    }
}
