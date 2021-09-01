using System;

namespace PR1_1
{
    /// <summary>
    /// Класс для человека
    /// описание
    /// 
    /// </summary>
    class Person
  {
    public enum Genders : int { 
            Male, 
            Female,
            custom};
    public string firstName;
    public string lastName;
    public int age;
    public Genders gender;
    
    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="_firstName">Имя</param>
    /// <param name="_lastName">Отчество</param>
    /// <param name="_age">Возраст</param>
    /// <param name="_gender">Пол</param>
    public Person(string _firstName, string _lastName, int _age, Genders _gender)
    {
      firstName = _firstName;
      lastName = _lastName; 
      age = _age;
      gender = _gender;
    }
    public override string ToString()
    {
      return firstName + " " + lastName + " (" + gender + "), age " + age;
    }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Имя</param>
    public void Dislay(string name)
    {
            Console.WriteLine(name);
    }
  }
  /// <summary>
  /// 
  /// </summary>
  class Program
  {
    static void Main(string[] args)
    {
      Person p = new Person("Rusakov", "Aleksey", 36, Person.Genders.Male);
      p.Dislay("Максим");
      Person p1 = new Person("Rusakov", "Aleksey", 36, Person.Genders.custom);
      Console.WriteLine(p);
      Console.WriteLine(p1);
      Console.ReadKey();
    }
  }
}
