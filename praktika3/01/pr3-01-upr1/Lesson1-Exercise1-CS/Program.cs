using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lesson1_Exercise1_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = { "(555)555-1212",
                              "(555) 555-1212",
                              "555-555-1212", 
                              "5555551212", 
                              "01111", 
                              "01111-1111",
                              "47", 
                              "111-11-1111",
                              "8005555535"};
            foreach (string s in input)
            {
                if (IsPhone(s)) Console.WriteLine(s + " is a phone number");

                else if (IsZip(s)) Console.WriteLine(s + " is a zip code");

                else Console.WriteLine(s + " is unknown");
            }
      Console.ReadLine();
        }

        static bool IsPhone(string s)
        {
            return Regex.IsMatch(s, @"^\(?\d{3}\)?[\s\-]?\d{3}\-?\d{4}$");
        }

        static bool IsZip(string s)
        {
            return Regex.IsMatch(s, @"^\d{5}(\-\d{4})?$");
        }
    }
}
