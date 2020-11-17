using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1 
            //Hashtable emailLookup = new Hashtable();

            //// Метод Add  принимает в качестве первого параметра ключ,
            //// а в качестве второго - значение
            //emailLookup.Add("sbishop@contoso.com", "Bishop, Scott");
            //// Использование индексатора эквивалентно вызову Add 
            //emailLookup["sbishopecontoso.com"] = "Bishop, Scott";

            //Console.WriteLine(emailLookup["sbishopecontoso.com"]);

            //#2

            Hashtable emailLookup = new Hashtable();

            emailLookup["sbishop@contoso.com"] = "Bishop, Scott";
            emailLookup["chess@contoso.com"] = "Hess, Christian";
            emailLookup["djump@contoso.com"] = "Jump, Dan";
            //foreach (object name in emailLookup)
            //{
            //    Console.WriteLine(name);
            //}
            ////#3
            //foreach (DictionaryEntry entry in emailLookup)
            //{
            //    Console.WriteLine("value {0}, Key {1}", entry.Value,entry.Key);

            //}
            ////#4
            //foreach (object name in emailLookup.Keys)
            //{
            //    Console.WriteLine(name);
            //}
            //#5

            Hashtable duplicates = new Hashtable();

            //duplicates["First"] = "1st";
            //duplicates["First"] = "the first";

            //Console.WriteLine(duplicates.Count); // 1

            //#6

            //Hashtable duplicates = new Hashtable();

            Fish key1 = new Fish("Herring");
            Fish key2 = new Fish("Herring");
            duplicates[key1] = "Hello";
            duplicates[key2] = "Hello";

            Console.WriteLine(duplicates.Count); // 2




        }
    }
    public class Fish
    {
        string name;
        public Fish(string theName)
        {
            name = theName;
        }
        //#7
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
       //#8
        public override bool Equals(object obj)
        {
            Fish otherFish = obj as Fish;
            if (otherFish == null) return false;
            return otherFish.name == name;
        }

    }



}
