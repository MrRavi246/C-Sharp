using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public delegate int UpdateNo(int n);
    public class Test
    {
        int no;

        public Test(int no)
        {
            this.no = no;
        }

        public int AddNumber(int n)
        {
            no += n;
            return no;
        }

        public int MulNumber(int n)
        {
            no *= n;
            return no;
        }

        public int GetNumber()
        {
            return no;
        }
    }
    internal class DeleDemo
    {
        public static void Main(string[] args)
        {
            Test t = new Test(10);

            Console.WriteLine("Actual Number : " + t.GetNumber());

            UpdateNo add = new UpdateNo(t.AddNumber);
            //add(20);

            //Console.WriteLine("After Addition : "+t.GetNumber());

            UpdateNo mul = new UpdateNo(t.MulNumber);
            //mul(5);
            //Console.WriteLine("After Multiplication : " + t.GetNumber());


            UpdateNo comb;
            comb = add + mul;
            comb(5);
            Console.WriteLine("After Combination : " + t.GetNumber());

        }
    }
}
