using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public class parent
    {
        string parentString;
        public parent()
        {
            Console.WriteLine("Parent Constructor");
        }
        public parent(string myString)
        {
            parentString = myString;
            Console.WriteLine(parentString);
        }
        public void print()
        {
            Console.WriteLine("I'm a Parent Class");
        }
    }
    public class Child : parent
    {
        public Child() : base("From Derived")
        {
            Console.WriteLine("Child Constructor.");
        }
        public new void print()
        {
            base.print();
            Console.WriteLine("I'm a Child class");
        }
        public static void Main()
        {
            Child child = new Child();
            child.print();

            ((parent)child).print();

            Console.WriteLine("press Enter key to continue");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
