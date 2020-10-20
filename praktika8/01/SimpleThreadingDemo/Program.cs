using System;
using System.Threading;

namespace SimpleThreadingDemo
{
    class Program
    {
        static void Counting() {

            Random rand = new Random();
            for (int i=0;i<100; i++)
            {
                Console.WriteLine("Count: {0} - Thread {1} ", i, Thread.CurrentThread.ManagedThreadId); 
                Thread.Sleep(rand.Next(100, 300));

                Console.Beep(2020- 2*10*i, rand.Next(50,300));
            }
        }
        static void Main(string[] args)
        {
            ThreadStart starter = new ThreadStart(Counting);
            Thread first = new Thread(starter);
            Thread second = new Thread(starter);
            Thread third = new Thread(starter);
            Thread fourth = new Thread(starter);
            first.Start(); 
            second.Start();
            third.Start();
            fourth.Start();
            first.Join(); 
            second.Join();
            third.Join();
            fourth.Join();
            Console.Read();


        }
    }
}
