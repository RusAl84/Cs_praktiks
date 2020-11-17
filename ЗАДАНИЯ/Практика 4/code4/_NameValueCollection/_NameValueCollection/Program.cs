using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;

namespace _NameValueCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            //#1
            //NameValueCollection nv = new NameValueCollection();

            //nv.Add("Key", "Some Text");
            //nv.Add("Key", "More Text");
            //foreach (string s in nv.GetValues("Key"))
            //{
            //    Console.WriteLine(s);
            //}
            ////# 2
            //nv["First"] = "1st";
            //nv["First"] = "FIRST";
            //nv.Add("Second", "2nd");
            //nv.Add("Second", "SECOND");
            //Console.WriteLine(nv.GetValues("First").Length); // 1
            //Console.WriteLine(nv.GetValues("Second").Length); // 2

            //#3
            NameValueCollection nv = new NameValueCollection();

            nv.Add("First", "1st");
            nv.Add("Second", "2nd");
            nv.Add("Second", "Not First");
            for (int x = 0; x < nv.Count; ++x)
            {
                Console.WriteLine(nv[x]);
            }


        }
    }
}
