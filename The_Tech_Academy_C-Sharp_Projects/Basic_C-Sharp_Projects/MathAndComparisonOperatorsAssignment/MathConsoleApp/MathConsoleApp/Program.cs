using System;

namespace MathConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREATE A CONSOLE APPLICATION THAT DOES THE FOLLOWING:

            //1. Takes an input from the user, multiplies it by 50, then prints the result to the console. (Note: make sure your code can take inputs larger than 10,000,000).

            Console.WriteLine("Enter a number to be multiplied by 50:");
            string userNum = Console.ReadLine();
            int userNumNew = Convert.ToInt32(userNum);
            int total = userNumNew * 50;
            Console.WriteLine(userNumNew + " multiplied by 50 is: " + total);
            Console.ReadLine();

            //2. Takes an input from the user, adds 25 to it, then prints the result to the console.

            Console.WriteLine("Enter a number that will be added to 25:");
            string userNum1 = Console.ReadLine();
            int userNumNew1 = Convert.ToInt32(userNum1);
            int total1 = userNumNew1 + 25;
            Console.WriteLine(userNumNew1 + " added to 25 is: " + total1);
            Console.ReadLine();

            //3. Takes an input from the user, divides it by 12.5, then prints the result to the console.

            Console.WriteLine("Enter a number that will be divided by 12.5: ");
            string userNum2 = Console.ReadLine();
            double userNumNew2 = Convert.ToDouble(userNum2);
            double total2 = userNumNew2 / 12.5;
            Console.WriteLine(userNumNew2 + " divided by 12.5 is: " + total2);
            Console.ReadLine();

            //4. Takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console.

            Console.WriteLine("Enter a number to check if it is greater than 50: ");
            string userNum3 = Console.ReadLine();
            int userNumNew3 = Convert.ToInt32(userNum3);
            bool isGreaterThan = userNumNew3 > 50;
            Console.WriteLine("Is " + userNumNew3 + " greater than 50: " + isGreaterThan);
            Console.ReadLine();

            //5. Takes an input from the user, divides it by 7, then prints the remainder to the console (tip: think % operator).

            Console.WriteLine("Enter a number that will be divided by 7 and get the remainder of that division: ");
            string userNum4 = Console.ReadLine();
            int userNumNew4 = Convert.ToInt32(userNum4);
            int remainder = userNumNew4 % 7;
            Console.WriteLine(userNumNew4 + " divided by 7, gives a remainder of " + remainder);
            Console.ReadLine();

        }
    }
}
