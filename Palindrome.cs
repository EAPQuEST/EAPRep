using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Strings
{
    class Palindrome
    {
        string word;

        public void ReadData()
        {
            Console.WriteLine("Enter the String");
            word = Console.ReadLine();
        }

        public void Check()
        {
            string copy = word;
            int length = word.Length;
            int middle = length / 2;
            string first = word.Substring(middle);
            Console.WriteLine(first);



        }

        public static void Main()
        {
            Palindrome p = new Palindrome();
            p.ReadData();
            p.Check();
            Console.ReadKey();
        }
    }
}
