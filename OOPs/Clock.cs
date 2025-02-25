using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.OOPs
{
    public class Time
    {
        int sec, min, hours;
        //string time = "";

        public Time() 
        {
            Console.Write("Enter Second : ");
            sec = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Minutes : ");
            min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Hours : ");
            hours = Convert.ToInt32(Console.ReadLine());
        }

        public void TimeIncrement()
        {
            sec++;

            if (sec >= 59)
            {
                sec = 0;
                min++;
                if (min >= 59)
                {
                    min = 0;
                    hours++;
                    if (hours >= 24)
                    {
                        hours = 1;
                        min = 0;
                        sec = 0;
                    }
                }
            }
            Console.WriteLine("Updated Time : " + hours + ":" + min + ":" + sec);
        }
        public void TimeDisplay()
        {
            Console.WriteLine("Time is : " + hours + ":" + min + ":" + sec);
        }
    }
    public class Clock
    {
        public static void Main(string[] args)
        {
            Time t1 = new Time(); 

            t1.TimeDisplay();
            t1.TimeIncrement();
        }
    }
}
