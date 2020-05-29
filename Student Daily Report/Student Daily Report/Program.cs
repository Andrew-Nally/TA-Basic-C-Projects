using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();
            Console.WriteLine("What Course Are You On?");
            string courseName = ("C#");
            Console.ReadLine();
            Console.WriteLine("I am on " + courseName);
            Console.ReadLine();
            Console.WriteLine("What Page Number?");
            string pageNumber = Console.ReadLine();
            int pgNum = 73;
            Console.WriteLine("I am on page number: " + pgNum);
            Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();
            bool answer = false;
            Console.WriteLine(answer);
            Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you would like to share?" +
                "Please give specifics.");
            Console.ReadLine();
            string experience = ("Learning C# hasnt been difficult for me to grasp so far, hoping it stays this way!");
            Console.WriteLine(experience);
            Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide.Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("None at this time");
            Console.ReadLine();
            Console.WriteLine(feedback);
            Console.WriteLine("How many hours did you study today?");
            Console.ReadLine();
            int hoursStudied = 9;
            Console.WriteLine("I studied for " + hoursStudied + " hours");
            Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
