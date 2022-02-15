using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {   
            string[] names = {"Cheryl", "Joe", "Matt", "Robert"};

            foreach (string name in names)
            {
                Console.WriteLine("{0} ",name);
            }

        }
    }
}
