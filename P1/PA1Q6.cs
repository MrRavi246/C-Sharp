using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class PA1Q6
    {
        static void Main(string[] args)
        {
            double mm = 0, m= 0;

            Console.Write("Enter mm : ");
            mm = Double.Parse(Console.ReadLine());

            Console.WriteLine("mm to cm : " + mm / 10 + "cm");

            Console.WriteLine("Enter m : " ); 

            m = Double.Parse(Console.ReadLine());

            Console.WriteLine("m to km : " + m / 1000+"km");


        }
    }
}
