using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Loop
{
    internal class Op_Pyramid
    {
        public static void Main(string[] arg)
        {
            for (int i = 1; i <= 5; i++)
            {

                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    Console.Write("*");
                }

                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

