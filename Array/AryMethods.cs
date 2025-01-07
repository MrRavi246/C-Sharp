using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class AryMethods
    {

        static void Main(string[] args)
        {
            int[] ary = new int[5];


            Console.WriteLine("Input 5 Elements");

            for (int i = 0; i < ary.Length; i++)
            {

                ary[i] = Int32.Parse(Console.ReadLine());

            }

            Console.WriteLine("Sum of All Element is : " + ary.Sum());
            Console.WriteLine("Avrage of all elements in array : "+ary.Average());
            Console.WriteLine("Number of Elements in array : "+ary.Count());
            Console.WriteLine("Minimun Elmenent in array : "+ary.Min());
        }
    }
}