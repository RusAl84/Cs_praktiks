using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CS
{
  class Program
  {
    static void Main(string[] args)
    {
      FileSystemWatcher watcher =
        new FileSystemWatcher(Environment.SystemDirectory);

      // Watch all .ini files for
      // changes to size or attributes only
      // but in every subdirectory
      watcher.Filter = "*.ini";
      watcher.IncludeSubdirectories = true;
      watcher.NotifyFilter =
        NotifyFilters.Attributes | NotifyFilters.Size;

      // Register for event
      watcher.Changed +=
        new FileSystemEventHandler(watcher_Changed);

      // Start the Events
      watcher.EnableRaisingEvents = true;

      // Read for a keypress to exit the app
      Console.Read();
    }

    static void watcher_Changed(object sender,
      FileSystemEventArgs e)
    {
      Console.WriteLine("Changed: {0}", e.FullPath);
    }
  }
}
