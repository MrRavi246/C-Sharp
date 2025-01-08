using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.P1
{
    internal class PA1Q8
    {
        static void Main(string[] arg)
        {
            double sub1 = 0, sub2 = 0, sub3 = 0;

            Console.Write("Enter sub1 Marks : ");
            sub1 = Double.Parse(Console.ReadLine());

            Console.Write("Enter sub2 Marks : ");
            sub2 = Double.Parse(Console.ReadLine());

            Console.Write("Enter sub3 Marks : ");
            sub3 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Total Marks : " + (sub1 + sub2 + sub3));

            Console.WriteLine("Avrage Marks : "+((sub1 + sub2 + sub3 )/ 3));

            Console.WriteLine("Percentage = " + ((sub1 + sub2 + sub3) / 300)* 100 + "%");

        }
    }
}
