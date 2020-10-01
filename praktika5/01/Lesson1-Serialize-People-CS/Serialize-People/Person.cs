using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;


namespace Serialize_People
{
    [Serializable]
    class Person : IDeserializationCallback
    {
        public string name;
        public DateTime dateOfBirth;
        [NonSerialized] public int age;

        public Person(string _name, DateTime _dateOfBirth)
        {
            name = _name;
            dateOfBirth = _dateOfBirth;
            CalculateAge();
        }

        public Person()
        {
        }

        public override string ToString()
        {
            return name + " was born on " + dateOfBirth.ToShortDateString() + " and is " + age.ToString() + " years old.";
        }

        private void CalculateAge()
        {
            age = DateTime.Now.Year - dateOfBirth.Year;

            // If they haven't had their birthday this year, 
            // subtract a year from their age
            if (dateOfBirth.AddYears(DateTime.Now.Year - dateOfBirth.Year) > DateTime.Now)
            {
                age--;
            }
        }
        // C#
        void IDeserializationCallback.OnDeserialization(Object sender)
        {
            // ѕосле десериализации вычисл€ем возраст 
            CalculateAge();
            Console.WriteLine("calc");
        }

    }

}
