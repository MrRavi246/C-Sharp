using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class ArrayLoop
    {
        static void Main(string[] args)
        {
            int[] ary = new int[5];

            Console.WriteLine("Input 5 Elements");

            for (int i = 0; i < ary.Length; i++)
            {

                ary[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("The Elements Are :");

            foreach(int i in ary)
            {
                Console.WriteLine(i);
            }


        }
    }
}
