using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerASPCORE
{
  public class Program
  {
    public static List<MessangerLib.MesaageClass> listOfMessages = new List<MessangerLib.MesaageClass>();
    public static void Main(string[] args)
    {
      MessangerLib.MesaageClass mes = new MessangerLib.MesaageClass() { userName = "System", messageText = "System is running...", timeStamp = DateTime.Now.ToString() };
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
