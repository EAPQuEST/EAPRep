using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.CollectionClass
{
    class HashTable
    {
        public static void Main()
        {
            HashTableDemo();
        }
        public static void HashTableDemo()
        {
            
            Hashtable ht = new Hashtable();
            ht.Add("001", "Zara Ali");
            ht.Add("002", "Abida Rehman");
            ht.Add("003", "Joe Holzer");
            ht.Add("004", "M.Arif");
            if (ht.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student is in the list");
            }
            else
            {
                ht.Add("008","M.Arif");
            }
            ICollection key = ht.Keys;
            foreach (string k in key)
            {
                Console.WriteLine(k+ "  "+ht[k]);
            }


            Console.ReadKey();
        }
    }
}
