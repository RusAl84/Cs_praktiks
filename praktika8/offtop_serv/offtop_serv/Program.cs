using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace offtop_serv
{
  public class Program
  {

    public static List<ClassLib.MessageClass> listOfMessages = new List<ClassLib.MessageClass>();

    public static void Main(string[] args)
    {
      ClassLib.MessageClass mes = new ClassLib.MessageClass();
      mes.userName = "������";
      mes.messageText = "������ ����!";
      mes.timeStamp = DateTime.Now.ToString();


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
