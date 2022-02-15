using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace is_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();
            test(ba);

            SavingsAccount sa = new SavingsAccount();
            test(sa);
        }
        public static void test(BankAccount baArgument)
        {
            if (baArgument is SavingsAccount)
            {
                SavingsAccount saArgument = new SavingsAccount();
                saArgument.Withdraw();
            }
            else {
                baArgument.Withdraw();
            }
        }
    }
    public class BankAccount
    {
        virtual public void Withdraw()
        {
            Console.WriteLine("Call to BankAccoubnt.Withdraw()");
        }
    }
    public class SavingsAccount :  BankAccount
    {
        override public void Withdraw()
        {
            Console.WriteLine("Call to SavingsAccount.Withdaw()");
        }
    }
}
