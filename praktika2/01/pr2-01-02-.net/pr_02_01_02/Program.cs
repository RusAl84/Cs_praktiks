﻿using System;
using System.IO;

namespace pr_02_01_02
{
  class Program
  {
    static void watcher_Changed(object sender, FileSystemEventArgs e)
    {
      Console.WriteLine("Changed: {0}", e.FullPath);
    }

    static void Main(string[] args)
    {
      // C#
      FileSystemWatcher watcher = new FileSystemWatcher(@"D:\temp");
      watcher.Filter = "*.*";
      watcher.IncludeSubdirectories = true;
      watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.Size;
      watcher.Changed += new FileSystemEventHandler(watcher_Changed);
      Console.ReadKey();


    }
  }
}
