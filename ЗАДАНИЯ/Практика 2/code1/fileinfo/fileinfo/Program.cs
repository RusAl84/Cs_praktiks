using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace fileinfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // #1
            FileInfo ourFile = new FileInfo(@"c:\boot.ini ");
            if (ourFile.Exists)
            {
                Console.WriteLine("Filename : {0}", ourFile.Name); Console.WriteLine("Path       : {0}", ourFile.FullName);
            }

            // #2
            //FileInfo ourFile = new FileInfo(@"c:\boot.ini");

            //ourFile.CopyTo(@"c:\boot1.bak");

            // #3
            //DirectoryInfo ourDir = new DirectoryInfo(@"c:\windows");

            //Console.WriteLine("Directory: {0}", ourDir.FullName);
            //foreach (FileInfo file in ourDir.GetFiles())
            //{
            //    Console.WriteLine("File: {0}", file.Name);
            //}

            //#4
            //DriveInfo[] drives = DriveInfo.GetDrives();
            //foreach (DriveInfo drive in drives)
            //{
            //    Console.WriteLine("Drive: {0}", drive.Name);
            //    Console.WriteLine("Type:   {0}", drive.DriveType);
            //}

            //#5
            //string ourPath = @"c:\boot.ini";
            //Console.WriteLine(ourPath);

            //Console.WriteLine("Ext: {0}", Path.GetExtension(ourPath));

            //Console.WriteLine("Change Path: {0}",
            //Path.ChangeExtension(ourPath, "bak"));



        }
    }
}
