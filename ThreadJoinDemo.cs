using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleTestApp.Thread1
{
    class ThreadJoinDemo
    {
        public static void Main()
        {
            Thread thread1 = Thread.CurrentThread;
            thread1.Name = "Main Thread";
            Console.WriteLine("Main Method : " + thread1.Name);

            ThreadStart threadStart1 = new ThreadStart(ChildThread1);

            Thread subThread1 = new Thread(ChildThread1);
            Thread subThread2 = new Thread(ChildThread2);
            subThread1.Start();
            subThread2.Start();

            subThread1.Join();
            subThread2.Join();
            Console.WriteLine("Main Method Completed ");
            
            Console.WriteLine();
            Console.ReadKey();

        }






        public static void ChildThread1()
        {
            Console.WriteLine("I am in Child Thread 1");

            for(int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Child thread1 Completed");
        }



        public static void ChildThread2()
        {
            Thread.Sleep(3000);
            Console.WriteLine("I am in Child Thread 2");

            for (int i = 11; i <= 50; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Child thread2 Completed");

        }
    }
}
