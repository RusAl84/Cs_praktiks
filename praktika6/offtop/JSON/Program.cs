using System;
using System.IO;
using System.Text.Json;

namespace JSON
{
  class Program
  {
    static void Main(string[] args)
    {
      student st1 = new student();
      st1.Course = 15;
      st1.Name = "Mihalich";
      string filename = "valera.txt";
      Console.WriteLine(st1);
      save_stud(st1, filename);
      student st2 = new student();
      st2 = load_stud(filename);
      Console.WriteLine(st2);
    }
    static void save_stud(student st1,string filename)
    {
      string json = JsonSerializer.Serialize<student>(st1);
      using (StreamWriter sw = new StreamWriter(filename))
      {
          sw.WriteLine(json);
      }
    }
    static student load_stud(string filename)
    {
      using (StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open)))
      {
         string str1 = sr.ReadLine();
        student st1 = new student();
        student restoredPerson = JsonSerializer.Deserialize<student>(str1); ;
        return st1;
      }
    }
  }
}
