using System;
using System.Threading;
namespace SingleInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex oneMutex = null;
            const String MutexName = "RUNMEONLYONCE";
            try // Пытаемся открыть Mutex
            {
                oneMutex = Mutex.OpenExisting(MutexName);
            }
            catch (WaitHandleCannotBeOpenedException)
            {
                // He можем открыть Mutex, потому что он не существует
            }
            // Создаем его, если он не существует 
            if (oneMutex == null)
            {
                oneMutex = new Mutex(true, MutexName);
            }
            else
            {
                // Закрываем Mutex и выходим из приложения,
                // так как разрешается запуск только одного его экземпляра
                oneMutex.Close();
                return;
            }
            Console.WriteLine("Our Application");
            Console.Read();
        }
    }
}