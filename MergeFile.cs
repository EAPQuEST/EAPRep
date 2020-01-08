using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleTestApp.FileStream1
{
    class MergeFile
    {
        public static void Main()
        {
           

            string[] datafile1 = File.ReadAllLines("C:\\Users\\1028283\\Desktop\\data\\data2.txt");
            string[] datafile2 = File.ReadAllLines("C:\\Users\\1028283\\Desktop\\data\\data3.txt");

            using (StreamWriter writer = File.CreateText("C:\\Users\\1028283\\Desktop\\data\\merged.txt"))
            {
                int line = 0;
                while (line < datafile1.Length || line < datafile2.Length)
                {
                    if (line < datafile1.Length)
                    {
                        writer.WriteLine(datafile1[line]);
                    }
                        
                    if (line < datafile2.Length)
                    {
                        writer.WriteLine(datafile2[line]);
                    }
                        
                    line++;
                }
            }


        }


    }
}
