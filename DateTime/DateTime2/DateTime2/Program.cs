using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateTime2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("24 hour time is: {0:ss:mm}", dt);
        }
    }
}
