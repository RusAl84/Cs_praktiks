using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace encod
{
    class Program
    {
        static void Main(string[] args)
        {
            // #1
            //// Получить корейскую кодировку
            //Encoding e = Encoding.GetEncoding("Korean");

            //// Преобразовать байты ASCII-кодов в корейскую кодировку
            //byte[] encoded;
            //encoded = e.GetBytes("Hello, world!");
            //// Отобразить байты в заданной кодировке 
            //for (int i = 0; i < encoded.Length; i++)
            //Console.WriteLine("Byte {0}: {1}", i, encoded[i]);

            // #2 Проверка поддерживаемых кодовых страниц
            //EncodingInfo[] ei = Encoding.GetEncodings(); 
            //foreach (EncodingInfo e in ei)
            //    Console.WriteLine("{0}: {1}, {2}", e.CodePage, e.Name, e.DisplayName);

            // #3 Определение кодировки при записи файла

            //StreamWriter swUtf7 = new StreamWriter("utf7.txt", false, Encoding.UTF7);
            //swUtf7.WriteLine("Hello, World!");
            //swUtf7.Close();

            //StreamWriter swUtf8 = new StreamWriter("utf8.txt", false, Encoding.UTF8);
            //swUtf8.WriteLine("Hello, World!");
            //swUtf8.Close();

            //StreamWriter swUtf16 = new StreamWriter("utf16.txt", false, Encoding.Unicode);
            //swUtf16.WriteLine("Hello, World!");
            //swUtf16.Close();
            //StreamWriter swUtf32 = new StreamWriter("utf32.txt", false, Encoding.UTF32);
            //swUtf32.WriteLine("Hello, World!");
            //swUtf32.Close();

            // ПРИМЕЧАНИЕ  Выбор кодировки
            //Если вы не знаете, какую кодировку выбрать при создании файла, оставьте кодировку по умолчанию, в .NET Framework это UTF-16.

            //#4 Определение кодировки при чтении файла

            //string fn = "file.txt";
            //StreamWriter sw = new StreamWriter(fn, false, Encoding.UTF7);
            //sw.WriteLine("Здравствуй, МИР!");
            //sw.Close();
            //StreamReader sr = new StreamReader(fn, Encoding.UTF7);
            //Console.WriteLine(sr.ReadToEnd());
            //sr.Close();

            //#5
            //string fn = "file.txt";
            //StreamWriter sw = new StreamWriter(fn, false, Encoding.UTF7);
            //sw.WriteLine("Hello, World!");
            //sw.Close();
            //StreamReader sr = new StreamReader(fn);
            //Console.WriteLine(sr.ReadToEnd());
            //sr.Close();



        }
    }
}
