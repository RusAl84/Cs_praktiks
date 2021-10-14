using System;
using System.Collections;

namespace prakt4_01
{
  class Program
  {

      static void Main(string[] args)
      {
        ArrayList myList = new ArrayList() { "Данила"};
        myList.Add("выпил");
        myList.Add("ВАНЮ и ");
      //myList.Add(0.5);


        myList.Add("HENESSY");
  
        
      foreach (string item in myList)
        {
          Console.WriteLine(String.Format($"Unsorted: {item}") );
        }
      //Сортировка при помощи стандартного объекта сравнения
      myList.Sort();

      //myList.Reverse();
      foreach (string item in myList)
      {
        Console.WriteLine("   Sorted: {0}", item);
      }

    }

  }
}
