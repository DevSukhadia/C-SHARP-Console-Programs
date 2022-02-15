using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Illustrates_Interface
{
    // define the IDrivable Interface
    public interface IDrivable
    { 
        // method declaration
        void start();
        void stop();

        // property declaration
        bool Started
        {
            get;
        }
    }
    // Car class implements the IDrivable Interface
    class Car : IDrivable
    { 
        // declare the underlying field used by the started property
         private bool started = false;

        // Implement the start() method
        public void start()
        {
            Console.WriteLine("Car started");
            started = true;
        }
        public void stop()
        {
            Console.WriteLine("Car stopped");
            started = false;
        }
        //implement the started property
        public bool Started
        {
            get { 
                return started; 
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // create a Car object
            Car myCar = new Car();
            // call myCar.start()
            myCar.start();
            Console.WriteLine("myCar.Started = " + myCar.Started);

            // call myCar.stop()
            myCar.stop();
            Console.WriteLine("myCar.Started = " + myCar.Started);
        }
    }
}
