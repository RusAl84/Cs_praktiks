using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
//#1
            //FileStream theFile = File.Create(@"c:\somefile.txt");
            //StreamWriter writer = new StreamWriter(theFile);
            //writer.WriteLine("Hello");
            //writer.Close();
            //theFile.Close();
            
            //#2
            //StreamWriter writer = File.CreateText(@"c:\somefile.txt");
            //writer.WriteLine("Hello"); 
            //writer.Close();

            //#3
            //File.WriteAllText(@"c:\somefile. txt", "Hello");


            //#4
            //FileStream theFile = null;
            //theFile = File.Open(@"c:\somefile.txt",FileMode.Open, FileAccess.Write);
           
            //#5
            //FileStream theFile = null;
            //theFile = File.Open(@"c:\somefile.txt",FileMode.OpenOrCreate, FileAccess.Write);




        }
    }
}
