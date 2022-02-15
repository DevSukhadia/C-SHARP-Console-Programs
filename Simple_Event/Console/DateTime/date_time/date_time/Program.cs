using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using C = System.Console;

namespace date_time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            C.WriteLine("d = {0:d}", dt); // mm/dd/yyyy
            C.WriteLine("D = {0:D}", dt); // month dd, yyyy
            C.WriteLine("f = {0:f}", dt); // day, month dd, yyyy hh:mm
            C.WriteLine("F = {0:F}", dt); // day, month dd, yyyy HH:mm:ss AM/PM
            C.WriteLine("g = {0:g}", dt); // mm/dd/yyyy hh:mm
            C.WriteLine("G = {0:G}", dt); // mm/dd/yyyy HH:mm:ss
            C.WriteLine("M = {0:M}", dt); // month dd
            C.WriteLine("R = {0:R}", dt); // ddd Month yyyy hh:mm:ss GMT
            C.WriteLine("s = {0:s}", dt); // yyyy-mm-dd hh:mm:ss (Sortable)
            C.WriteLine("t = {0:t}", dt); // hh:mm AM/PM
            C.WriteLine("T = {0:T}", dt); // hh:mm:ss AM/PM

            // yyyy-mm-dd hh:mm:ss (Sortable)
            C.WriteLine("u = {0:u}", dt);

            // day, month dd, yyyy hh:mm:SS AM/PM
            C.WriteLine("U = {0:U}", dt);

            // month, year (May 2016)
            C.WriteLine("Y = {0:Y}", dt);
            C.WriteLine("Month = ", dt.Month); // month number (5)

            // day of the week (Tuesday)
            C.WriteLine("day of the weeek = " +  dt.DayOfWeek);

            // 24 hour Time
            C.WriteLine("Time of Day = " + dt.TimeOfDay);

            // (6372610677413779)
            C.WriteLine("DateTime.Ticks = " + dt.Ticks); 
            // Ticks are the number of 100 nano-second intervals from 01/01/0001 12:00AM
            // Ticks are useful in elapsed time measurement
        }
    }
}
