using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = "12/31/1997";
          st=  MDYToDMY(st);
          //string st1 = "Se%^rgey@cnit-mg(^(<>//upi.ru#$%^*&(*";
          //st1 = Cleanlnput(st1);


        }
        static String MDYToDMY(String input) // месяц/день/год на дату в формате день-месяц-год:
        {
            return Regex.Replace(input,
            "\\b(?<month>\\d{1,2})/(?<day>\\d{1,2})/(?<year>\\d{2,4})\\b",
            "${day}-${month}-${year}");
        }
        //static String Cleanlnput(string strln)
        //{
        //    // Замена недопустимых символов пустыми строками, 
        //    return Regex.Replace(strln, @"[^\w\.@-]", "");
        //}

    }
}
