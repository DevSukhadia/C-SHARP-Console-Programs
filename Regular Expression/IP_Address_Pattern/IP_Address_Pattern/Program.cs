using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;

namespace IP_Address_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create regex to search for IP Address Pattern
            string pattern = @"(?<part1>[01]?\d\d?|2[0-4]\d|25[0-5])\." +
                             @"(?<part2>[01]?\d\d?|2[0-4]\d|25[0-5])\." +
                             @"(?<part3>[01]?\d\d?|2[0-4]\d|25[0-5])\." +
                             @"(?<part4>[01]?\d\d?|2[0-4]\d|25[0-5])\.";

            Regex regex = new Regex(pattern);
            Match match = regex.Match("192.162.123.1");

            string replace = @"${part4}.${part3}.${part2}.${part1}" + 
                             @"(the reverse of $&)";
            Console.WriteLine(regex.Replace("192.162.122.1", replace));
        }
    }
}
