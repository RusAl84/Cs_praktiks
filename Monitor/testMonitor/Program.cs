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
        ///    1. Создайте консольное приложение на языке C# в среде 
        ///    MS Visual Studio для реализации монитора.
        ///    2. Задайте свои параметры:
        ///       * число процессов,
        ///       * количество циклов вычисления случайных чисел.
        /// Результат представить в виде:
        ///     1) архива проекта программы для реализации монитора,
        ///     2) скриншота результата выполнения программы.
        ///  https://docs.microsoft.com/en-us/dotnet/api/system.threading.monitor?view=net-6.0
        ///  https://metanit.com/sharp/tutorial/11.5.php
        ///  https://ru.stackoverflow.com/questions/828749/%D0%9A%D0%B0%D0%BA-%D0%BF%D1%80%D0%B0%D0%B2%D0%B8%D0%BB%D1%8C%D0%BD%D0%BE-%D0%B8%D1%81%D0%BF%D0%BE%D0%BB%D1%8C%D0%B7%D0%BE%D0%B2%D0%B0%D1%82%D1%8C-monitor-wait-%D0%B8-pulse
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int processCount = 5;//число процессов,
            int randomCount = 10000; //количество циклов вычисления случайных чисел.


            // Пример 1
            // https://docs.microsoft.com/en-us/dotnet/api/system.threading.monitor?view=net-6.0
            // класс Monitor используется для синхронизации доступа
            // к одному экземпляру генератора случайных чисел,
            // представленному классом Random.
            // В примере создается processCount задач,
            // каждая из которых выполняется асинхронно в потоке пула потоков.
            // Каждая задача генерирует randomCount случайных чисел,
            // вычисляет их среднее значение и обновляет две переменные
            // уровня процедуры, которые поддерживают текущую сумму
            // количества сгенерированных случайных чисел и их суммы.
            // После выполнения всех задач эти два значения используются
            // для расчета общего среднего.
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

                    Monitor.Enter(rnd); // Входим в монитор для генерации чисел
                    // Generaterandom integers
                    for (ctr = 0; ctr < randomCount; ctr++)
                        values[ctr] = rnd.Next(0, 1001);
                    Monitor.Exit(rnd); // выходим из Монитора
                    // рассчет среднего значения
                    taskN = ctr;
                    foreach (var value in values)
                        taskTotal += value;
                    Console.WriteLine("Mean for task {0,2}: {1:N2} (N={2:N0})",
                                      Task.CurrentId, (taskTotal * 1.0) / taskN,
                                      taskN);
                    Interlocked.Add(ref n, taskN); // Записываем  taskN  в n
                    Interlocked.Add(ref total, taskTotal); // Записываем  ...
                    // Interlocked самый легковесный способ синхронизации.
                    // Interlocked представляет собой набор простых атомарных
                    // операций.Атомарной называется операция в момент
                    // выполнения которой не может ничего произойти.


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


            // Пример 2 Monitor.Wait, Monitor.Pulse[All]
            // https://habr.com/ru/post/459514/
            object syncObject = new object();
            void T1()
            {
                lock (syncObject) 
                { 
                    Console.WriteLine("Enter Lock1");
                    Thread.Sleep(2000);
                    Monitor.Wait(syncObject);
                    Console.WriteLine("After Wait");
                }
            }
            Console.WriteLine("Exit Lock1");
            void T2()
            {
                lock (syncObject) 
                {
                    Console.WriteLine("Enter Lock2");
                    Thread.Sleep(2000);
                    Monitor.Pulse(syncObject); 
                    Console.WriteLine("After Pulse");
                    Thread.Sleep(2000);
                }
            }
            Console.WriteLine("Exit Lock2");
            Thread t1 = new Thread(T1);
            t1.Start();
            Thread.Sleep(100);
            Thread t2 = new Thread(T2);
            t2.Start();
            //Разбор:Установил задержку в 100мс при старте второго потока, специально чтобы гарантировать,
            //что его выполнение начнется позднее.
            //— T1: Line#2 поток стартует
            //— T1: Line#3 поток входит в критическую секцию
            //— T1: Line#6 поток засыпает
            //— T2: Line#3 поток стартует
            //— T2: Line#4 зависает в ожидании критической секции
            //— T1: Line#7 отпускает критическую секцию и зависает в ожидании выхода Pulse
            //— T2: Line#8 входит в критическую секцию
            //— T2: Line#11 оповещает T1 при помощи метода Pulse
            //— T2: Line#14 выходит из критической секции. До этих пор T1 не может продолжить выполнение.
            //— T1: Line#15 выходит из ожидания
            //— T1: Line#16 выходит из критической секции

            //В MSDN есть важная ремарка, касательно использования методов Pulse / Wait,
            //а именно: Monitor не хранит информацию о состоянии, а значит, если вызов метода Pulse
            //до вызова метода Wait может привести к дедлоку. Если такая ситуация возможна,
            //то лучше использовать один из классов семейства ResetEvent.

        }
    }
}
