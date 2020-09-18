using System;

namespace _2
{
  class Program
  {
    static void Main(string[] args)
    {
        string s = "Microsoft      .NET Framework 2.0    Application Development Foundation";
        string[] sa = s.Split(' ');

        Array.Sort(sa);
        foreach(string item in sa)
            {
                Console.WriteLine(item);
            }
        s = string.Join(" ", sa); 
        Console.WriteLine(s);
            Console.ReadLine();


    }
  }
}
