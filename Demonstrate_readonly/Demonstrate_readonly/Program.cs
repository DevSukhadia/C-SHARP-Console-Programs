using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demonstrate_readonly
{
    class MyClass
    {
        public static readonly int SIZE = 10;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[MyClass.SIZE];

            for (int i = 0; i < MyClass.SIZE; i++)
                nums[i] = i;
            
            foreach (int i in nums)
                Console.Write(i + " ");

            // MyClass.SIZE = 3;   Error!!! Can't Change
        }
    }
}
