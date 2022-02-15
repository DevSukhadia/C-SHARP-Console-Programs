using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calc_with_switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            int inum1, inum2, inum3;
            double dnum;
            Console.WriteLine("Enter first number");
            inum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            inum2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Choice +, -, * or //");
            ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case '+':
                    inum3 = inum1 + inum2;
                    Console.WriteLine("Sum is" + inum3);
                    break;
                case '-':
                    inum3 = inum1 - inum2;
                    Console.WriteLine("Difference is" + inum3);
                    break;
                case '*':
                    inum3 = inum1 * inum2;
                    Console.WriteLine("Product is" + inum3);
                    break;
                case '/':
                    dnum = (Double)(inum1 / inum2);
                    Console.WriteLine("Quotient is " + dnum.ToString());
                    break;
                default:
                    Console.WriteLine("Entered a wrong choice");
                    break;
            }
        }
    }
}
