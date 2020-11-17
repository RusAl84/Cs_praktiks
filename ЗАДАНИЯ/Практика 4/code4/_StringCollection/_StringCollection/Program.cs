using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Collections;

namespace _StringCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCollection coll = new StringCollection();

            coll.Add("First");
            coll.Add("Second");
            coll.Add("Third");
            coll.Add("Fourth");
            coll.Add("fourth");
            //coll.Add(50);// <- Ошибка компиляции - это не строка
            string theString = coll[3];
            // Теперь приведение типов не требуется
            // string theString = (string) coll[3];

            // #2
            StringDictionary dict = new StringDictionary();

            dict["First"] = "1st";
            dict["Second"] = "2nd";
            dict["Third"] = "3rd";
            dict["Fourth"] = "4th";
            dict["fourth"] = "fourth";
            // dict[50] = "fifty";// <- Ошибка компиляции - это не строка
            string converted = dict["Second"]; // Приведение типов не требуется


            //// #3 Наборы, нечувствительные к регистру
            //Hashtable inTable = CollectionsUtil.CreateCaseInsensitiveHashtable();
            //inTable["hello"] = "Hi";
            //inTable["HELLO"] = "Heya";
            //Console.WriteLine(inTable.Count); // 1
            //SortedList inList = CollectionsUtil.CreateCaseInsensitiveSortedList();
            //inList["hello"] = "Hi";
            //inList["HELLO"] = "Heya";
            //Console.WriteLine(inList.Count); // 1

            //// #4 Наборы, нейтральные по отношению к культуре

            //Hashtable hash = new Hashtable(StringComparer.InvariantCulture);
            //SortedList list = new SortedList(StringComparer.InvariantCulture);




        }
    }
}
