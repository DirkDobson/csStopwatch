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
        System.Console.WriteLine("pres start or stop");
        string input = Console.ReadLine();
        bool start = false;
        bool enter = String.IsNullOrEmpty(input);

        if (enter == false)
            start = !start;

        if (start == true)
        {
            stopWatch.Start();
        }
        else
        {
        stopWatch.Stop();
        }
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
    }
    }
}
