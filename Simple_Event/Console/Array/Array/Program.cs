using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myInts = {5, 10, 15};
            bool[][] myBools = new bool[2][];
            myBools[0] = new bool[2];
            myBools[1] = new bool[1];
            double[,] myDouble = new double[2, 2];
            string[] myString = new string[3];

            Console.WriteLine("myInts[0] : {0}, myInts[1] : {1}, myInts[2] : {2}\n", myInts[0], myInts[1], myInts[2]);

            myBools[0][0] = true;
            myBools[0][1] = false;
            myBools[1][0] = true;
            Console.WriteLine("myBools[0][0]: {0}, myBools[0][1]: {1}, myBools[1][0]: {2}\n", myBools[0][0], myBools[0][1], myBools[1][0]);

            myDouble[0, 0] = 3.243;
            myDouble[0, 1] = 3.2454;
            myDouble[1, 0] = 1.243;
            myDouble[1, 1] = 6.243;
            Console.WriteLine("myDouble[0, 0]: {0}, myDouble[0, 1]: {1}, myDouble[1, 0]: {2}, myDouble[1, 1]: {3}\n", myDouble[0, 0], myDouble[0, 1], myDouble[1, 0], myDouble[1, 1]);

            myString[0] = "Dev";
            myString[1] = "Joe";
            myString[2] = "Matt";
            Console.WriteLine("myString[0]: = {0}, myString[1]: = {1}, myString[2]: = {2}", myString[0], myString[1], myString[2]);

            Console.ReadLine();
        }
    }
}
