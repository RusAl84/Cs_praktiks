using System;
using System.Collections;

namespace dict_sample
{
  class Program
  {
    static void Main(string[] args)
    {
      Hashtable lookup = new Hashtable();

      lookup["0"] = "ноль";
      lookup["1"] = "One";
      lookup["2"] = "два";
      lookup["3"] = "три";
      lookup["4"] = "Four";
      lookup["5"] = "Five";
      lookup["6"] = "шесть";
      lookup["7"] = "семь";
      lookup["8"] = "Eight";
      lookup["9"] = "девять";
      lookup["+"] = "плюс";

      string ourNumber = "+7926-377-2622";
      foreach (char c in ourNumber)
      {
        string digit = c.ToString(); 
        if (lookup.ContainsKey(digit))
        {
          Console.WriteLine(lookup[digit]);
        }
      }

    }
  }
}
