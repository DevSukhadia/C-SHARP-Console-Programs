using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            array obj = new array();
            do
            {
                Console.WriteLine("\n1. Addition");
                Console.WriteLine("\n2. Deletion");
                Console.WriteLine("\n3. Maximum Number");
                Console.WriteLine("\n4. Minimum Number");
                Console.WriteLine("\n5. Exit");
                Console.WriteLine("\nEnter Your Choice");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        obj.addition();
                        break;
                    case 2:
                        obj.deletion();
                        break;
                    case 3:
                        obj.findmax();
                        break;
                    case 4:
                        obj.findmin();
                        break;
                    case 5:
                        break;
                }
            } while (choice != 5);
        }
    }
    class array
    {
        int[] a = new int[100];
        int n, pos;
        public array()
        {
            Console.WriteLine("Enter Number of array elements");
            string s = Console.ReadLine();
            n = int.Parse(s);
            Console.WriteLine("Enter arrray elements");
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());
            Console.Write("Array elements are : ");
            for (int i = 0; i < n; i++)
                Console.Write("\t" + a[i]);
        }
        public void addition()
        {
            Console.WriteLine("Enter element and its position");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int element = int.Parse(s1);
            int pos = int.Parse(s2);
            pos -= 1;
            int tmp = n;
            while (pos < tmp)
            { 
                a[tmp] = a[tmp - 1];
                tmp--;
            }
            a[pos] = element;
            n++;
            Console.WriteLine("Noe the array elements are : ");
            for (int i = 0; i < n; i++)
                Console.WriteLine("\t" + a[i]);
        }
        public void deletion()
        {
            int i = 0;
            Console.WriteLine("Enter element to delete");
            int element = int.Parse(Console.ReadLine());
            while (pos < n)
            {
                if (a[i] == element)
                {
                    pos = i;
                    break;
                }
                if (i == n)
                {
                    Console.WriteLine("the number" + element +" is not there");
                    break;
                }
                i++;
            }
            while (pos < n)
                a[pos] = a[++pos];
            --n;
            Console.WriteLine("After deleting, the elements are");
            for (i = 0;i < n; i++)
                Console.WriteLine("\t" + a[i]);
        }
        public void findmax()
        {
            int max = a[0];
            for (int i = 0; i < n; i++)
            {
                if (max < a[i])
                    max = a[i];
            }
            Console.WriteLine("The maximum number in the given array is " + max);
        }
        public void findmin()
        {
            int min = a[0];
            for (int i = 0; i < n; i++)
            {
                if (min < a[i])
                    min = a[i];
            }
            Console.WriteLine("The maximum number in the given array is " + min);
        }
    }
}
