using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integers_and_Exceptions_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try {

                List<int> numbers = new List<int>() { 7, 14, 49, 42, 56, 63, 72};
                Console.WriteLine("Pick a number to divide each number by: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dividing...");
                Console.ReadLine();
                foreach (float num in numbers)
                {
                    Console.WriteLine(num + " divided by " + userNumber + " is approximately " + num / userNumber);

                    Console.ReadLine();
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch(DivideByZeroException zeroEx)
            {
                Console.WriteLine(zeroEx.Message);
            }
           
            catch( Exception Ex)

            {
                Console.WriteLine(Ex.Message);

            }
            finally
            {
                Console.ReadLine();
            }


        }

    }
}
                      