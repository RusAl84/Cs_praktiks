using System;
using System.IO;

namespace pr02_02_01
{
  class Program
  {
    static void spam()
    {

    }

    static void Main(string[] args)
    {
      StreamWriter writer = File.CreateText(@"D:\temp\newfile.txt");

        writer.WriteLine(" монобровь;)");
      writer.Close();

    }
  }
}
