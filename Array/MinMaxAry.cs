using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class MinMaxAry
    {
        static void Main(string[] args)
        {
            int[] ary = new int[5];
            int min, max;

            Console.WriteLine("Input 5 Elements");

            for (int i = 0; i < ary.Length; i++)
            {

                ary[i] = Int32.Parse(Console.ReadLine());

            }

            min = ary[0];
            max = ary[0];
            for (int i = 0; i < ary.Length; i++)
            {


                if (ary[i] < min)
                {
                    min = ary[i];
                }
            }
            for (int i = 0; i < ary.Length; i++)
            {

                if (ary[i] > max)
                {
                    max = ary[i];
                }
            }
            Console.WriteLine("Minimum Elemnet of array is : " + min);
            Console.WriteLine("Maximum Elemnet of array is : " + max);
            Console.ReadLine();
        }
    }
}
