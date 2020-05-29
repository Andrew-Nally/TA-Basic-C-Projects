using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "Whomever";
            string date = DateTime.Today.ToShortDateString();
            string school = "The Tech Academy";

            string intro = $"Hi {username}. This assignment was done for {school}. Today is {date}.\n";
            Console.WriteLine(intro);

            string title = "Twinkle, Twinkle Little Star \n";
            Console.WriteLine(title.ToUpper());

            //StringBuilder
            StringBuilder sb = new StringBuilder();       
            sb.Append("Twinkle, Twinkle little star,").AppendLine();
            sb.Append("How I wonder what you are!").AppendLine();
            sb.Append("Up above the world so high,").AppendLine();
            sb.Append("Like a diamond in the sky.").AppendLine();
            sb.Append("Twinkle, Twinkle little star!").AppendLine();
            

            string innerString = sb.ToString();
            Console.WriteLine(innerString);
            Console.Read();
        }
    }
}
