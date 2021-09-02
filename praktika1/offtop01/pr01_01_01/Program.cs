using System;

namespace pr01_01_01
{
  class Program
  {
    class Person
    {
      public string firstName;
      public string lastName;
      public int age;
      static public string secret;

      public Person(string firstName, string lastName, int age)
      {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        secret = "StringI";
      }

      public void setSecret(string _str)
      {
        secret = _str;
      }

      public override string ToString()
      {
        //return firstName + " " + lastName + ", age " + age;
        return secret;
        //return base.ToString();
      }

    }
    static void Main(string[] args)
    {

      Person p1 = new Person("Rusakov", "Aleksey", 36);
      Person p2 = new Person("Rusakov", "Aleksey", 36);
      p2.setSecret("Vaelin");
      Person p3 = new Person("Rusakov", "Aleksey", 36);
      //p3.setSecret("VAZELIN");

      
      Console.WriteLine(p1);
      Console.WriteLine(p2);
      Console.WriteLine(p3);
    }
  }
}
