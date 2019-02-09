using System;
using System.Diagnostics;
using System.Threading;

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            System.Console.WriteLine("press anybutton to start or stop or type quit to exit");
            string input = Console.ReadLine();
            bool start = false;
            while ( input != "quit" )
            {
            input = Console.ReadLine();
            bool enter = String.IsNullOrEmpty(input);
            TimeSpan ts = stopWatch.Elapsed;

                if (enter == false)
                    start = !start;

                if (start == true)
                {
                    stopWatch.Start();
                    System.Console.WriteLine(start);
                }
                else
                {
                stopWatch.Stop();
                System.Console.WriteLine(start);
                }

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
                
            }
        }
    }
}
