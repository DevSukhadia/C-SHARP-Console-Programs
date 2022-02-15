using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double f, c;
            int counter = 0;

            for (f = 0.0; f < 100.0; f++)
            {
                c = (f - 32.0) * 5.0 / 9.0;
                Console.WriteLine(f + " degrees Farenhiet is " + c + " degrees Celcius");
                counter++;
                // every 10th line, print a blank line
                if (counter == 10)
                {
                    Console.WriteLine();
                    counter = 0;
                }
            }
        }
    }
}
