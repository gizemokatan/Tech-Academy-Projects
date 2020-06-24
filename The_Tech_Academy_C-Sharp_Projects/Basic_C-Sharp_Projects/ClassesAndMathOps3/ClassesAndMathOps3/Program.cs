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
            MathClass3 math104 = new MathClass3();

            int valueOne = 10;
            int ValueTwo = 21;

            // valueOne will be divided by 2 behind the scenes, and valueTwo will be displayed on the console.
            math104.divideNumbers(num: valueOne, num1: ValueTwo);

            Console.WriteLine("The End.");
            Console.ReadLine();
        }
    }
}
