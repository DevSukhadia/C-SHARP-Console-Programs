using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex r = new Regex(@"\$\d+\.\d{2}");
            string[] money = new string[] 
            {   "$0.99",
                "$1099999.99",
                "$10.25",
                "$90,999.99",
                "$1,990,999.99",
                "$1,999999.99"
            };
            foreach (string m in money)
            {
                Console.Write(m + ": ");
                Console.WriteLine(r.IsMatch(m));
            }
        }
    }
}
