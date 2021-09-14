using System;
using System.IO;

namespace pr1_02_02
{
  class Program
  {
    static void Main(string[] args)
    {
      StreamReader reader = File.OpenText(@"d:\temp\2.txt");
      string contents = reader.ReadToEnd();
      reader.Close();
      contents = contents.Replace("НИКИТА", "СЕРЁЖА");
      //contents = contents.ToUpper();
      Console.WriteLine(contents);
      Console.ReadKey();

    }
  }
}
