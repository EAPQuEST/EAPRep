using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class NPrime
    {
        int number;

        public void ReadData()
        {
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());
        }

        public void Find()
        {
            int count = number ;
            int i = 2;
            int j;
            while (count!=0)
            {
                
                for (j = 1; j <= count; j++)
                {

                    bool flag = true;
                    

                    for (int no = 2; no < i; no++)
                    {

                        if (i % no == 0)
                        {


                            flag = false;

                            break;


                        }

                    }

                    if (flag)
                    {



                        count--;
                        Console.WriteLine("{0} is Prime", i);
                        

                    }
                    
                    i++;
                   

                }
            }
            

        }
        public static void Main(string[] args)
        {
           NPrime objprime2 = new NPrime();

            objprime2.ReadData();
            objprime2.Find();
            //objprime.DisplayData();
            Console.ReadKey();

        }


    }
}
