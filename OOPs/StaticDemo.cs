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
        

        public static void Update()
        {
            name = "ABC";
        }
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
            Console.WriteLine("Author Details : ");
            Author.Display();
       

            Console.WriteLine("\nAfter Updating Author Details : ");
            Author.Update();

            Author.title = "C# programming for beginners";

            Author.Display();
            Console.ReadKey();
        }
    }


}
