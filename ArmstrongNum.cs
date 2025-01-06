using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class ArmstrongNum
    {
        static void Main(string[] args)
        {
            int ExKey=0,multi=1,index=0;
            string num = "0";

            Console.Write("Enter Number : ");
            num = Console.ReadLine();


            for (int i = 0; i < num.Length; i++)
            {
                
                for (int j = 0; j < num.Length; j++)
                {
                    
                    
                    multi *= num.ElementAt(i);
                     
                }
                ExKey += multi;
                multi = 1;
            }
            
            if (Int32.Parse(num) == ExKey)
            {
                Console.WriteLine("It is");
            }

        }
    }
}
