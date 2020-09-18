using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Specialized;

namespace _SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            //SortedList sort = new SortedList();
            //sort["First"] = "1st";
            //sort["Second"] = "2nd";
            //sort["Third"] = "3rd";
            //sort["Fourth"] = "4th";
            //sort["fourth"] = "4th";
            //foreach (DictionaryEntry entry in sort)
            //{
            //    Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
            //}

            //////#2
            //SortedList newsort = new SortedList(new DescendingComparer());
            //newsort["First"] = "1st";
            //newsort["Second"] = "2nd";
            //newsort["Third"] = "3rd";
            //newsort["Fourth"] = "4th";
            //foreach (DictionaryEntry entry in newsort)
            //{
            //    Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
            //}
            //// #3

            ListDictionary emailLookup = new ListDictionary();

            emailLookup["sbishop@contoso.com"] = "Bishop, Scott";
            emailLookup["chess@contoso.com"] = "Hess, Christian";
            emailLookup["djump@contoso.com"] = "Jump, Dan";
            foreach (DictionaryEntry entry in emailLookup)
            {
                Console.WriteLine(entry.Value);
            }
        }
    }
}
