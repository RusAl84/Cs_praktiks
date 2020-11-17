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
      DirectoryInfo dir = new DirectoryInfo(Environment.SystemDirectory);

      ShowDirectory(dir);
    }

    static void ShowDirectory(DirectoryInfo dir)
    {
      // Show Each File
      foreach (FileInfo file in dir.GetFiles())
      {
        Console.WriteLine("File: {0}", file.FullName);
      }

      // Go through sub-directories
      // recursively
      foreach (DirectoryInfo subDir in dir.GetDirectories())
      {
        ShowDirectory(subDir);
      }

    }
  }
}
