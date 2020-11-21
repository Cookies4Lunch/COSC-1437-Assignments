using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

/*
 * ProfReynolds
 * put your name here
 */

namespace Project_3_Await
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ProfReynolds
             * you forgot some stuff - 4 lines of header and a while loop
             * didn't you notice this when you tested the program???
             */

            Console.WriteLine();
            Console.WriteLine("1) Demo the AwaitDemo1");
            Console.WriteLine("2) Demo the AwaitDemo2");
            Console.WriteLine("X) exit");
            Console.Write("Select demonstration: ");

            var keyPressed = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine();

            switch (keyPressed)
            {
                case 'x':
                case 'X':
                    return;

                case '1': AwaitDemo1(); break;
                case '2': AwaitDemo2(); break;


                default:
                    break;
            }
            Console.WriteLine();
        }

        static Stopwatch _stopwatch = new Stopwatch();

        private static void AwaitDemo1()
        {
            _stopwatch.Reset();
            _stopwatch.Start();

            Task<string> a = WaitAsynchronouslyAsynch(1000);
            Task<string> b = WaitAsynchronouslyAsynch(100);
            var c = WaitAsynchronouslyAsynch(10);
            var d = WaitAsynchronouslyAsynch(2000);
            var e = WaitAsynchronouslyAsynch(100);

            Console.WriteLine();

            Console.WriteLine(a.Result);
            Console.WriteLine(b.Result);
            Console.WriteLine(c.Result);
            Console.WriteLine(d.Result);
            Console.WriteLine(e.Result);

            Console.WriteLine();
            Console.WriteLine($"{_stopwatch.ElapsedMilliseconds} total elapsed time");

            _stopwatch.Stop();
        }

        private static async Task<string> WaitAsynchronouslyAsynch(int delay)
        {
            await Task.Delay(delay);
            Console.WriteLine($"completed task with {delay} delay ");
            return $"completed {delay} delay in {_stopwatch.ElapsedMilliseconds} milliseconds";
        }

        private static void AwaitDemo2()
        {
            _stopwatch.Reset();
            _stopwatch.Start();

            var rnd = new Random();

            var runningTasks = new Task<string>[10];

            for (var taskNumber = 0; taskNumber < 10; taskNumber++)
            {
                runningTasks[taskNumber] = WaitAsynchronouslyAsynch(rnd.Next(0, 5000));
            }

            Console.WriteLine();

            for (var taskNumber = 0; taskNumber < 10; taskNumber++)
            {
                Console.WriteLine($"task #{taskNumber} {runningTasks[taskNumber].Result}");
            }

            Console.WriteLine();
            Console.WriteLine($"{_stopwatch.ElapsedMilliseconds} total elapsed time");

            _stopwatch.Stop();
        }
    }
}
