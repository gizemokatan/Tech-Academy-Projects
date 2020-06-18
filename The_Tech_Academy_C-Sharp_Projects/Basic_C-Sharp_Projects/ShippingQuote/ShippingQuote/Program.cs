using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //string packageWeight1 = packageWeight > 50 ? "Package too heavy to be shipped via Package Express. Have a good day." : "Okay. Thank you.";
            //Console.WriteLine(packageWeight1);

        

            //string DimensionsTotal = packageWidth > 50 && packageHeight > 50 && packageLength > 50 ? "Package too big to be shipped via Package Express." : "Okay. Thank you.";
            //double Dimensions = (packageWidth * packageHeight * packageLength * packageWeight) / 100;
         
            //decimal Quote = Convert.ToDecimal(Dimensions); 
            //Console.WriteLine("Your estimated total for shipping this package is: $" + Quote);
            
            //Console.WriteLine("Thank you.");
            //Console.ReadLine();

        }
    }
}
