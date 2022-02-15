using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;

namespace Module_Assembly
{
    class Program
    {
        static void Main(string[] args)
        {
            Module[] moduleArray;
            moduleArray = Assembly.GetExecutingAssembly().GetModules(false);
            Module myModule = moduleArray[0];

            Assembly myAssembly = myModule.Assembly;
            Console.WriteLine("myModule.Assembly = {0}.", myAssembly.FullName);
        }
    }
}
