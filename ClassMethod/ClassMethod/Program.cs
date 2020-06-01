using System;

namespace ClassMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Please enter a whole number:");
            math.Multiply(Convert.ToInt32(Console.ReadLine()));
            Console.ReadLine();

            math = new Math();
            Console.WriteLine("Please enter a whole number:");
            math.Addition(Convert.ToInt32(Console.ReadLine()));
            Console.ReadLine();

            math = new Math();
            Console.WriteLine("Please enter a whole number:");
            math.Divide(Convert.ToInt32(Console.ReadLine()));
            Console.ReadLine();

        }

        



    }
}
