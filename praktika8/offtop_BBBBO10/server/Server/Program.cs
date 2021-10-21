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
    public static List<ClassLib.MessageClass> listOfMessages = new List<ClassLib.MessageClass>();

    public static void Main(string[] args)
    {
      ClassLib.MessageClass mes = new ClassLib.MessageClass();
      mes.userName = "System";
      mes.textMessage = "Server is running";
      mes.timeStamp = DateTime.Now.ToString();
      listOfMessages.Add(mes);
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
