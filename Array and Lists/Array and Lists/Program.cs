using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] continents = { "North America", "South America", "Europe", "Antartica", "Africa", "Asia", "Australia" };

            Console.WriteLine("Please select a number between 0 and 6 to recieve your continent to explore");
            int input = Convert.ToInt32(Console.ReadLine());

            while (input < 0 || input > 6)
            {
                Console.WriteLine("Invalid Selection");
                break;
            }
            Console.WriteLine("You picked " + continents[input] + ".");
            Console.ReadLine();

            int[] junePresentations = { 10, 12, 14, 16, 18, 20, 22 };
            Console.WriteLine("Please select a number between 0 and 6 to determine your presentation day.");
            int input2 = Convert.ToInt32(Console.ReadLine());
            while (input2 < 0 || input2 > 6)
            {
                Console.WriteLine("Invalid selection");
            }
            Console.WriteLine(" You will present on: June " + junePresentations[input2] + ".");
            Console.ReadLine();

            List<string> position = new List<string>();
            position.Add("First");
            position.Add("Second");
            position.Add("Third");
            position.Add("Fourth");

            Console.WriteLine("Please select between 0 and 3 to determine your presentation position the day you present:");
            int input3 = Convert.ToInt32(Console.ReadLine());

            while (input3 < 0 || input3 > 3)
            {
                Console.WriteLine("Invalid Selection");
                input3 = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("You will do your presentation about " + continents[input] + " " + position[input3] + " on June " + junePresentations[input2] + ". Thank You and Good Luck!" );

            Console.ReadLine();

        }
    }
}






            