using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = {"This", "is", "a", "test."};
            Console.WriteLine("Original Array");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine("\n");

            arr[1] = "was";
            arr[3] = "test, too.";
            Console.WriteLine("Original Array");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.ReadLine(); 
        }
    }
}
