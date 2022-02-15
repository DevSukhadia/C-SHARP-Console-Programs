using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace illustrates_Operator_Overloading
{
    // Declare Rectangle Class
    class Rectangle
    { 
        //Declasre the fieldws
        public int width;
        public int height;

        // define Constructor
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        // Override ToString Method
        public override string ToString()
        { 
            return "width = " + width + ", height = " + height;   
        }
        // Overload == Operator
        public static bool operator ==(Rectangle lhs, Rectangle rhs)
        {
            Console.WriteLine("In operator ==");
            if (lhs.width == rhs.width && lhs.height == rhs.height)
                return true;
            else
                return false;
        }
        // Overload != Operator
        public static bool operator !=(Rectangle lhs, Rectangle rhs)
        {
            Console.WriteLine("In operator !=");
            return !(lhs == rhs);
        }
        // Overlopad Equals() Method
        public bool Equals(object obj)
        {
            Console.WriteLine("In Equals()");
            if (!(obj is Rectangle))
                return false;
            else
                return this == (Rectangle) obj;
        }
        // Overload + Operator
        public static Rectangle operator +(Rectangle lhs, Rectangle rhs)
        {
            Console.WriteLine("In Operator +");
            return new Rectangle(lhs.width + rhs.width, lhs.height+ rhs.height);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var myRectangle1 = new Rectangle(1, 4);
            Console.WriteLine("myRectangle1: " + myRectangle1);
            var myRectangle2 = new Rectangle(1, 4);
            Console.WriteLine("myRectangle2: " + myRectangle2);
        
            if (myRectangle1 == myRectangle2)
                Console.WriteLine("myRectangle1 is equal to myRectangle2");
            else
                Console.WriteLine("myRectangle1 is not equal to myRectangle2");
            Rectangle myRectangle3 = myRectangle1 + myRectangle2;
            Console.WriteLine("myRectangle3: " + myRectangle3);

        }
    }
}
