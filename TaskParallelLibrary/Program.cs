using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //var t1 = new Task(() =>
            //{
            //    DoWork(1, 1000);
            //});
            // t1.Start();


            var task = new TaskFactory().StartNew(() =>
            {
                DoWork(1, 1500);
            });

            var task2 = new TaskFactory().StartNew(() =>
            {
                DoWork(2, 2000);
            });

            var tasks = new List<Task> { task, task2 };

            // wait at least one task
            Task.WaitAny(tasks.ToArray());

            // wait all tasks
            Task.WaitAll(tasks.ToArray());


            Parallel.For(1, 100, (i) =>
            {
                Console.WriteLine(i);
            });


            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }

        static void DoWork(int id, int sleepTime)
        {
            Console.WriteLine("task {0} is beginning", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("task {0} has completed", id);
        }
    }
}
