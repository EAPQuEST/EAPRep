using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.CollectionClass
{
    class ListDemo
    {
        public static void Main(string[] args)
        {
            List<String> names = new List<String>();
            names.Add("Sonoo Jaiswal");
            names.Add("Ankit");
            names.Add("Peter");
            names.Add("Irfan");
            names.Add("Ankit");
            names.Remove("Peter");
            names.Insert(0, "Gokul");
           // names.Add(123);
            // names.Add(new Message());
            names.Reverse();
            names.Sort();
            names.RemoveRange(2, 2);
            names.RemoveAt(0);


            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }

        //public static void HashTableDemo()
        //{

        //    Hashtable ht = new Hashtable();
        //    ht.Add("001", "Zara Ali");
        //    ht.Add("002", "Abida Rehman");
        //    ht.Add("003", "Joe Holzer");
        //    ht.Add("004", "M.Arif");
        //    if (ht.ContainsValue("Nuha Ali"))
        //    {
        //        Console.WriteLine("This student is in the list");
        //    }
        //    else
        //    {
        //        ht.Add("008,M.Arif");
        //    }
        //    ICollection key = ht.Keys;
        //    foreach (string k in key)
        //    {
        //        Console.WriteLine(k + ":" + ht[k]);
        //    }
        //}

     }
}
