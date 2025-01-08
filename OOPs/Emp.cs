using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.OOPs
{
    public class Employees
    {
        int id;
        string name;

        int age;
        int salary;

        public void getData()
        {
            Console.Write("Enter Employee ID : ");
            id = Int16.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name : ");
            name = Console.ReadLine();

            Console.Write("Enter Employee Age : ");
            age = Int16.Parse(Console.ReadLine());

            Console.Write("Enter Employee Salary : ");
            salary = Int32.Parse(Console.ReadLine());
        }

        public void showData()
        {
            Console.WriteLine();
            Console.WriteLine("-------------Employee Details-------------");

            Console.WriteLine("Employee Id is : " + id);
            Console.WriteLine("Employee Name : " + name);
            Console.WriteLine("Employee Age : " + age);
            Console.WriteLine("Employee Salary : " + salary);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();

        }
        public int getAge()
        {
            return age;
        }
    }
    internal class Emp
    {
        public static void Main(string[] args)
        {
            Employees emp1 = new Employees();
            emp1.getData();

            Employees emp2 = new Employees();
            emp2.getData();

            Employees emp3 = new Employees();
            emp3.getData();

            if (emp1.getAge() > emp2.getAge())
            {
                if (emp1.getAge() > emp3.getAge())
                {
                    emp1.showData();
                }



            }
        }
    }
}
