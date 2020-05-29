using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //While Loop

            int i = 0;
            int Countdown = 5;
            while ( Countdown < 20)
            {
                Console.WriteLine(i * 2);
                i++; Countdown++;
               Console.ReadLine();


                //DO WHile Loop

                int x = 100;

                do
                {
                    Console.WriteLine(x - 1);
                    x--;

                } while (x > 0);

                Console.ReadLine();




            }
        }
    }
}
