using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _BufferedStream
{
    class Program
    {
        static void Main(string[] args)
        {
            // C#
            FileStream newFile = File.Create(@"c:\test.txt");
            BufferedStream buffered = new BufferedStream(newFile);
            StreamWriter writer = new StreamWriter(buffered);
            writer.WriteLine("Some data");
            writer.Close();

        }
    }
}
