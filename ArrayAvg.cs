using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class ArrayAvg
    {
        static void Main(string[] args)
        {
            int[] ary = new int[5];
            int sum = 0;
            double avg=0;

            Console.WriteLine("Input 5 Elements");

            for (int i = 0; i < ary.Length; i++)
            {

                ary[i] = Int32.Parse(Console.ReadLine());

            }
            foreach (int i in ary)
            {
               sum +=  ary[i] ;
            }

            avg = sum / ary.Length;
            Console.WriteLine("The Avrage of Elements is : " + avg);



        }
    }
}
