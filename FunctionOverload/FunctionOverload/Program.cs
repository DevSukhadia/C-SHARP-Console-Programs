using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            first obj1 = new first();

            obj1.area(4, 4);
            obj1.area(6.5, 8);
            obj1.area(2, 4.5, 8.6);
            Console.ReadLine();
        }
    }
    public class first
    {
        public void area(int a, int b)
        {
            Console.WriteLine("The area of square is : " +  a * b);
        }
        public void area(double a, int b)
        {
            Console.WriteLine("The area of rectangle is : " + a * b);
        }
        public void area(int a, double b, double c)
        {
            Console.WriteLine("The area of is : " + a * b * c);
        }
    }
}
