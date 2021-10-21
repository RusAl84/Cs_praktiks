using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server
{
  public class Program
  {
    public List<ClassLib.MessageClass> listOfMessages = new List<ClassLib.MessageClass>();


    public static void Main(string[] args)
    {
      ClassLib.MessageClass mes = new ClassLib.MessageClass();
      mes.userName = "Artem";
      mes.messageText = " Dobrij den";
      mes.timeStamp = DateTime.Now.ToString();
      listOf
      CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
              webBuilder.UseStartup<Startup>();
            });
  }
}
