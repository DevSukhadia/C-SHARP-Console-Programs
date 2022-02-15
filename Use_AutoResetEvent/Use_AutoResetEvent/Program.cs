using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Use_AutoResetEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoResetEvent aRE = new AutoResetEvent(true);
            bool state = aRE.WaitOne(1000, true);
            Console.WriteLine("After First WaitOne " + state);
            state = aRE.WaitOne(5000, true);
            Console.WriteLine("After Second WaitOne " + state);
        }
    }
}
