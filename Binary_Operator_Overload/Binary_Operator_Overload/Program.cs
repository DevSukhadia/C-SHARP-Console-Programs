using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binary_Operator_Overload
{
    // A 3D Co-ordinate Class
    class ThreeD
    {
        int x, y, z; //3D Co-ordinates
        public ThreeD() { x = y = z = 0; }
        public ThreeD(int i, int j, int k) { x = i; y = j; z = k; }

        // Overload Binary +
        public static ThreeD operator +(ThreeD o1, ThreeD o2)
        {
            ThreeD res = new ThreeD();

            res.x = o1.x + o2.x;
            res.y = o1.y + o2.y;
            res.z = o1.z + o2.z;

            return res;
        }
        // Overload Binary -
        public static ThreeD operator -(ThreeD o1, ThreeD o2)
        {
            ThreeD res = new ThreeD();

            res.x = o1.x - o2.x;
            res.y = o1.y - o2.y;
            res.z = o1.z - o2.z;

            return res;
        }
        public void show()
        {
            Console.WriteLine("x = {0}, y = {1}, z = {2}",x,y,z);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ThreeD a = new ThreeD(1, 2, 3);
            ThreeD b = new ThreeD(10, 10, 10);
            ThreeD c = new ThreeD();
        
            Console.WriteLine("Here is a: ");
            a.show();
            Console.WriteLine();
            Console.WriteLine("Here is b: ");
            b.show();
            Console.WriteLine();

            c = a + b;
            Console.WriteLine("c = a + b : ");
            c.show();
            c = a - b;
            Console.WriteLine("c = a - b : ");
            c.show();
        }
    }
}
