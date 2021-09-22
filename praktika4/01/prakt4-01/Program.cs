using System;
using System.Collections;

namespace prakt4_01
{
  class Program
  {

      static void Main(string[] args)
      {
        ArrayList myList = new ArrayList() { "GOSHA"};
        myList.Add("EZHIK");
        myList.Add("MAKSIM");
        myList.Add("HENESSY");
      myList.Add("Misha");
      foreach (string item in myList)
        {
          Console.WriteLine("Unsorted: {0}", item.ToString());
        }
      // Сортировка при помощи стандартного объекта сравнения 
      myList.Sort();
      //myList.Reverse();
      foreach (string item in myList)
      {
        Console.WriteLine("   Sorted: {0}", item);
      }

    }

  }
}
