using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class PA1Q3
    {
        static void Main(string[] args)
        {
            double pi = 3.14, r = 0, area = 0;

            Console.Write("Enter radius of Circle : ");
            r = Double.Parse(Console.ReadLine());

            area = pi * r * r;

            Console.WriteLine("Area of Circle is : "+area);
        }
    }
}
