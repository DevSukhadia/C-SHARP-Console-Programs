using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _delegate
{
    delegate void FunctionToCall();

    class Program
    {
        static void Main(string[] args)
        {
            MyClass t = new MyClass();
            FunctionToCall functionDelegate;
            functionDelegate = t.nonStaticMethod;

            functionDelegate += MyClass.StaticMethod;
            functionDelegate += t.nonStaticMethod;
            functionDelegate += MyClass.StaticMethod;

            functionDelegate();
        }
    }
    class MyClass
    {
        public void nonStaticMethod()
        {
            Console.WriteLine("Non Static Method");
        }
        public static void StaticMethod()
        {
            Console.WriteLine("Static Method");
        }
    }
}
