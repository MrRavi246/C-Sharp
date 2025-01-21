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
        public Student(int rollno, string name, int sem, double cgpa)
        {
            this.rollno = rollno;
            this.name = name;
            this.sem = sem;
            this.cgpa = cgpa;
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
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
        }
    }

    class ConstDemo1
    {
        public static void Main(string[] args)
        {
            Std s1 = new Std(1, "John", 8, 3);
            s1.ShowData();

            Console.WriteLine("Enter Student 2 Details : ");
            Student s2 = new Student();
            s2.ShowData();

            Console.ReadKey();


        }

    }
}
