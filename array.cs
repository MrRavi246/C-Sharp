using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class array
    {
        static void Main(string[] args)
        {
            //int[]age = new int[5];
            //age[0] = 18;
            //age[1] = 20;
            //age[2] = 21;
            int[] age = { 17, 18, 19, 20, 21 }; //declation and inizialisation
            

            Console.WriteLine("First persone age : "+age[0]);
            Console.WriteLine("Second persone age : " + age[1]);
            Console.WriteLine("Third persone age : " + age[2]);

            age[0]=20;
            Console.WriteLine("First persone updated age : " + age[0]);
            Console.WriteLine();
            Console.WriteLine("Traversal of array Using for loop");

            for (int i = 0; i < age.Length; i++)
            {
                Console.WriteLine(age[i]);
            }

            Console.WriteLine("Traversal of array Using foreach loop");
            foreach (int i in age)
            {
                Console.WriteLine(i);
            }


            Console.ReadLine();
        }        
    }
}
