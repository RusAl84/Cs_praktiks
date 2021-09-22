using System;
using System.Collections;

namespace prak4_02_upr02
{
  class Program
  {
    static void Main(string[] args)
    {
      Stack stack = new Stack();
      stack.Push("ARTEM");
      stack.Push(0.5);
      stack.Push(2);
      stack.Push("EZHIK UBUNTU");
      stack.Push("EZHIK RH");
      stack.Push("EZHIK FEDORA");
      stack.Push("EZHIK MINT");
            while (stack.Count > 0)
            {
                object obj = stack.Pop();
                Console.WriteLine("'From Stack: {0}", obj);
                //Console.WriteLine("SEDIT: {0}", stack.Peek());
            }

    }
  }
}
