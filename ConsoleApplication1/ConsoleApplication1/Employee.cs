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

    class TestInheritance
    { 

        static void Main(string[] args)
        {
            Programmer p1 = new ConsoleApplication1.Programmer();

            Console.WriteLine("Salary: " + p1.salary);
            Console.WriteLine("Bonus: " + p1.bonus);

            Console.ReadLine();
        }
    }
}
