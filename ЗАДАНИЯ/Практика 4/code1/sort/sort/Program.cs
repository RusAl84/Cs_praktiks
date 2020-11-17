using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace sort
{

    public class BB: IComparable
    {
        public BB( string prop)
        {
            MyProperty = prop;
        }
        public string MyProperty { get; set; }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
            return comparer.Compare(this.MyProperty, ((BB)obj).MyProperty);
        }

        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList coll = new ArrayList();

            //coll.Add(new BB("F"));
            //coll.Add(new BB("a"));
            //coll.Add(new BB("c"));
            //coll.Add(new BB("d"));
            //coll.Add(new BB("f"));
            //coll.Add(new BB("A"));
            //coll.Add(new BB("C"));
            //coll.Add(new BB("b"));
            //coll.Add(new BB("B"));

            coll.Add("F");
            coll.Add("a");
            coll.Add("c");
            coll.Add("d");
            coll.Add("f");
            coll.Add("A");
            coll.Add("C");
            coll.Add("b");
            coll.Add("B");


            //// #1
            //foreach ( item in coll)
            //{
            //    Console.WriteLine(item.MyProperty);
            //}
            //Console.WriteLine();
            //coll.Sort();
            ////Метод Sort использует для сравнения элементов класс Comparer. 
            ////Класс Comparer яв¬ляется стандартной реализацией интерфейса IComparer.
            //// Меньше нуля	Объект в левой части неравенства меньше объекта в правой части
            ////Нуль	Объекты равны
            ////Больше нуля	Объект в левой части неравенства больше объекта в правой части
            //foreach (BB item in coll)
            //{
            //    Console.WriteLine(item.MyProperty);
            //}
            //Console.WriteLine();

            foreach (object item in coll)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            coll.Sort(new CaseInsensitiveComparer());
            foreach (object item in coll)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine();
            // # 2
            coll.Sort(new DescendingComparer());
            foreach (object item in coll)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }



    public class DescendingComparer : IComparer
    {
        CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
        public int Compare(object x, object y)
        {
            // Для сортировки по убыванию,
            // объекты, переданные для сравнения, меняются местами 
            return comparer.Compare(y, x);

        }
    }

}
