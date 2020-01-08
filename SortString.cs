using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Strings
{
    class SortString
    {

        int limit;

        String[] word = new String[20];


        public void ReadData()
        {
            Console.WriteLine("Enter the limit");
            limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the string");
            ;

            for (int i = 0; i < limit; i++)
            {

                word[i] = (Console.ReadLine());


            }
        }
        public void Sort()
        {

            for (int i = 0; i < limit - 1; i++)
            {
                for (int j = i + 1; j < limit; j++)
                {
                    if ((word[i].CompareTo(word[j]) > 0))
                    {

                        string temp = string.Copy(word[i]);
                        word[i] = string.Copy(word[j]);
                        word[j] = string.Copy(temp);


                    }
                }

            }

        }


        public void DisplayData()
        {
            Console.WriteLine("String in sorted order:  ");
            for(int j = 0; j < word.Length; j++)
            {
                Console.WriteLine("{0}", word[j]);

            }
        }

        public static void Main()
        {
            SortString s = new SortString();
            s.ReadData();
            s.Sort();
            s.DisplayData();
            Console.ReadKey();
        }
    }
}
