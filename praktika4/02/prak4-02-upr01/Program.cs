using System;
using System.Collections;

namespace prak4_02_upr01
{
  class Program
  {
    static void Main(string[] args)
    {
      Queue queue = new Queue();

      queue.Enqueue("GOSHA");
      queue.Enqueue("EZHIK");
      queue.Enqueue("EZHIKA ARCH");
      queue.Enqueue("EZHIKA MINT");
      
      

      while (queue.Count > 0)
      {
        object obj = queue.Dequeue();
        Console.WriteLine("From Queue: {0}", obj);
      }
    }
  }
}
