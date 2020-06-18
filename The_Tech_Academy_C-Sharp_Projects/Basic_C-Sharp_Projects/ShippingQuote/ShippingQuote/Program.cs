using System;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            double packageWeight = Convert.ToDouble(Console.ReadLine());

            if (packageWeight <= 50)
            {
                Console.WriteLine("Please enter the package width:");
                double packageWidth = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                double packageHeight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                double packageLength = Convert.ToDouble(Console.ReadLine());

                double Dimensions = packageWidth + packageHeight + packageLength;

                if (Dimensions < 50)
                {
                    double DimnesionsTotal = (Dimensions * packageWeight) / 100; 
                    decimal Quote = Convert.ToDecimal(DimnesionsTotal);
                    Console.WriteLine("Your estimated total for shipping this package is: $" + Quote);
                    Console.WriteLine("Thank you.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
        }
    }
}
