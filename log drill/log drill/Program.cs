using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number. Any number");
            string numChoice = Console.ReadLine();

            File.WriteAllText(@"C:\Users\Andre\Desktop\Tech-Academy-Basic-C-Projects\test.txt", numChoice);
            string text = File.ReadAllText(@"C:\Users\Andre\Desktop\Tech-Academy-Basic-C-Projects\test.txt");
            Console.WriteLine("Contents of test.txt = {0}", text);
            Console.ReadLine();
        }
    }
}
