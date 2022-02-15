using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //display odd no.
            for (int i = 0; i < 20; i++)
            {
                if (i == 10)
                    break;
                if (i % 2 == 0)
                    continue;
                Console.WriteLine("{0} ",i);
            }
        }
    }
}
