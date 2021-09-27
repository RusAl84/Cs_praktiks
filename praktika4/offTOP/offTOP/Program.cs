using System;
using System.Collections;

namespace offTOP
{
  class Program
  {
    static void Main(string[] args)
    {
      ArrayList objectList1 = new ArrayList() { 1, 2, "string", 'c', 2.0f };
      ArrayList objectList2 = new ArrayList() { 1, 2, "string", 'c', 2.0f };
      ArrayList objectList3 = new ArrayList() { 1, 2, "string", 'c', 2.0f };
      int count = 2000 * 1000 * 1000;
      string tmptext="";
      for (int i = 0; i < 10000; i++)
      {
        tmptext += $"/* Ёжик съел Евгена  {i} раза */";
        //tmptext +="ГОША съел ЕжИка";

      }
      for (int i = 0; i < count; i++)
      {
        objectList1.Add(tmptext); GC.Collect();
        objectList2.Add(tmptext); GC.Collect();
        objectList3.Add(tmptext); GC.Collect();
        //
      }
      //GC.Collect();
      Console.Beep();
      Console.ReadKey();



    }
  }
}
