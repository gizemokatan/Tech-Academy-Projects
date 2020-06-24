using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do some basic Math...\n");
            Console.WriteLine("Please enter a number:\n");
            Console.WriteLine("1. Your number will be added to 10");
            Console.WriteLine("1. Your number will be subtracted by 10");
            Console.WriteLine("1. Your number will be multiplied by 10\n");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // subtractNumbers is not static, therefore we can create multiple instanciations of MathClass class,
            // whereas addNumbers is static and an object doesn't need to be instanciated for it to be used from MathClass.
            MathClass math101 = new MathClass();

            int addNumbersResult = MathClass.addNumbers(userNumber);
            int subtractNumbersResult = math101.subtractNumbers(userNumber);
            int multiplyNumbersResult = math101.multiplyNumbers(userNumber);

            Console.WriteLine(userNumber + " + 10 = " + addNumbersResult);
            Console.WriteLine(userNumber + " - 10 = " + subtractNumbersResult);
            Console.WriteLine(userNumber + " * 10 = " + multiplyNumbersResult);
            Console.ReadLine();


        }
    }
}
