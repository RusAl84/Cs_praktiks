using System;
using System.IO;
using System.Net;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер пожертвования:");
            string str1 = Console.ReadLine();
            System.Net.WebRequest reqGET = System.Net.WebRequest.Create(@"http://localhost:5000/api/mirea/"+str1);
            System.Net.WebResponse resp = reqGET.GetResponse();
            System.IO.Stream stream = resp.GetResponseStream();
            System.IO.StreamReader sr = new System.IO.StreamReader(stream);
            string s = sr.ReadToEnd();
            Console.WriteLine(s);
        }

        static async System.Threading.Tasks.Task GetDataAsync(int i)
        {
            //WebRequest request = WebRequest.Create("http://localhost:5374/Home/PostData?sName=Иван Иванов&age=31");
            WebRequest request = WebRequest.Create("http://localhost:5000/api/mirea/500");
            WebResponse response = await request.GetResponseAsync();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            response.Close();
        }
    }
}
