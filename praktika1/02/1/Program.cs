using System;

namespace _1
{
  class Program
  {
    static void Main(string[] args)
    {
      // C#
      SByte a = 0; 
      Byte b = 0; 
      Int16 c = 0; 
      Int32 d = 0;
      System.Int64 e = 0; 
      string s = "";
      Exception ex = new Exception(); 
      object[] types = { a, b, c, d, e, s, ex };
      foreach (object o in types)
      {
        string type;
        if (o.GetType().IsValueType) type = "Value type";
        else
          type = "Reference Type";
        Console.WriteLine("{0}: {1}", o.GetType(), type);
      }
    }
  }
}
