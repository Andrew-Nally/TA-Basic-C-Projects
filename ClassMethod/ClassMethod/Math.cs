using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethod
{
    class Math
    {
        public void Multiply(int num1)
        {
            int result = num1 * 9;
            Console.WriteLine("Your number multiplied by 9 equals: " + result);
        }
        public void Addition(int num1)
        {
            int result = num1 + 9;
            Console.WriteLine("Your number plus 9 equals: " + result);
        }
        public void Divide(int num1)
        {
            int result = num1 / 9;
            Console.WriteLine("Your number divided by 9 equals: " + result);
        }
    }
}