using System;

namespace i2
{
    interface IMovable
    {
        void Move();
    }
    class Person : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Человек идет");
        }
    }
    struct Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Машина едет");
        }
    }

    class Program
    {
        static void Action(IMovable movable)
        {
            movable.Move();
        }
        static void Main(string[] args)
        {
            Person person = new Person();
            Car car = new Car();
            Action(person);
            Action(car);
            Console.Read();
        }
    }
}
