using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;

namespace Split_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "One,Two,Three, YourName, Inc.";
            StringBuilder sBuilder = new StringBuilder();
            int id = 1;
            foreach (string subStr in Regex.Split(s1, " |, |,"))
                sBuilder.AppendFormat("{0}: {1}\n", id++, subStr);

            Console.WriteLine("{0}", sBuilder);
        }
    }
}
