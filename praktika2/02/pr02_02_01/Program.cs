using System;
using System.IO;

namespace pr02_02_01
{
  class Program
  {
    //    static void spam()
    //    {
    //;
    //    }
    static void Main(string[] args)
    {
      StreamWriter writer = File.CreateText(@"D:\temp\newfile" + DateTime.Now.ToString("h_mm_ss") + ".txt");
      for (int i = 0; i < 100e6; i++)
      {
        writer.WriteLine("Глеб слушает Ваолерия Меладзе и ФАНАТЕЕТ;)");
      }
      writer.Close();
     } 
  }
}
