using System;
using System.Collections;

namespace prakt4_01
{
  class Program
  {

      static void Main(string[] args)
      {
        ArrayList myList = new ArrayList() { "VAZELIN"};
        myList.Add("EZHIK");
        myList.Add("ARTEM");
        myList.Add("HENESSY");
      myList.AddRange(myList);
      myList.Add(0.5f);
      myList.Add(10e6);

      foreach (int item in myList)
        {
          Console.WriteLine("Unsorted: {0}", item.ToString());
        }
      //// Сортировка при помощи стандартного объекта сравнения 
      //myList.Sort();
      ////myList.Reverse();
      //foreach (string item in myList)
      //{
      //  Console.WriteLine("   Sorted: {0}", item);
      //}

    }

  }
}
