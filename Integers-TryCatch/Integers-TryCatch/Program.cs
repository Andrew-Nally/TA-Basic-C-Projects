using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integers_TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
        //1. Create a list of integers. Ask the user for a number to divide each number in the list by. Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
        input:
            try
            {
                var numList = new List<int>() { 5,10,785,20,9,54,65,334,78,65,33,88,43,34,234,34,345,345,54,45,34,35,65,45,645,54,645,56,23,76 };
                Console.WriteLine("Please enter any number 1-9: ");
                int userNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Division results:");
                foreach (int num in numList)
                {
                    int result = num / userNum;
                    Console.Write(result);
                    Console.Write(", ");
                }
                Console.Read();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number next time.");
                goto input;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please do not enter 0 next time");
                goto input;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto input;
            }
            finally
            {
                Console.WriteLine("The program has emerged from the try/catch block and continued on with program execution.Please press Enter.");
                Console.ReadLine();
            }


        }
    }
}
