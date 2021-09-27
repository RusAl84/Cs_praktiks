using System;
using System.Collections;

namespace prakt4_01
{
  class Program
  {

      static void Main(string[] args)
      {
        ArrayList myList = new ArrayList() { "НИКИТА"};
        myList.Add("выпил");
        myList.Add("ВАНЮ и ");
      //myList.Add(0.5);
        myList.Add("HENESSY");
  
        
      foreach (object item in myList)
        {
          Console.WriteLine(String.Format("Unsorted: {item.ToString()}") );
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
