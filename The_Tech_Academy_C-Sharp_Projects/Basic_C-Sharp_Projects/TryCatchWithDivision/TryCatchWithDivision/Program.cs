using System;
using System.Collections.Generic;

namespace TryCatchWithDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is a list of numbers:\n");

            List<int> numbersList = new List<int>();
            numbersList.Add(500);
            numbersList.Add(10);
            numbersList.Add(25);
            numbersList.Add(50);
            numbersList.Add(4);

            foreach (int number in numbersList)
            {
                Console.WriteLine(number);
            }

            try
            {
                Console.WriteLine("\nPlease type a number");
                Console.WriteLine("Then each number in the list of numbers will be divided by your number and the result will be displayed:\n");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                foreach (int number in numbersList)
                {
                    int result = number / userNumber;
                    Console.WriteLine(result);

                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't type in zero.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("Thank you");
            Console.ReadLine();
        }
    }
}
