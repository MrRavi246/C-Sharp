using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.OOPs
{

    public interface InShape
    {
        double getArea(double l , double h);
    }
    public interface Color
    {
        void getColor(string c);
    }
    public class InRectangle : InShape, Color       //Multiple Inheritance
    {
        public double getArea(double l, double h)
        {
            return l * h;
        }

        public void getColor(string c)
        {
            Console.WriteLine("Color: "+c);
        }
    }

 
internal class InterfaceDemo
    {
        static void Main(string[] args)
        {
            InRectangle r = new InRectangle();


            Console.WriteLine("Area of Rectangle : " + r.getArea(10, 15));
            r.getColor("RED");
        }
    }
}
