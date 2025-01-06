using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class PA1Q4
    {
        static void Main(string[] args)
        {
            double l = 0, area = 0;

            Console.Write("Enter Lenght of Square: ");
            l = Double.Parse(Console.ReadLine());

            area = l * l;

            Console.WriteLine("Area of Square is : " + area);
        }
    }
}
