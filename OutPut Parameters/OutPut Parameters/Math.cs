using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutPut_Parameters
{
    class Math
        {
            public void mathApp(int num1) //create a void method
            {
                int results1 = num1 / 2;
                Console.WriteLine(num1 + " / 2 = " + results1);
            }

            public static void mathApp(int num2, int num3, out int times, out int div) //overload method with output parameters
            {
                times = num2 * num3;
                div = (num2 / num3);
            }

        }
    }
