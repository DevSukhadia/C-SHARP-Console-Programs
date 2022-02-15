using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            const1 obj1 = new const1();
            const1 obj2 = new const1(6, 8, 4.5);
        }
    }
    class const1
    {
        public const1()
        {
            Console.WriteLine("Welcome to defalut constructor");
        }
        public const1(int a, int b, double c)
        {
            Console.WriteLine("The vloume of cube is {0}", a*b*c);            
        }
    }
}
