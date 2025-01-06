using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class _2DAryAddition
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 2];
            int[,] arr2 = new int[2, 2];
            int[,] arr3 = new int[2, 2];

            Console.WriteLine("Enter Element of 2x2 array 1:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Element of 2x2  array 1:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    Console.Write(arr[i, j] + " ");

                }
                Console.WriteLine();
            }


            Console.WriteLine("Enter Element of 2x2 array 2:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr2[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Element of 2x2  array 2:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    Console.Write(arr2[i, j] + " ");

                }
                Console.WriteLine();
            }


            Console.WriteLine("Addition of array1 & array2 :");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    Console.Write(arr[i, j] + arr2[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
