using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleTestApp.SynchronizationDemo
{
    class SynchronizationDemo1
    {
        public static void Main()
        {
            Table table5 = new Table(5, 100);
            Thread thread1 = new Thread(table5.GenerateTable);
            Thread thread2 = new Thread(table5.GenerateTable);

           // Table table10 = new Table(10, 100);
            
            thread1.Start();
            thread2.Start();

            Console.ReadKey();
        }
    }
    class Table
    {
        private int _number;
        private int _sleep;
        public Table(int target, int sleep)
        {
            _number = target;
            _sleep = sleep;
        }
        public void GenerateTable()
        {
            Thread.Sleep(_sleep);
            lock (this)
            {
                for (int iteration = 1; iteration <= 10; iteration++)
                {
                    //Console.WriteLine("{0} * {1} ={2}", iteration, _number, (iteration * _number));
                    Console.WriteLine(iteration);
                    Thread.Sleep(100);
                }
            }

        }
    }
}
        