using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BinaryWriter_
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            //FileStream newFile = File.Create(@"c:\somefile.bin");
            //BinaryWriter writer = new BinaryWriter(newFile);
            //long number = 100;
            //byte[] bytes = new byte[] { 10, 20, 50, 100 };
            //string s = "hunger";
            //writer.Write(number);
            //writer.Write(bytes);
            //writer.Write(s);
            //writer.Close();

            //#2

            //FileStream newFile = File.Open(@"c:\somefile.bin", FileMode.Open);

            //BinaryReader reader = new BinaryReader(newFile);
            //long number = reader.ReadInt64();
            //byte[] bytes = reader.ReadBytes(4);
            //string s = reader.ReadString();
            //reader.Close();
            //Console.WriteLine(number); foreach (byte b in bytes)
            //{
            //    Console.Write("[{0}]", b);
            //}
            //Console.WriteLine();
            //Console.WriteLine(s);




        }
    }
}
