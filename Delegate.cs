using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public delegate void ShowDateTime();

    public class Test1
    {
        public void DisplayDateTime()
        {
            Console.WriteLine("Current Time : " + DateTime.Now.ToShortTimeString());
        }
        public void DisplayDate()
        {
            Console.WriteLine("Current Date : " + DateTime.Now.ToShortDateString());
        }

    }
    internal class Delegate
    {
        public static void Main(string[] arg)
        {
            Test1 ob = new Test1();


            ShowDateTime sd = new ShowDateTime(ob.DisplayDateTime);
            sd();

            ShowDateTime sd1 = new ShowDateTime(ob.DisplayDate);
            sd1();



        }
    }
}
