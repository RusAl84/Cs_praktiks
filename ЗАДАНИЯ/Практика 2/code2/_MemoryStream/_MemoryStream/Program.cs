using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _MemoryStream
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryStream memStrm = new MemoryStream();
            StreamWriter writer = new StreamWriter(memStrm);
            writer.WriteLine("Hello");
            writer.WriteLine("Goodbye");


            // Приказать объекту записи переписать данные // в поток
            writer.Flush();

            // Создать файловый поток
            FileStream theFile = File.Create(@"c:\inmemory.txt");

            // Переписать содержимое потока в памяти в файл целиком 
            memStrm.WriteTo(theFile);
            // Освободить ресурсы
            writer.Close();
            theFile.Close();
            memStrm.Close();

        }
    }
}
