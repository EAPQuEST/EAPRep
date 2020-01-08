using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleTestApp.FileStream1
{
    class SerialzationDemo
    {
        public static void Main()
        {
            FileStream stream = new FileStream("C:\\Users\\1028283\\Desktop\\data\\account.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Account account1 = new Account(101, 240);

            formatter.Serialize(stream, account1);

            stream.Close();

            Console.WriteLine("Account object serialized");


            Console.WriteLine("Account object deserialized");
            Deserialized();
            Console.ReadLine();
        }

        public static void Deserialized()
        {
                    FileStream stream = new FileStream("C:\\Users\\1028283\\Desktop\\data\\account.txt", FileMode.OpenOrCreate);
                    BinaryFormatter formatter = new BinaryFormatter();

                    Account account = (Account)formatter.Deserialize(stream);
                    account.Display();

                    stream.Close();

        }


        
    }

    [Serializable]
    class Account
    {
        public int ID { get; set; }
        public int Balance { get; set; }
      
        public Account(int id,int balance)
        {
            ID = id;
            Balance = balance;

        }

        public  void Display()
        {
            Console.WriteLine("ID :" + ID);
            Console.WriteLine("Balance :" + Balance);
        }
    }
}
