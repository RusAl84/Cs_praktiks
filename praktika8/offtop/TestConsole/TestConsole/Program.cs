using Newtonsoft.Json;
using System;

namespace TestConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      MessangerLibrary.MessagesMasClass listOfMessages = new MessangerLibrary.MessagesMasClass();

      string jsonString = JsonConvert.SerializeObject(listOfMessages.data[0]);
      Console.WriteLine(jsonString);
    }
  }
}
