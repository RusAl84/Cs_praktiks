using System;

namespace PR1_1
{
    class Person
    {
        public string firstName;
        public string lastName;
        static public string sekret;
        public int age;


        public Person(string _firstName, string _lastName, int _age, string _sekret)
        {
            firstName = _firstName;
            lastName = _lastName; 
            age = _age;
            sekret = _sekret;
        }
        public Person(string _firstName, string _lastName)
        {
            firstName = _firstName;
            lastName = _lastName;
            age = 18;
            sekret = "MARS";

        }

        public override string ToString()
        {
            return firstName + " " + lastName + ", age " + age+ ", sekret " + sekret;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Rusakov", "Alexey", 35,"sekret_fvv");
            Person p1 = new Person("Rusakov", "Alexey");
            Person p2 = new Person("Rusakov", "Alexey", 35, "MAKSIK");
            Console.WriteLine(p);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.ReadKey();
        }
    }
}
