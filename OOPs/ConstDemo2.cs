using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.OOPs
{
    public class Product
    {
        int pid;
        string pname = "";
        double price;
        public static string brand = "Dell";

        public Product()
        {
            Console.WriteLine("--------Enter Product Detail--------");

            Console.Write("Enter Product Id : ");
            pid = Int32.Parse(Console.ReadLine());

            Console.Write("Enter Product Name : ");
            pname = Console.ReadLine();

            Console.Write("Enter Product Price : ");
            price = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine();

        }
        public void showData()
        {
            Console.WriteLine();
            Console.WriteLine("Product Id : " + pid);
            Console.WriteLine("Product Name : " + pname);
            Console.WriteLine("Product Price : " + price);
            Console.WriteLine("Product Brand :" + brand);

        }

    }
    class ConstDemo2
    {
        public static void Main(string[] args)
        {
            Product[] products = new Product[2];

            for (int i = 0; i < products.Length; i++)
            {
                products[i] = new Product();
            }

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Product " + (i + 1) + " Details : ");        
                products[i].showData();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
