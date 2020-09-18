using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace FIFO_LIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            //Queue q = new Queue();
            //q.Enqueue("An item");
            //Console.WriteLine(q.Dequeue());

            //#2
            Queue q = new Queue();

            q.Enqueue("First");
            q.Enqueue("Second");
            q.Enqueue("Third");
            q.Enqueue("Fourth");
            //while (q.Count > 0)
            //{
            //    Console.WriteLine(q.Dequeue());
            //}

            //#3
            //if (q.Peek() is String)
            //{
            //    Console.WriteLine(q.Dequeue());
            //}

            //#4
            //Stack s = new Stack();
            //s.Push("An item");
            //Console.WriteLine(s.Pop());

            //#5
            Stack s = new Stack();

            s.Push("First");
            s.Push("Second");
            s.Push("Third");
            s.Push("Fourth");
            while (s.Count > 0)
            {
                Console.WriteLine(s.Pop());
            }



        }
    }
}
