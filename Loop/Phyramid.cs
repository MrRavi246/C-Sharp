using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Loop
{
    internal class Phyramid
    {
        public static void Main(string[] args)
        {
            for(int i = 0; i <= 5; i++)
            {
                Console.Write("*");
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
