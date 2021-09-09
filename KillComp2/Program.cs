using System;

namespace KillComp
{
  class Program
  {
    /*fdfdfddf
     * args
     * 
     */
    static void Main(string[] args)
    {
      for(int i = 0; i < 100; i++)
      {
        Console.Beep(10000 - 100 * i, 300 - 2 * i);
      }
      Console.Beep(2000, 30*1000);
      
    }
  }
}
