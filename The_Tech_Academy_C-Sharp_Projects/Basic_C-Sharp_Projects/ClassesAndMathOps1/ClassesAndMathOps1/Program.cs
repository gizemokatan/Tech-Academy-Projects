using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMathOps1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A simple math operation...");

            MathClass1 math102 = new MathClass1();

            int result = math102.addNumber(12);
            int result1 = math102.addNumber(12.99m);
            int result2 = math102.addNumber("26");

            Console.WriteLine("Here is the result of adding 25 to the number 12:");
            Console.WriteLine(result);
            Console.WriteLine("Here is the result of adding 50.5 to the decimal number 12.99 and returning it as an integer:");
            Console.WriteLine(result1);
            Console.WriteLine("Here is the age 26 in 5 years from now:");
            Console.WriteLine(result2 + " ... Time flies ...");
            Console.ReadLine();
        }
        
    }
}
