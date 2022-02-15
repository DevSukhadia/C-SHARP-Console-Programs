using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateTime_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            int seconds;

            DateTime dt = DateTime.Now;
            seconds = dt.Second;

            // update if seconds change
            if (seconds != dt.Second)
                seconds = dt.Second;

            t = dt.ToString("T");
            Console.WriteLine(t);
        }
    }
}
