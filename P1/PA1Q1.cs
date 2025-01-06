using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.P1
{
    internal class PA1Q1
    {
        static void Main(string[] args)
        {

            int num = 0;
            Console.Write("Enter number : ");

            num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("Number is zero");
            }
            else if (num > 1)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is Negative");
            }
            Console.ReadKey();
        }
    }
}
