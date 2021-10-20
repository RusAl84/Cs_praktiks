using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ServerASPCORE
{
  public class Program
  {
    public static MessangerLibrary.MessagesMasClass listOfMessages = new MessangerLibrary.MessagesMasClass();
    public static string FileName= @"d:\MessagesJSON.txt";
    public static void Main(string[] args)
    {
      listOfMessages.LoadFromFile(FileName);
      CreateHostBuilder(args).Build().Run();
      //listOfMessages.SaveToFile(FileName);


    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
              webBuilder.UseStartup<Startup>();
            });
  }
}
