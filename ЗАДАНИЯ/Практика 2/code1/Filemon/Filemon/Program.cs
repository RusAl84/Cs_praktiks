using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Filemon
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher(); watcher.Path = @"c:\";
            // Зарегистрировать обработчики событий 
            watcher.Created += new FileSystemEventHandler(watcher_Changed);
            watcher.Deleted += new FileSystemEventHandler(watcher_Changed);
            watcher.Renamed += new RenamedEventHandler(watcher_Renamed);


            // Начать мониторинг
            watcher.EnableRaisingEvents = true;
            Console.Read();

        }
        // Обработчик события
        static void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Directory changed({0}): {1}", e.ChangeType, e.FullPath);
        }
        // Обработчик события 
        static void watcher_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("Renamed from {0} to {1}", e.OldFullPath, e.FullPath);
        }



    }
}
