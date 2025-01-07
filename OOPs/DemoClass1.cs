using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.OOPs
{
    public class book
    {
        double price;
        int pages;
        string colour;

        public void getData()
        {
            price = 70;
            pages = 120;
            colour = "red";
        }

        public void showData()
        {
            Console.WriteLine("The price of book is : " + price);
            Console.WriteLine("Book pages are : " + pages);
            Console.WriteLine("Colour of book : " + colour);
        }
    }
    class DemoClass1
    {
        public static void Main(string[] args)
        {
            book b1 = new book();
            b1.getData();
            b1.showData();

            Console.ReadKey();
        }
    }
}

