using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.P1
{
    internal class PA1Q5
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0, n = 0;

            Console.Write("Enter Number of terms : ");
            n = Int32.Parse(Console.ReadLine());

            Console.Write(a +" "+b+" ");
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(c+" ");
                a = b;
                b = c;
                
            }
            Console.ReadLine();
        }
    }
}
