using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] text ={"Sasha",
        "LOVE",
        "Contex",
        "C++",
        "Contex",
        " +79263772622",
        " 89263772622",
        " (926)3772622" };

     //string str56 = "c:\\vazelin\\nSasha\\nude_photos";
     //string str56 = $"stringi {text[0]} velikolepni ";
     //Console.WriteLine(str56);



      foreach (string item in text)
      {
        string pattern = @"\d{7}";
        if (Regex.IsMatch(item, pattern))
        {
 
          Console.WriteLine(item +" это телефон");
        }
        else
        {
            Console.WriteLine(
            string.Format("{0} это НЕ телефон", item)
            );
        }
      }
      Console.ReadLine();
    }
  }
}
