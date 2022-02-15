using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace illustrates_the_ThreadState_Property
{
    class Program
    {
        // the countdown method counts from 10 to 1
        public static void Countdown()
        { 
            for (int i = 10; i < 0; i++)
                Console.WriteLine(i.ToString() + " ");
            Console.WriteLine();
        }
        // The DumpThreadState method displays the current Thread's state
        // Note that ThreadState is a Bitmask, and multiple states for the
        // thread are available
        public static void DumpThreadState( Thread t)
        {
            Console.WriteLine("Current State.....");
            if ((t.ThreadState & ThreadState.Aborted) == ThreadState.Aborted)
                Console.WriteLine("Aborted...");
            if ((t.ThreadState & ThreadState.AbortRequested) == ThreadState.AbortRequested)
                Console.WriteLine("AbortRequested");
            if ((t.ThreadState & ThreadState.Background) == ThreadState.Background)
                Console.WriteLine("Background ");
            if ((t.ThreadState & 
                (ThreadState.Stopped | ThreadState.Unstarted | ThreadState.Aborted)) == 0)
                Console.WriteLine("Running ");
            if ((t.ThreadState & ThreadState.Stopped) == ThreadState.Stopped)
                Console.WriteLine("Stopped");
            if ((t.ThreadState & ThreadState.StopRequested) == ThreadState.StopRequested)
                Console.WriteLine("StopRequested ");
            if ((t.ThreadState & ThreadState.Suspended) == ThreadState.Suspended)
                Console.WriteLine("Suspended");
            if ((t.ThreadState & ThreadState.SuspendRequested) == ThreadState.SuspendRequested)
                Console.WriteLine("SuspendRequested ");
            if ((t.ThreadState & ThreadState.Unstarted) == ThreadState.Unstarted)
                Console.WriteLine("UnStatrted ");
            if ((t.ThreadState & ThreadState.WaitSleepJoin) == ThreadState.WaitSleepJoin)
                Console.WriteLine("WaitSleepJoin ");

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //create a Second Thread
            Thread t2 = new Thread(new ThreadStart(Countdown));
            DumpThreadState(t2);

            // Launch The Second Thread
            t2.Start();
            DumpThreadState(t2);

            // and meanwhile call the Countdown method from the first thread
            Countdown();

            // shut down the second thread
            t2.Abort();
            DumpThreadState(t2);
        }
    }
}
