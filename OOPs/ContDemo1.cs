using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.OOPs
{
    public class Student
    {
        int rollno;
        string name;
        double cgpa;
        int sem;
        public Student()
        {
            Console.Write("Enter name of the Student : ");
            name = Console.ReadLine();

            Console.Write("Enter Roll No : ");
            rollno = Int32.Parse(Console.ReadLine());

            Console.Write("Enter CGPA : ");
            cgpa = double.Parse(Console.ReadLine());

            Console.Write("Enter Semester : ");
            sem = Int32.Parse(Console.ReadLine());
        }

        public void ShowData()
        {
            Console.WriteLine();
            Console.WriteLine("-------------Student Details-------------");
            Console.WriteLine();
            Console.WriteLine("Name of the Student : " + name);
            Console.WriteLine("Roll No : " + rollno);
            Console.WriteLine("CGPA : " + cgpa);
            Console.WriteLine("Semester : " + sem);
        }
    }

    class ContDemo1
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.ShowData();
            Console.ReadKey();
        }

    }
}
