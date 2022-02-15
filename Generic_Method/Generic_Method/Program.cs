using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Method
{
    class ArrayUtils
    {
        public static bool copyInsert<T>(T e, int idx, T[] src, T[] target)
        {
            if (target.Length < src.Length + 1)
                return false;
            for (int i = 0, j = 0; i < src.Length; i++, j++)
            {
                if (i == idx)
                {
                    target[j] = e;
                    j++;
                }
                target[j] = src[i];
            }

            return true;
        }
    }
    class Test
    {
        public static void Main()
        {
            int[] nums = { 1, 2, 3 };
            int[] nums2 = new int[4];

            Console.WriteLine("Contents ofn Nums: ");
            foreach (int x in nums)
                Console.WriteLine(x + " ");

            Console.WriteLine();

            ArrayUtils.copyInsert(99, 2, nums, nums2);

            Console.WriteLine("Contents ofn Nums2: ");
            foreach (int x in nums2)
                Console.WriteLine(x + " ");

            Console.WriteLine();

            string[] str = {"Generics", "are", "powerfull"};
            string[] str2 = new string[4];

            Console.WriteLine("Contents of Str: ");
            foreach (string x in str)
                Console.WriteLine(x + " ");

            Console.WriteLine();

            ArrayUtils.copyInsert("In C#", 1, str, str2);

            Console.WriteLine("Contents ofn Str2: ");
            foreach (string x in str2)
                Console.WriteLine(x + " ");

            Console.WriteLine();
        }
    }
}
