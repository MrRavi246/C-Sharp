using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.OOPs
{
    public abstract class Shape
    {
        double length;
        double height;

        public Shape(double length, double height)
        {
            this.length = length;
            this.height = height;
        }


        public double getLength() { return length; }

        public double getHeight() { return height; }

        public abstract double getArea();


    }
    public class Rectangle : Shape
    {
        public Rectangle(double length, double height) : base(length, height) { }
        public override double getArea()
        {
            return getLength() * getHeight();
        }
    }

    public class Triangle : Shape
    {
        public Triangle(double length, double height) : base(length, height) { }
        public override double getArea()
        {
            return 0.5 * getLength() * getHeight();
        }
    }

    internal class AbstractionDemo
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 20);
            Console.WriteLine("Area of Rectangle : " + r.getArea());

            Triangle t = new Triangle(10, 20);
            Console.WriteLine("Area of Triangle : " + t.getArea());
        }
    }
}

