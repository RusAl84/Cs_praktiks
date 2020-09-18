using System;
using System.IO;
using System.Text;

namespace pr3_01_upr2
{
  class Program
  {
    static void Main(string[] args)
    {
      StreamReader sr= new StreamReader(@"boot.ini");
      StreamWriter sw = new StreamWriter(@"boot - utf7.txt", false, Encoding.UTF7);
      sw.WriteLine(sr.ReadToEnd());
      sw.Close();
      sr.Close();

    }
  }
}
