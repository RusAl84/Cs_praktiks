using System;
using System.IO;
using System.Net;
using System.Text.Json;
using Server;


namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите username:");
            //string str1 = Console.ReadLine();
            message msg = new message();
            msg.username = "Sasha suhoy";
            msg.text = "Love C#";
            string json = JsonSerializer.Serialize(msg);

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:5000/api/chat");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }


            for (int id = 0; id < 10; id++)
            {
                GetDataAsync(id);
            }

            Console.ReadKey();
        }

        static async System.Threading.Tasks.Task GetDataAsync(int id)
        {
            //WebRequest request = WebRequest.Create("http://localhost:5374/Home/PostData?sName=Иван Иванов&age=31");
            WebRequest request = WebRequest.Create("http://localhost:5000/api/chat/"+ id.ToString());
            WebResponse response = await request.GetResponseAsync();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    //Console.WriteLine(reader.ReadToEnd());
                    message msg1 = JsonSerializer.Deserialize<message>(reader.ReadToEnd());
                    Console.WriteLine(msg1.username + " " + msg1.text);
                }
            }
            response.Close();
        }
    }
}
