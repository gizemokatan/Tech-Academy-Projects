using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMathOps3
{
    class MathClass3
    {
        // Create a class and create a void method that takes two integers as parameters
        public void divideNumbers(int num, out int numResult)
        {
            // Have the method do a math operation on the first integer and display the second integer to the screen
            num /= 2;
            numResult = 6;
            Console.WriteLine("The second value is: {0} ", numResult);
        }
    }
}
