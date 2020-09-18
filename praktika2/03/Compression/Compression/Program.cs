using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace Compression
{
    class Program
    {
        static void Main(string[] args)
        {
            string inFilename = @"d:\ttt.txt";
            string outFilename = @"d:\ttt.txt.gz";
            //FileStream sourceFile = File.OpenRead(inFilename);
            //FileStream destFile = File.Create(outFilename);

            //GZipStream compStream = new GZipStream(destFile, CompressionMode.Compress);
            //int theByte = sourceFile.ReadByte();
            //while (theByte != -1)
            //{
            //    compStream.WriteByte((byte)theByte);
            //    theByte = sourceFile.ReadByte();
            //}
            //compStream.Close();


            string inFilename1 = @"d:\tttt.txt";
            FileStream sourceFile = File.OpenRead(outFilename);
            FileStream destFile = File.Create(inFilename1);
            GZipStream compStream =
            new GZipStream(sourceFile, CompressionMode.Decompress);
            int theByte = compStream.ReadByte();
            while (theByte != -1)
            {
                destFile.WriteByte((byte)theByte);
                theByte = compStream.ReadByte();
            }

            compStream.Close();


        }
    }
}
