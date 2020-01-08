using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Strings
{
    class CodeGeneration
    {

        string code="Stu101";
        string result;



        public void ReadData()
        {
            Console.WriteLine("Enter the string in format Stu101 ");
            code = Console.ReadLine();

        }

        public void Generation()
        {
            string number,letter;
           
            int temp;
            number = code.Substring(3);
            

            temp = Convert.ToInt32(number) + 1;
           

            letter = code.Substring(0,3);
            result = String.Concat(letter, temp);
           
           






        }

        public void Display()
        {
            Console.WriteLine("The generated string is {0}", result);
        }

        public static void Main()
        {
            CodeGeneration c = new CodeGeneration();
            c.ReadData();
            c.Generation();
            c.Display();
            Console.ReadKey();
        }
    }
}
