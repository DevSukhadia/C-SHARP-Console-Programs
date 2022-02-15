using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegate_Array
{
    public delegate double Computedelegate (double x, double y);
    class Program
    {
        static void Main(string[] args)
        {
            MyClass proc1 = new MyClass();
            MyClass proc2 = new MyClass();

            Computedelegate[] delegates = new Computedelegate[]
            {
                new Computedelegate(proc1.Add),
                new Computedelegate(proc2.Add),
                new Computedelegate(MyClass.Sub),
            };
            Computedelegate chained = (Computedelegate)Delegate.Combine(delegates);
            double combined = chained(4, 5);
            Console.WriteLine("Output : " + combined);
        }
    }
    public class MyClass
    {
        public MyClass()
        {  }
        
        public double Add(double x, double y)
        {
            double res = x + y;
            Console.WriteLine("Instance Results: " + res);
            return res;
        }

        public static double Sub(double x, double y)
        {
            double res = x - y;
            Console.WriteLine("Static Results: " + res);
            return res;
        }
        private double factor;
    }
}
