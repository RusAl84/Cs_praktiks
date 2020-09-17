using System;
using System.Collections;

namespace prakt4_01
{
  class Program
  {

      static void Main(string[] args)
      {
        ArrayList myList = new ArrayList();
        myList.Add("First");
        myList.Add("Second");
        myList.Add("Third");
        myList.Add("Fourth");
        foreach (string item in myList)
        {
          Console.WriteLine("Unsorted: {0}", item);
        }
        // Сортировка при помощи стандартного объекта сравнения 
        myList.Sort();
        foreach (string item in myList)
        {
          Console.WriteLine("   Sorted: {0}", item);
        }

      }

  }
}
