using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;
namespace Phone_nos
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] phone_nos = { "111-123-4567", "1111-1234-4567"};
            string phone_regexp = "[0-9]{3}-[0-9]{3}-[0-9]{4}";
            foreach (string phone in phone_nos)
            {
                Match m = Regex.Match(phone, phone_regexp);

                if (m.Success)
                    Console.WriteLine(phone + " is Valid");
                else
                    Console.WriteLine(phone + " is not valid");
            }
        }
    }
}
