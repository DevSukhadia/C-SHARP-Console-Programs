using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            string myInput;
            int myInt;
            Console.WriteLine("Please enter a number: ");
            myInput = Console.ReadLine();
            myInt = Convert.ToInt32(myInput);

            if (myInt > 0)
            {
                Console.WriteLine("Your number {0} is greater then 0",myInt);
            }
            if (myInt < 0)
            {
                Console.WriteLine("Your number {0} is lesser than ");
            }

        }
    }
}
