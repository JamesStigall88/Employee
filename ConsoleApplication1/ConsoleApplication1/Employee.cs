using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Employee
    {
        public float salary = 40000;
    }

    public class Programmer : Employee
    {
        public float bonus = 10000;
    }

    public class ProjectManager: Employee
    {
        public float bonus = 20000;
    }

    class TestInheritance
    { 

        static void Main(string[] args)
        {
            Programmer p1 = new ConsoleApplication1.Programmer();
            ProjectManager pm1 = new ConsoleApplication1.ProjectManager();

            Console.WriteLine("Salary: " + p1.salary);
            Console.WriteLine("Bonus: " + p1.bonus);

            Console.WriteLine("\n\n");
            Console.WriteLine("Salary: " + pm1.salary);
            Console.WriteLine("Bonus: " + pm1.bonus);

            Console.ReadLine();
        }
    }
}
