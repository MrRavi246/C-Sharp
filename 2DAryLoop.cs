using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class _2DAryLoop
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 2];

            Console.WriteLine("Enter Element of 2x2 :");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Element of 2x2 :");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
