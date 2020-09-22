using System;
using System.Collections;

namespace prak4_02_upr02
{
  class Program
  {
    static void Main(string[] args)
    {
      Stack stack = new Stack();
      stack.Push("EGOR1");
      stack.Push(0.5);
      stack.Push(2);
      stack.Push("EGOR4");
      stack.Push("EGOR5");
      stack.Push("MAXIM");
      stack.Push("ANDREY");
            while (stack.Count > 0)
            {
                object obj = stack.Pop();
                Console.WriteLine("'From Stack: {0}", obj);
                //Console.WriteLine("SEDIT: {0}", stack.Peek());
            }

    }
  }
}
