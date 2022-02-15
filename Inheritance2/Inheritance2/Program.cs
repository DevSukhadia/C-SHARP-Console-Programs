using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance2
{
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent Constructor");
        }
        public void print()
        {
            Console.WriteLine("I'm a Parent Class");
        }
    }
    public class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("Child Constructor");
        }
        static void Main(string[] args)
        {
            ChildClass child = new ChildClass();

            child.print();
            Console.ReadLine();
        }
    }
}
