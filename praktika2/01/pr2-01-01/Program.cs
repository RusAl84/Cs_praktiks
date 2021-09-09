using System;
using System.IO;

namespace pr2_01_01
{
  class Program
  {
    static void ShowDirectory(DirectoryInfo dir)
    {
      // Показать все файлы
      foreach (FileInfo file in dir.GetFiles())
      {
        Console.WriteLine($"FILE: {file.FullName}");
      }
      // Показать все директории
      foreach (DirectoryInfo subDir in dir.GetDirectories())
      {
        ShowDirectory(subDir);
      }
    }

    static void Main(string[] args)
    {
      // C#
      //DirectoryInfo dir = new DirectoryInfo(Environment.SystemDirectory); 
      DirectoryInfo dir = new DirectoryInfo(@"d:\temp"); 
      ShowDirectory(dir);
    }
  }
}
