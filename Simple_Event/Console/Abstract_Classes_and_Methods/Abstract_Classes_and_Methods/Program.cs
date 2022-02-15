using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Classes_and_Methods
{
    abstract public class MotorVehicle
    {
        public string make, model;
        public MotorVehicle(string make, string model)
        {
            this.make = make;
            this.model = model;
        }
        abstract public void Accelerate();
    }
    public class Product : MotorVehicle
    {
        public Product(string make, string model)
            : base (make, model)
        {
                // Do Nothing
        }
        public override void Accelerate()
        {
            Console.WriteLine("In Product Accelerate() Method");
            Console.WriteLine(model + " accelerating");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var myproduct = new Product("Toyoto", "MR2");
            myproduct.Accelerate();
        }
    }
}
