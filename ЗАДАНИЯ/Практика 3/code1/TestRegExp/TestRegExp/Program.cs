using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;

namespace TestRegExp
{
    class Classl
    {
        [STAThread]
        static void Main(string[] args)
        {
            // #1
            if (Regex.IsMatch(args[1], args[0]))
                Console.WriteLine("Ввод соответствует регулярному выражению.");
            else
                Console.WriteLine("Ввод не соответствует регулярному выражению.");
            //^\d{5}$ 1234

            //^ означает начало строки, 
            //«\d» — то, что дальше идут цифры,
            //«{5}» — то, что цифр должно быть пять подряд,
            //«$» — конец строки


            // #2
            //string st = "abc\ndef\nghi";
            //bool b;
            //b= Regex.IsMatch(st, "^def$");
            //b = Regex.IsMatch(st, "^def$",RegexOptions.Multiline);


        }
    }

}
