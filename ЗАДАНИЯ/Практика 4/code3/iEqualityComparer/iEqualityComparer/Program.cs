using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace iEqualityComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable dehash = new Hashtable(new InsensitiveComparer());

            dehash["First"] = "1st";
            dehash["Second"] = "2nd";
            dehash["Third"] = "3rd";
            dehash["Fourth"] = "4th";
            dehash["fourth"] = "4th";

            Console.WriteLine(dehash.Count); // 4

        }
    }

    public class InsensitiveComparer : IEqualityComparer
    {
        CaseInsensitiveComparer _comparer = new CaseInsensitiveComparer();
        public int GetHashCode(object obj)
        {
            return obj.ToString().ToLowerInvariant().GetHashCode();
        }
        public new bool Equals(object x, object y)
        {
            if (_comparer.Compare(x, y) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
