using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace testMonitor
{
    internal class Program
    {



        /// <summary>
        /// Задание
        ///    1. Создайте консольное приложение на языке C# в среде MS Visual Studio 
        ///    для реализации монитора.
        ///    2. Задайте свои параметры:
        ///       * число процессов,
        ///       * количество циклов вычисления случайных чисел.
        /// Результат представить в виде:
        ///     1) архива проекта программы для реализации монитора,
        ///     2) скриншота результата выполнения программы.
        ///  https://docs.microsoft.com/en-us/dotnet/api/system.threading.monitor?view=net-6.0
        ///  https://metanit.com/sharp/tutorial/11.5.php
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int processCount = 5;//число процессов,
            int randomCount = 10000; //количество циклов вычисления случайных чисел.


            List<Task> tasks = new List<Task>();
            Random rnd = new Random();

            long total = 0;
            int n = 0;
            for (int taskCtr = 0; taskCtr < processCount; taskCtr++)
                tasks.Add( 
                    Task.Run(() => {
                        int[] values = new int[randomCount];
                        int taskTotal = 0;
                        int taskN = 0;
                        int ctr = 0;

                    Monitor.Enter(rnd);
                    // Generaterandom integers
                    for (ctr = 0; ctr < randomCount; ctr++)
                        values[ctr] = rnd.Next(0, 1001);
                    Monitor.Exit(rnd);
                    taskN = ctr;
                    foreach (var value in values)
                        taskTotal += value;
                    Console.WriteLine("Mean for task {0,2}: {1:N2} (N={2:N0})",
                                      Task.CurrentId, (taskTotal * 1.0) / taskN,
                                      taskN);
                    Interlocked.Add(ref n, taskN);
                    Interlocked.Add(ref total, taskTotal);
                }));


            try
            {
                Task.WaitAll(tasks.ToArray());
                Console.WriteLine("\nMean for all tasks: {0:N2} (N={1:N0})",
                                  (total * 1.0) / n, n);
            }
            catch (AggregateException e)
            {
                foreach (var ie in e.InnerExceptions)
                    Console.WriteLine("{0}: {1}", ie.GetType().Name, ie.Message);
            }

        }
    }
}
