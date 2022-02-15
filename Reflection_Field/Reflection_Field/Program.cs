using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;

namespace Reflection_Field
{
    static class ReflectionTest
    {
        public static int Height, Width, Weight;
        public static string Name;

        public static void Write()
        { 
            Type type = typeof(ReflectionTest); // Get Type Pointer
            FieldInfo[] fields = type.GetFields(); // Obtain all Fields
            foreach (var field in fields) // Loop Through Fields
            {
                string name = field.Name; // Get String Name
                object temp = field.GetValue(null); // Get Value
                if (temp is int)
                { 
                    int value = (int)temp;
                    Console.Write(name);
                    Console.Write(" (int) = ");
                    Console.WriteLine(value);
                }
                else if (temp is string)
                { 
                    string value = (string)temp;
                    Console.Write(name);
                    Console.Write(" (string) = ");
                    Console.WriteLine(value);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ReflectionTest.Height = 100;
            ReflectionTest.Weight = 50;
            ReflectionTest.Width = 300;
            ReflectionTest.Name = "Dev";
            ReflectionTest.Write();
        }
    }
}
