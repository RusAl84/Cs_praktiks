using System;
using MathTaskClassLibrary;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      Geometry gc = new Geometry();
      int a = 5;
      int b = 3;
      Console.WriteLine(gc.RectangleArea(a, b));
    }
  }
}
