using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            ArrayList coll = new ArrayList();

            // Добавление в набор одиночных элементов
            //string s = "Hello";
            //coll.Add(s);
            //coll.Add("hi");
            //coll.Add(50);
            //coll.Add(new object());

            // #2
            string[] anArray = new string[] { "more", "or", "less" };
            coll.AddRange(anArray);
            object[] anotherArray = new object[] { new object(), new ArrayList() };
            coll.AddRange(anotherArray);

            //// #3
            //coll.Insert(3, "Hey All");
            //string[] moreStrings =
            //    new string[] { "goodnight", "see ya" };
            //coll.InsertRange(4, moreStrings);

            ////#4
            //coll[3] = "Hey Аll";

            ////#5

            //var my = new MyClass() { MyProperty=5 };
            //coll.Add(my);

            //coll.Remove(new MyClass() { MyProperty = 5 });

            //#6
            // Удаление из ArrayList первого элемента
            //coll.RemoveAt(0);
            // Удаление из ArrayList первых четырех элементов
            //coll.RemoveRange(0, 4);

            //#7
            string myString = "My String";
            coll.Add(myString);
            if (coll.Contains(myString))
            {
                int index = coll.IndexOf(myString);
                coll.RemoveAt(index);
            }
            else
            {
                coll.Clear();
            }


            //#8

            //for (int x = 0; x < coll.Count; ++x)
            //{
            //    Console.WriteLine(coll[x]);
            //}
            //#9
            // С# 
            //IEnumerator enumerator = coll.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}

            //#10
            //foreach (object item in coll)
            //{
            //    Console.WriteLine(item);
            //}

            //// #11
            ArrayList newColl = new ArrayList();
            newColl.Add("Hello");
            newColl.Add("Goodbye");
            newColl.Add(2);
            foreach (string item in newColl)
            {
                Console.WriteLine(item.ToUpper());
            }


        }
    }
    class MyClass:IComparable
    {
        public int MyProperty { get; set; }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
       
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            
            return MyProperty==((MyClass)obj).MyProperty;
        }


        public override int GetHashCode()
        {
            return MyProperty.GetHashCode();
        }

        #endregion
    }
}
