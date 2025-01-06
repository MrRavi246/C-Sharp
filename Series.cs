using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class Series
    {
        static void Main(string[] args)
        {
            int[] ary = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum=0, n=0;


            Console.WriteLine("Sum of Array : "+ary.Sum());

            Console.Write("Enter N number for sum : ");
            n = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < ary.Length; i++)
            {
                sum += ary[i];
            }
            Console.WriteLine("Sum of " + n + " is " + sum); 


            Console.ReadLine();
        }
    }
}
