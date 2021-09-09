using System;
using System.IO;

namespace pr02_02_01
{
  class Program
  {

    static void Main(string[] args)
    {
      StreamWriter writer = File.CreateText("D:\\temp\\newfile.txt");
      //for (int i = 0; i< 100e6; i++)
      //{
      writer.WriteLine("Сережа сбрил брови;)");
      //}
      writer.Close();
    }
}
