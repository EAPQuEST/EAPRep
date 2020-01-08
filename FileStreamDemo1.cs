using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleTestApp.FileStream1
{
    class FileStreamDemo1
    {
        public static void Main(string[] args)
        {
            FileStream datafile = new FileStream("C:\\Users\\1028283\\Desktop\\data\\data5.txt", FileMode.OpenOrCreate);
            for(int ii = 65; ii <= 90; ii++)
            {
                datafile.WriteByte((byte)ii);
            }
            datafile.Close();
            Console.WriteLine("File Created Successfully...");
            Console.WriteLine("File Read Operation.....");

            FileStream dataOutfile = new FileStream("C:\\Users\\1028283\\Desktop\\data\\data5.txt", FileMode.OpenOrCreate);
            int i = 0;
            while((i = dataOutfile.ReadByte()) != -1)
            {
                Console.Write((char)i);
            }
            dataOutfile.Close();
            Console.ReadLine();
        }
    }
}
