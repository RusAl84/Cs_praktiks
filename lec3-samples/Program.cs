using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace lec3_samples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int x = 100 * 1000;
            string text = "";



            for (int i = 1; i <= x; i++)
            {
                text += "Привет мир!\nПока мир...";

            }

            Stopwatch stopWatch1 = Stopwatch.StartNew();
            string writePath = @"D:\1\hta.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }

                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Дозапись");
                    sw.Write(4.5);
                }
                Console.WriteLine("Запись выполнена синхронно");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            stopWatch1.Stop();
            TimeSpan ts1 = stopWatch1.Elapsed;
            Console.WriteLine(ts1);
            Stopwatch stopWatch2 = Stopwatch.StartNew();
            string writePath2 = @"D:\1\hta2.txt";
            try
            {
                using (StreamWriter sw2 = new StreamWriter(writePath2, false, System.Text.Encoding.Default))
                {
                    await sw2.WriteLineAsync(text);
                }

                using (StreamWriter sw2 = new StreamWriter(writePath2, true, System.Text.Encoding.Default))
                {
                    await sw2.WriteLineAsync("Дозапись");
                    await sw2.WriteAsync("4,5");
                }
                Console.WriteLine("Запись выполнена асинхронно");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            stopWatch2.Stop();
            TimeSpan ts2 = stopWatch2.Elapsed;
            Console.WriteLine(ts2);
            Console.ReadLine();
        }
    }
}
