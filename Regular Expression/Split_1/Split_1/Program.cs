using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;
namespace Split_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "A, B, cCCC, D";
            Regex r = new Regex(@" |, ");
            foreach (string sub in r.Split(s))
                Console.WriteLine("Word : {0}", sub);
        }
    }
}
