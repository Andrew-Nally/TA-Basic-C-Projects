using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number, any number!");
            int xFifty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(xFifty * 50);
            Console.ReadLine();

            Console.WriteLine("Pick a number, any number!");
            int plusNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(plusNum + 25);
            Console.ReadLine();

            Console.WriteLine("Pick a Number, any number!");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            bool moreThan = userNumber > 50;
            Console.WriteLine(moreThan);
            Console.ReadLine();

            Console.WriteLine("Pick a number, any number!");
            double decNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(decNumber / 12.5);
            Console.ReadLine();

            Console.WriteLine("Pick a number, any number!");
            double divNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(divNum % 7);
            Console.ReadLine();
        }
    }
}
