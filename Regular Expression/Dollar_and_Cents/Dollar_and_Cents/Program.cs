using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;

namespace Dollar_and_Cents
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex r = new Regex(@"\$((\d{1,3},)*\d+)\.(\d{2})");
            Match m = r.Match("$1,035.66");
            Console.WriteLine("Dollar part: {0}, cents: {1}", m.Groups[1].Captures[0].Value, m.Groups[3].Captures[0].Value);
        }
    }
}
