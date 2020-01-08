#define FOOL1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace ConsoleTestApp.Strings
{
    class ConditionalAttributeDemo
    {
        public static void Main()
        {
            Greet.GreetDebug();
            Greet.GreetTrace();
            Console.ReadKey();
        }
    }
    class Greet
    {
        [Conditional("DEBUG")]

        public static void GreetDebug()
        {
            Console.WriteLine("Greeting from Debug");
        }

        [Conditional("FOOL1")]

        public static void GreetTrace()
        {
            Console.WriteLine("Greeting from Trace");
        }
    }
}
