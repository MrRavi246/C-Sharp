using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.OOPs
{

    public class book1
    {
        double price;
        int pages;
        string colour;

        public void getData()
        {
            Console.WriteLine("Enter book price : ");
            price = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Pages : ");
            pages = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter colour of book");
            colour = Console.ReadLine();   
        }

        public void showData()
        {
            Console.WriteLine("The price of book is : " + price);
            Console.WriteLine("Book pages are : " + pages);
            Console.WriteLine("Colour of book : " + colour);
        }
    }
    class DemoClass2
    {
        public static void Main(string[] args)
        {
            book1 b1 = new book1();
            b1.getData();
            b1.showData();

            Console.ReadKey();
        }
    }
}
