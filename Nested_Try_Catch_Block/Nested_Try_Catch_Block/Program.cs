using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nested_Try_Catch_Block
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                // a nested try and catch block
                try
                {

                    int[] myArray = new int[2];
                    Console.WriteLine("Attempting to access an invalid array element");
                    myArray[2] = 1;  // throws the exception

                }
                catch (DivideByZeroException e)
                {

                    // code that handles a DivideByZeroException
                    Console.WriteLine("Handling a DivideByZeroException");
                    Console.WriteLine("Message = " + e.Message);
                    Console.WriteLine("StackTrace = " + e.StackTrace);

                }

            }
            catch (IndexOutOfRangeException e)
            {

                // code that handles an IndexOutOfRangeException
                Console.WriteLine("Handling an IndexOutOfRangeException");
                Console.WriteLine("Message1 = " + e.Message);
                Console.WriteLine("StackTrace = " + e.StackTrace);

            }
        }
    }
}
