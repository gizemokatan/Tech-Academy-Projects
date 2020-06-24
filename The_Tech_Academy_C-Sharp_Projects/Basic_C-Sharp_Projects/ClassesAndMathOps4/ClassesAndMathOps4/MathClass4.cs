using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMathOps4
{
    // Create a class
    class MathClass4
    {
        // Create a void method that outputs an integer and divides the data passed to it by 2
        public void DivideByTwo(int num)
        {
            int numResult = num / 2;
            Console.WriteLine(numResult);

        }

        //  Create a method with output parameters and overload a method
        public void DivideByTwo(int num, out int numResult)
        {
            numResult = num / 2;
        }
    }
}
