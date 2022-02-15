using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compare_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string t1 = "This is a test string.", t2, t3;
            t2 = t1.Insert(15, "AAA");
            t3 = t1.ToUpper();
            Console.WriteLine("tes1 : {0}", t1);
            Console.WriteLine("tes2 : {0}", t2);
            Console.WriteLine("tes3 : {0}", t3);

            if (t1 == t3)
                Console.WriteLine("Test1 = Test3");
            else
                Console.WriteLine("test1 != test3");
            Console.ReadLine();


        }
    }
}
