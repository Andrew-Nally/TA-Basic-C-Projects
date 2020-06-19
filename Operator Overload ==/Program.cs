using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload___
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Same", "Person");
            Employee emp2 = new Employee("Same", "Person");
            Employee emp3 = new Employee("Different", "Person");
            emp3.Id = 1;

            Console.WriteLine("Emp1 and Emp2: ");
            Console.WriteLine("Result: " + Convert.ToString(emp1 == emp2));
            Console.WriteLine("Emp2 and Emp3: ");
            Console.WriteLine("Result: " + Convert.ToString(emp3 == emp2));
            Console.ReadLine();
        }
    }
}