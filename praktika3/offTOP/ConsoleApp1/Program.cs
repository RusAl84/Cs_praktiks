using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] text ={"Макс",
        "C++",
        " +79263772622",
        " 89263772622",
        " (926)3772622" };

      foreach (string item in text)
      {
        string pattern = @"\d{7}";
        if (Regex.IsMatch(item, pattern))
        {
          //Console.WriteLine($"{item} это телефон"); 
          Console.WriteLine(item +" это телефон");
        }
        else
        {
            Console.WriteLine(
            string.Format("{0} это НЕ телефон", item)
            );
        }

      }
      
    }
  }
}
