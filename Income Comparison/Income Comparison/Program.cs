using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate? Enter a whole number.");
            int firstHourly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours Worked per Week? Enter a whole number.");
            int firstHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate? Enter a whole number.");
            int secondHourly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours Worked per Week? Enter a whole number.");
            int secondHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Annual Salary of Person 1:");
            int firstSalary = (firstHourly * firstHours) * 52;
            Console.WriteLine(firstSalary);
            Console.WriteLine("Annual Salary of Person 2:");
            int secondSalary = (secondHourly * secondHours) * 52;
            Console.WriteLine(secondSalary);
            Console.ReadLine();
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool salary = (firstSalary > secondSalary);
            Console.WriteLine(salary);
            Console.Read();   
        }
    }
}
