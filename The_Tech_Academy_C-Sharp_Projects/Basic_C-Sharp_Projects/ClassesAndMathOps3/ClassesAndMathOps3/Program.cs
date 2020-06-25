using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMathOps3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathClass3 math104 = new MathClass3();

            // Call the method, passing in two numbers, specifying the parameters by name
            // num will be divided by 2 behind the scenes, and numResult will be displayed on the console
            math104.divideNumbers(num: 10, numResult: out int numResult);

            Console.ReadLine();
        }
    }
}
