using System;

namespace HelloApp
{
    interface IAccount
    {
        int CurrentSum { get; }  // Текущая сумма на счету
        void Put(int sum);      // Положить деньги на счет
        void Withdraw(int sum); // Взять со счета
    }
    interface IClient
    {
        string Name { get; set; }
    }
    class Client : IAccount, IClient
    {
        int _sum; // Переменная для хранения суммы
        public string Name { get; set; }
        public Client(string name, int sum)
        {
            Name = name;
            _sum = sum;
        }
        public int CurrentSum { get { return _sum; } }
        public void Put(int sum) { _sum += sum; }
        public void Withdraw(int sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Tom", 200);
            client.Put(30);
            Console.WriteLine(client.CurrentSum); //230
            client.Withdraw(100);
            Console.WriteLine(client.CurrentSum); //130
            Console.Read();
        }
    }
}