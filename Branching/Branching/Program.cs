using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please Follow The Instructions Below:");
            Console.ReadLine();
            Console.WriteLine("Please Enter The Package Weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please Enter The Package Width:");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter The Package Height:");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter The Package Length:");
                int length = Convert.ToInt32(Console.ReadLine());
            }
            if ((width + height + length) > 50);
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            Console.WriteLine("Your estimated total for shipping this package is:  ");
        }
    }
}
