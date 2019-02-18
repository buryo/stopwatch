using System;
using System.Diagnostics;

namespace StpWatch
{
    class Program
    {
        public enum State { WAITING, STARTED };
        static Stopwatch stopWatch = new Stopwatch();

        static void Main(string[] args)
        {
            
            Console.WriteLine("Press X to quit");
            Console.WriteLine("----------------------");

            int UserInput = DisplayMenu();

            do
            {
                switch (UserInput)
                {
                    case 1:
                        Console.Clear();
                        if (State.STARTED)

                        Console.WriteLine("Stopwatch started, enter 'D' to stop.");
                        Console.WriteLine(stopWatch.Elapsed);
                        stopWatch.Start();
                        UserInput = DisplayMenu();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Stopwatch stopped, enter 'S' to start again.");
                        stopWatch.Stop();
                        Console.WriteLine(stopWatch.Elapsed);
                        UserInput = DisplayMenu();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        UserInput = DisplayMenu();
                        break;
                }
            } while (UserInput != 3);
        }

        public static int DisplayMenu()
        {
            Console.WriteLine("Enter 'S' to start.");

            string answer = Console.ReadLine();

            if (answer == "s")
                return 1;

            if (answer == "d" && stopWatch.Elapsed > new TimeSpan(0, 0, 0))
                return 2;
            else if (answer == "d" && stopWatch.Elapsed <= new TimeSpan(0, 0, 0))
            {
                Console.Clear();
                Console.WriteLine("Dude you have to start the stopwatch first.. Press 'S'");
                return 0;
            }
                
            return 0;
        }
    }
}
