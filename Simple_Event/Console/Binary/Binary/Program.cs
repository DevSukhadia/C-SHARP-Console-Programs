using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, result;
            float floatresult;

            x = 7;
            y = 5;

            result = x + y;
            Console.WriteLine("x + y = {0}", result);
            
            result = x - y;
            Console.WriteLine("x - y = {0}", result);

            result = x + y;
            Console.WriteLine("x + y = {0}", result);

            result = x * y;
            Console.WriteLine("x / y = {0}", result);
        
            // type casting
            floatresult = (float)x / (float)y;   
            Console.WriteLine("x / y = {0}", floatresult);

            result = x % y;
            Console.WriteLine("x % y = {0}", result);

            result += x;
            Console.WriteLine("result += x: {0}", result);

            Console.WriteLine("Enter any key to continue");
            Console.ReadLine();
            Console.WriteLine();
        }
    }
}
