using System;
using System.Threading;

//Spencer Johnson

namespace Project_2_ThreadSafe
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("Spencer Johnson");
            Console.WriteLine("Weekly Topic Unit 9");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1) Demo the ThreadSafeTest");
                Console.WriteLine("X) Exit");
                Console.Write("Select demonstration: ");

                var keyPressed = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.WriteLine();

                switch (keyPressed)
                {
                    case 'x':
                    case 'X':
                        return;

                    case '1': ThreadSafeTest(); break;


                    default:
                        break;
                }
                Console.WriteLine();
            }
        }



        static bool _done;

        static readonly object Locker = new object();

        static int ThreadSafeTest()
        {
            _done = false;

            new Thread(Go).Start();
            Go();
            
            return 0;
        }

        static void Go()
        {
            lock (Locker)
            {
                if (!_done)
                {
                    Thread.Sleep(10);
                    _done = true;
                    Console.WriteLine("Method 'Go' has been reached, _done is now true");
                }
            }
        }
    }
}
