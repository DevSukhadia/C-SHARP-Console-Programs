using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Destructor
{
    class OutputClass
    { 
        //private dtatype
        string myString;

        //Constructor
        public OutputClass(string inputString)
        {
            myString = inputString;
        }
         
        //Instance Method
        public void printString()
        {
            Console.WriteLine("{0}", myString);
        }

        //Destructor
        ~OutputClass()
        { 
            // Some resource cleanup routine
        }
    }
    class ExmapleClass
    {
        public static void Main(string[] args)
        {
            // Instance of OutputClass
            OutputClass outC1 = new OutputClass("This is printed by OutputCLass");

            //Call Output class' method
            outC1.printString();
        }
    }
}
