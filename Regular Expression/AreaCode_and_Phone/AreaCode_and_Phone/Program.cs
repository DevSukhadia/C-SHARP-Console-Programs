using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;

namespace AreaCode_and_Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "(800) 888-1211\n" +
                          "(212) 555-1212\n" +
                          "(506) 777-1213\n" +
                          "(650) 222-1214\n" +
                          "(888) 111-1215\n";

            string areaCoderegExp = @"(?<areaCodeGroup>\(\d\d\d))";

            string phoneRegExp = @"(?<phoneGroup>\d\d\d\-\d\d\d\d)";

            MatchCollection myMatchCollection = Regex.Matches(text, areaCoderegExp + " " + phoneRegExp);

            foreach (Match myMatch in myMatchCollection)
            {
                Console.WriteLine("Area Code = " + myMatch.Groups["areaCodeGroup"]);
                Console.WriteLine("Phone = " + myMatch.Groups["phoneGroup"]);
                
                foreach (Group myGroup in myMatch.Groups)
                    foreach (Capture myCapture in myGroup.Captures)
                        Console.WriteLine("myCapture.Value = " + myCapture.Value);
            }
        }
    }
}
