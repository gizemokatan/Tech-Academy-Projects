using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMathOps4
{
    // Declare a class to be static
    static class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathClass4 math105 = new MathClass4();

            try
            {
                Console.WriteLine("Please enter a number:");
                int userInput = Convert.ToInt32(Console.ReadLine());
                int numResult;

                // Call the method on the userInput
                math105.DivideByTwo(userInput, out numResult);

                Console.WriteLine("The result of {0} divided by 2 = {1}", userInput, numResult);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("ERROR: Please enter a whole number.");
                Console.ReadLine();
            }
        }
    }
}
