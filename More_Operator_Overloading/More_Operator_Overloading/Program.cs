using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace More_Operator_Overloading
{
    class ThreeD
    {
        int x, y, z; // 3D Co-ordinates

        public ThreeD() { x = y = z = 0; }
        public ThreeD(int i, int j, int k) { x = i; y = j; z = k; }

        //Overload unary -
        public static ThreeD operator -(ThreeD ob)
        {
            ThreeD res = new ThreeD();

            res.x = -ob.x;
            res.y = -ob.y;
            res.z = -ob.z;
            return res;
        }

        //Overload unary ++
        public static ThreeD operator ++(ThreeD ob)
        {
            ob.x++;
            ob.y++;
            ob.z++;
            return ob;
        }
        public void show()
        {
            Console.WriteLine("x = {0}, y = {1}, z = {2}",this.x, this.y, this.z);
        }    
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = new ThreeD(1, 2, 3);
            var b = new ThreeD(10, 20, 30);
            var c = new ThreeD();
            Console.WriteLine("Here is a:");
            a.show();
            Console.WriteLine("Here is b:");
            b.show();
            Console.WriteLine("c = -a is :");
            c = -a;
            Console.WriteLine("Here is c:");
            c.show();
            Console.WriteLine("Here is a++:");
            a++;
            a.show();
        }
    }
}
