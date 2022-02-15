using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Class_With_Interface
{
    public interface IShape
    {
        double Area
        { get; }
    }
    public class Circle : IShape 
    {
        private double radius;
        public Circle(double radius)
        {  
            this.radius = radius;  
        }
        public double Area
        {
            get
            {
                return 3.14 * radius * radius;
            }
        }
    }
    public class Rect : IShape 
    {
        private double height, width;
        public Rect(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public double Area
        {
            get 
            {
                return height * width;
            }
        }
    }
    public class Shapes<T>
        where T : IShape
    {
        private List<T> shapes = new List<T>();
        public double TotalArea
        {
            get 
            {
                double acc = 0;
                foreach (T shape in shapes)
                    acc += shape.Area;

                return acc;
            }
        }
        public void Add(T shape)
        {
            shapes.Add(shape);
        }
    }
    public class Test
    {
        public static void Main()
        { 
            Shapes<IShape> shapes = new Shapes<IShape>();

            shapes.Add(new Circle(3));
            shapes.Add(new Rect(7, 5));

            Console.WriteLine("Total Area: {0}", shapes.TotalArea);
            Console.WriteLine();
        }
    }
}
