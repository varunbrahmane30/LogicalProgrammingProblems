using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace D6LogicalProblems
{
    class Stopwatch
    {
        public static void stopwatchPeogram()
        {
            double start, stop;
            Console.Write("Enter starting time of stopwatch in 24 hours format: ");
            start = double.Parse(Console.ReadLine());

            Console.Write("Enter ending time of stopwatch in 24 hours format: ");
            stop = double.Parse(Console.ReadLine());

            double elapsedHour = stop - start;


            double startMin, stopMin;
            startMin = start * 60;
            stopMin = stop * 60;
            double elapsedMin = stopMin - startMin;


            double startSec, stopSec;
            startSec = start * 60 * 60;
            stopSec = stop * 60 * 60;
            double elapsedSec = stopSec - startSec;


            double startMSec, stopMSec;
            startMSec = start * 60 * 60 * 1000;
            stopMSec = stop * 60 * 60 * 1000;
            double elapsedMSec = stopMSec - startMSec;


            Console.WriteLine("The elapsed time in Hour:Minute:Seconds:MiliSeconds format is: " + elapsedHour + ":" + elapsedMin + ":" + elapsedSec + ":" + elapsedMSec);
        }

    }
}
