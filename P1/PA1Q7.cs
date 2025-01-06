using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.P1
{
    internal class PA1Q7
    {
        static void Main(string[] args)
        {
            int second = 0;
            Console.Write("Enter Seconds : ");
            second = Int32.Parse(Console.ReadLine());
        
            Console.WriteLine("Seconds to Minutes : " + second / 60 + " minutes");
            Console.WriteLine("Seconds to Hours : " + second / 3600 + " hours");

            Console.ReadKey();
        }
    }
}
