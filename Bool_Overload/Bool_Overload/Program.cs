using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bool_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            var george = new Employee("George", 1);
            var fred = new Employee("Fred", 2);
            var tom = new Employee("Tom", 3);
            var bob = new Employee("Bob", 4);

            Console.WriteLine("George > Fred: {0}",george > fred);
            Console.WriteLine("Tom <= Bob: {0}", tom <= bob);
        }
    }
    public class Employee : IComparable
    {
        string name;
        int id;
        public Employee(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        int IComparable.CompareTo(object ob)
        {
            Console.WriteLine("In IComparable.CompareTo");
            Employee emp2 = (Employee)ob;
            if (this.id > emp2.id)
                return 1;
            else if (this.id < emp2.id)
                return (-1);
            else
                return 0;
        }
        public static bool operator <(Employee e1, Employee e2)
        {
            Console.WriteLine("In Operator <");
            IComparable icomp = (IComparable)e1;
            return (icomp.CompareTo(e2) < 0);
        }
        public static bool operator >(Employee e1, Employee e2)
        {
            Console.WriteLine("In Operator >");
            IComparable icomp = (IComparable)e1;
            if (e1 is Employee)
                Console.WriteLine("Yes");
            return (icomp.CompareTo(e2) > 0);
        }
        public static bool operator <=(Employee e1, Employee e2)
        {
            Console.WriteLine("In Operator <=");
            IComparable icomp = (IComparable)e1;
            return (icomp.CompareTo(e2) <= 0);
        }
        public static bool operator >=(Employee e1, Employee e2)
        {
            Console.WriteLine("In Operator >=");
            IComparable icomp = (IComparable)e1;
            return (icomp.CompareTo(e2) >= 0);
        }
        public override string ToString()
        {
            Console.WriteLine("In ToString()");
            return (name + " : " + id);
        }
    }
}
