using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.OOPs
{
    public class Student1
    {
        int rllno;
        string name ="";
        double cgpa;

        public int Rllno
        {
            get { return rllno; }
            set { rllno = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public void showData()
        {
            Console.WriteLine(rllno + "\t" + name + "\t" + cgpa);

        }
    }
    internal class PropertyDemo
    {
        public static void Main(string[] args)
        {
            Student1 s1 = new Student1();
            s1.Rllno = 1;
            s1.Name = "John";
            s1.Cgpa = 8.5;
            Console.WriteLine("Student Details : \n");
            Console.WriteLine("Roll No\t Name \tcgpa\n");
            s1.showData();

            Student1 s2 = new Student1();
            s2.Rllno = 2;
            s2.Name = "Doe";
            s2.Cgpa = 8.0;
            s2.showData();

            Student1 s3 = new Student1();

            s3.Rllno = 3;
            s3.Name = "Smith";
            s3.Cgpa = 7.5;
            s3.showData();

            Console.ReadKey();

            
        }
    }
}
