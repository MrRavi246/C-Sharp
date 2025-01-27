using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.P1
{
    internal class PA1Q9
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.Write("Enter number : ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Multiplication Table of " + num + " is : ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + num * i);
            }


            Console.ReadKey();
        }
    }
}
