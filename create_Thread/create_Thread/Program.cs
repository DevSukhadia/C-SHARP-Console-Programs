using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace create_Thread
{
    class Program
    {
        // The countdown method counts down frm 1000 to 1
        public static void Countdown()
        { 
            for (int CD = 1000; CD > 0; CD--)
                Console.WriteLine(CD.ToString() + " ");    
        }
        static void Main(string[] args)
        {
            /*
            //create a 2nd Thread
            Thread t2 = new Thread(new ThreadStart(Countdown));

            // Launch the 2nd thread
            t2.Start();

            // and meanwhile, call the Countdown() method from the first Thread
            Countdown();
            */
            
             // create a new thread
             Thread t2 = new Thread(new ThreadStart(Countdown));
             // launch the Second Thread
             t2.Start();
            // Block teh 1st Thread until the Second thread is done
             t2.Join();
            // And call the Countdown method from teh first thread
             Countdown();
        }
    }
}
