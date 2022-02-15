using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultipleCatchBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int[] myArray = new int[2];

                //Console.WriteLine("Attempting to access an invalid array element");
               // myArray[2] = 3;

                Console.WriteLine("Attempting to Divide By Zero");
                int b = 0;
                myArray[0] = 1 / b;

            }
            catch (DivideByZeroException e)
            {

                // code that handles a DivideByZeroException
                Console.WriteLine("Handling a System.DivideByZeroException object");
                Console.WriteLine("Message = " + e.Message);
                Console.WriteLine("StackTrace = " + e.StackTrace);

            }
            catch (IndexOutOfRangeException e)
            {

                // code that handles an IndexOutOfRangeException
                Console.WriteLine("Handling a System.IndexOutOfRangeException object");
                Console.WriteLine("Message = " + e.Message);
                Console.WriteLine("StackTrace = " + e.StackTrace);

            }
            catch (Exception e)
            {

                // code that handles a generic Exception: all other exceptions
                Console.WriteLine("Handling a System.Exception object");
                Console.WriteLine("Message = " + e.Message);
                Console.WriteLine("StackTrace = " + e.StackTrace);

            }
        }
    }
}
