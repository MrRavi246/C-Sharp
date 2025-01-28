using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.OOPs
{
    public static class Author
    {
        public static string name = "XYZ";
        public static string title = "C# programming";

        public static void Display()
        {
            Console.WriteLine("Author Name : " + name);
            Console.WriteLine("Title : " + title);
        }
    }
    public class StaticDemo
    {
        public static void Main(string[] args)
        {
            Author.Display();
            Console.ReadKey();
        }
    }


}
