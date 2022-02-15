using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace indexer_to_create_a_fail_soft_array
{
    class FailSoftArray
    {
        int[] a; // reference to underlying array
        public int Length; // Length is public
        public bool errflag; // indicates outcome of last operation
        // Comstructor:- array given its size
        public FailSoftArray(int size)
        {
            a = new int[size];
            Length = size;
        }

        // This is the indexer for FailSoftArray
        public int this[int index]
        {
            // This is the get accessor
            get
            {
                if (ok(index))
                {
                    errflag = false;
                    return a[index];
                }
                else
                {
                    errflag = true;
                    return 0;
                }
            }
            // This is the set accessor
            set
            {
                if (ok(index))
                {
                    a[index] = value;
                    errflag = false;
                }
                else errflag = true;
            }
        }
        private bool ok(int index)
        {
            if (index >= 0 & index < Length)
                return true;
            return false;
        }
    }
    public class FSDemo
    {
        public static void Main()
        {
            FailSoftArray fs = new FailSoftArray(5);
            int x;
            // show quite failures
            Console.WriteLine("Fail quitely.");
            for (int i = 0; i < (fs.Length * 2); i++)
                fs[i] = i * 10;

            for (int i = 0; i < (fs.Length); i++)
            {
                x = fs[i];
                if (x != -1)
                    Console.WriteLine(x + " ");
            }
            Console.WriteLine();
            // Now, generate failures
            Console.WriteLine("\nFail with error reports.");
            for (int i = 0; i < (fs.Length); i++)
            {
                fs[i] = i * 10;
                if (fs.errflag)
                    Console.WriteLine("fs[" + i + "] out-of-bounds");
            }

            for (int i = 0; i < (fs.Length); i++)
            {
                x = fs[i];
                if (!fs.errflag)
                    Console.WriteLine(x + " ");
                else
                    Console.WriteLine("fs[" + i + "] out-of-bounds");

            }
        }
    }
}