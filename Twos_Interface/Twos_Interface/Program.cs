using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Twos_Interface
{
    public interface ISeries
    {
        int getNext(); // return next number in series
        void reset(); // restart
        void setStart(int x); // set starting value
    }
    // Implement Iseries
    class ByTows : ISeries
    {
        int start, val;
        public ByTows()
        {
            start = 0;
            val = 0;
        }

        public int getNext()
        {
            val += 2;
            return val;
        }
        public void reset()
        {
            val = start;
        }
        public void setStart(int x)
        {
            start = x;
            val = start;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ByTows ob = new ByTows();

            for (int i = 0; i < 5; i++)
                Console.WriteLine("Next value is " + ob.getNext());

            Console.WriteLine("\nResetting...");
            ob.reset();

            for (int i = 0; i < 5; i++)
                Console.WriteLine("Next value is " + ob.getNext());

            Console.WriteLine("\nStarting from 100...");
            ob.setStart(100);

            for (int i = 0; i < 5; i++)
                Console.WriteLine("Next value is " + ob.getNext());
        }
    }
}
