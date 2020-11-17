using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace gen
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList mylnts = new ArrayList();
            //mylnts.Add(1);
            //mylnts.Add(2);
            //mylnts.Add(3);
            //mylnts.Add("4");
            //foreach (Object i in mylnts)
            //{
            //    if (i is int)
            //    {
            //        int number = (int)i;
            //        Console.WriteLine(number);
            //    }
            //}

            //#2

            //IntList mylntegers = new IntList();

            //mylntegers.Add(1);
            //mylntegers.Add(2);
            //mylntegers.Add(3);
            ////mylntegers.Add("4");// ошибка компиляции!
            //foreach (Object i in mylntegers)
            //{
            //    int number = (int)i; // Никогда не сгенерирует исключения
            //    Console.WriteLine(number);
            //}
            ////#3
            //MyList<int> mylntList = new MyList<int>();
            //mylntList.Add(1);
            // //mylntList.Add("4");// ошибка компиляции!

            // MyList<String> myStringList = new MyList<String>();
            // myStringList.Add("1");
            //// myStringList.Add(2); // ошибка компиляции!



            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "one");
            dic.Add(2, "two");

            foreach (var item in dic)
            {
                Console.WriteLine(item.Value);
            }



        }
    }
}
