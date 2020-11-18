using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Server
{
    public class Program
    {
    public static MessagesClass ms;
    public static SessionsClass Sessions;

    public static void Main(string[] args)
        {
            ms = new MessagesClass();  //обработка сообщений
            Sessions = new SessionsClass(); // хранение токенов логинов и паролей
            //Sessions.addValera();
            Sessions.LoadFromFile();
           // Console.WriteLine(Sessions.list_tokens.Count);
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
