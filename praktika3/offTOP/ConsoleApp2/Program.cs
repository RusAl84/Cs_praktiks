using System;
using System.IO;

namespace ConsoleApp2
{
  class Program
  {
    static void Main(string[] args)
    {
      string file_name = @"D:\Documents\1.txt";
      Console.WriteLine(file_name);
      StreamWriter file = new StreamWriter(file_name);
      for (int i = 0; i < 1*1000*1000; i++)
      {
        file.WriteLine($"Sasha {i} ml ");
      }
      file.Close();
      //Console.WriteLine("Считать файл?");
      //Console.ReadLine();
      //StreamReader rfile= new StreamReader(file_name);
      //for (int i = 0; i < 1000; i++)
      //{
      //  Console.WriteLine(rfile.ReadLine());
      //}

    }
  }
}
