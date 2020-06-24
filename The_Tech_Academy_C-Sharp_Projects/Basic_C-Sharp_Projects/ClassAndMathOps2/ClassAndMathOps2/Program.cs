using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMathOps2
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass2 math103 = new MathClass2();

            int result;

            Console.WriteLine("Please enter a number:");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a second number, but please note, you don't have to enter anything:");
            string secondEntered = Console.ReadLine();
            if (string.IsNullOrEmpty(secondEntered))
            {
                result = math103.multiplyNumbers(userNum);
            }
            else
            {
                result = math103.multiplyNumbers(userNum, Convert.ToInt32(secondEntered));
            }
     
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
