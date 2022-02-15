using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;
using System.Reflection;

namespace Email
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex r = new Regex(@"\w+@(\w+\.)+\w+");
            Console.WriteLine(r.IsMatch("j@byte.com"));
            Console.WriteLine(r.IsMatch("jn@b.com"));
            Console.WriteLine(r.IsMatch("o47@1.com"));
        }
    }
}
