using System;
using System.IO;
using System.Net;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            while (true) { 
                Console.WriteLine("Пожертвования:");
                str1 = Console.ReadLine();
                WebRequest req = WebRequest.Create("http://localhost:5000/api/mirea/"+str1);
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                string Out = sr.ReadToEnd();
                sr.Close();
                Console.WriteLine(Out);
                Console.WriteLine("Продолжить ввод данных?");
                str1 = Console.ReadLine();
                if (str1 == "n")
                    break;
            }

        }
    }
}
