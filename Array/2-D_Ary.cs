using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class _2_D_Ary
    {
        static void Main(string[] args)
        {
            //int[,] ary = new int[2, 2];

            //ary[0,0] = 1;
            //ary[0,1] = 2;
            //ary[1,0] = 3; 
            //ary[1,1] = 4;


            int[,] ary = { { 10, 11 }, { 12, 13 } };

            Console.WriteLine("Element [0][1] = "+ary[0,0]);
            Console.WriteLine("Element [0][1] = "+ary[0,1]);
            Console.WriteLine("Element [1][0] = "+ary[1,0]);
            Console.WriteLine("Element [1][1] = " + ary[1,1]);


            Console.ReadLine();
        }
    }
}
