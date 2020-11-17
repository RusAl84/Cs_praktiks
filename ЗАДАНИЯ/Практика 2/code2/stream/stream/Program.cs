using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace stream
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            //FileInfo f = new FileInfo(@"c:\audiodec.txt");
            //Stream  stream = f.Open(FileMode.Open);
            //DumpStream(stream);

            //#2
            //FileStream theFile = File.Open(@"C:\boot.ini", FileMode.Open, FileAccess.Read);

            //StreamReader rdr = new StreamReader(theFile);
            //Console.Write(rdr.ReadToEnd());
            //rdr.Close();
            //theFile.Close();

            // #3
            //StreamReader rdr = File.OpenText(@"C:\boot.ini");
            //Console.Write(rdr.ReadToEnd());
            //rdr.Close();

            // #4
            //Console.WriteLine(File.ReadAllText(@"C:\boot.ini"));


            //#5
            //StreamReader rdr = File.OpenText(@"C:\boot.ini");

            //// Обнаружив слово «boot», уведомить пользователя
            //while (!rdr.EndOfStream)
            //{
            //    string line = rdr.ReadLine();
            //    if (line.Contains("boot"))
            //    {
            //        // Обнаружив слово «boot», уведомить пользователя
            //        // и прекратить чтение файла.
            //        Console.WriteLine("Found boot:");
            //        Console.WriteLine(line);
            //        break;
            //    }
            // }
            //// Clean Up
            //rdr.Close();


        }
        static void DumpStream(Stream theStream)
        {
            // Установить курсор на начало потока theStream.Position = 0;

            // Обработать поток в цикле и показать его содержимое
            while (theStream.Position != theStream.Length)
            {
                Console.WriteLine("{0:x2}", theStream.ReadByte());
            }
        }
        static void AppendToStream(Stream theStream, byte[] data)
        {
            // Установить курсор в конец потока 
            theStream.Position = theStream.Length;

            //Добавить байты
            theStream.Write(data, 0, data.Length);
        }

    }
}
