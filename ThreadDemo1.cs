using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleTestApp.Thread1
{
    class ThreadDemo1
    {
        public static void Main()
        {
            Table table5 = new Table(5,3000);
            Thread thread1 = new Thread(table5.GenerateTable);
            thread1.Start();

            Table table10 = new Table(10,3000);
            Thread thread2 = new Thread(table10.GenerateTable);
            thread2.Start();

            Console.ReadKey();
        }
    }
    class Table
    {
        private int _number;
        private int _sleep;
        public Table(int target,int sleep)
        {
             _number=target;
            _sleep = sleep;
        }
        public void GenerateTable()
        {
            //Thread.Sleep(_sleep);
          for(int iteration = 1; iteration <= 10; iteration++)
            {
                Console.WriteLine("{0} * {1} ={2}", iteration, _number, (iteration * _number));
                Thread.Sleep(_sleep);
            }
        }
    }
}
