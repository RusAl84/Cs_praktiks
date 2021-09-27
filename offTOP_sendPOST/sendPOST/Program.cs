using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace sendPOST
{
  class Program
  {
    static async Task Main(string[] args)
    {
      WebRequest request = WebRequest.Create("https://synonymonline.ru/assets/json/synonyms.json");
      request.Method = "POST";
      string sName = "word=ЕЖИК";
      byte[] byteArray = Encoding.UTF8.GetBytes(sName);
      request.ContentType = "application/x-www-form-urlencoded";
      request.ContentLength = byteArray.Length;

      using (Stream dataStream = request.GetRequestStream())
      {
        dataStream.Write(byteArray, 0, byteArray.Length);
      }
      string strdata = "";
      WebResponse response = await request.GetResponseAsync();
      using (Stream stream = response.GetResponseStream())
      {
        using (StreamReader reader = new StreamReader(stream))
        {
          strdata = reader.ReadToEnd();
        }
      }
      response.Close();

      Console.WriteLine(strdata);
      //object jsondata = JsonConvert.SerializeObject(strdata);
      //Console.WriteLine(jsondata);
      //object synonyms = jsondata{"synonyms"};
      ////foreach ( string item in )
      //{

      //}
    }
  }
}
