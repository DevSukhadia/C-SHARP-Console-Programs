using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Own_Exception_Class
{
    //  Custom Exception Class
    class MyCustomException : 
        System.ApplicationException
    {
        public MyCustomException(string message) :
            base(message) //pass the message up to the base class
        { 
        
        }
    }
    public class TesterExceptionHandling
    {
        public void Run()
        {
            try
            {

                Console.WriteLine("Open file here");
                double a = 0, b = 5;
                Console.WriteLine("{0} / {1} = {2}", a, b, DoDivide(a, b));
                Console.WriteLine("This line may or may not print");
            }
            // Most derived exeption type first
            catch (System.DivideByZeroException e)
            {
                Console.WriteLine("\nDivideByZeroException! Mas: {0}", e.Message);
                Console.WriteLine("\nHelpLink: {0}\n", e.HelpLink);
            } // Catch Custom Exception
            catch (MyCustomException e)
            {
                Console.WriteLine("\nMyCustomException! Msg: {0}", e.Message);
                Console.WriteLine("\nHelpLink: {0}\n", e.HelpLink);
            }
            catch // Catch Uncaught Exception
            {
                Console.WriteLine("Unknownn Exeption Caught");
            }
            finally {
                Console.WriteLine("Close File Here");
            }
        }
        // do the division if legal
        public double DoDivide(double a, double b)
        {
            if (b == 0)
            {
                DivideByZeroException e = new DivideByZeroException();
                e.HelpLink = "www.google.com";
                throw e;
            }
            if (a == 0)
            { 
                // create a custom exception instance
                MyCustomException e = new MyCustomException("Error in your own error");
                e.HelpLink = "www.github.com";
                throw e;
            }
            return a / b;
        }
        static void Main()
        {
            Console.WriteLine("Enter Main...");
            TesterExceptionHandling t = new TesterExceptionHandling();
            t.Run();
            Console.WriteLine("Exit Main....");
        }
    }
}
