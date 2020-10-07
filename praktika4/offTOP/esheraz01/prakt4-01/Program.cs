using System;
using System.Collections;
using System.Threading;

namespace prakt4_01
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList myList = new ArrayList(); 
            myList.Add("Вася"); 
            myList.Add("Ваня");
            myList.Add("Вика");
            myList.Add("Вова");
            foreach (string item in myList)
            {
                Console.WriteLine("Unsorted: {0}", item);
            }
            // Сортировка при помощи стандартного объекта сравнения 
            myList.Sort();
            foreach (string item in myList)
            {
                Console.WriteLine("   Sorted: {0}", item);
            }


        }
    }
}
