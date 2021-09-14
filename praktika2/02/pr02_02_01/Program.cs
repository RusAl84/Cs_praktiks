using System;
using System.IO;

namespace pr02_02_01
{
  class Program
  {
    static void spam()
    {
      Random rnd = new Random();
      int value = rnd.Next();
      StreamWriter writer = File.CreateText(@"D:\temp\newfile" + value.ToString() + ".txt");
      for (int i = 0; i < 100e6; i++)
      {
        writer.WriteLine("У Валентина выросла монобровь;)");
      }
      writer.Close();
    }

    static void Main(string[] args)
    {
      for (int i = 0; i < 10; i++)
        spam();

    }
  }
}
