using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
        
            Console.WriteLine("Please enter your hourly rate: ");
            string hourlyRate1 = Console.ReadLine();
            double hourlyRateNum1 = Convert.ToDouble(hourlyRate1);
            Console.WriteLine("Hourly rate: $" + hourlyRateNum1);

            Console.WriteLine("Please enter the number of hours you worked per week: ");
            string weeklyHours1 = Console.ReadLine();
            double weeklyHoursNum1 = Convert.ToDouble(weeklyHours1);
            Console.WriteLine("Number of hours worked per week: " + weeklyHoursNum1);

            Console.WriteLine("Person 2");

            Console.WriteLine("Please enter your hourly rate: ");
            string hourlyRate2 = Console.ReadLine();
            double hourlyRateNum2 = Convert.ToDouble(hourlyRate2);
            Console.WriteLine("Hourly rate: $" + hourlyRateNum2);

            Console.WriteLine("Please enter the number of hours you worked per week: ");
            string weeklyHours2 = Console.ReadLine();
            double weeklyHoursNum2 = Convert.ToDouble(weeklyHours2);
            Console.WriteLine("Number of hours worked per week: " + weeklyHoursNum2);

            Console.WriteLine("Annual salary of Person 1: ");
            double weeklySalary1 = hourlyRateNum1 * weeklyHoursNum1;
            double annualSalary1 = weeklySalary1 * 52;
            Console.WriteLine(annualSalary1);

            Console.WriteLine("Annual salary of Person 1: ");
            double weeklySalary2 = hourlyRateNum2 * weeklyHoursNum2;
            double annualSalary2 = weeklySalary2 * 52;
            Console.WriteLine(annualSalary2);

            Console.WriteLine("Does Person 1 make more money than Person 2?: ");
            bool Person1MakeMore = annualSalary1 > annualSalary2;
            Console.WriteLine(Person1MakeMore);
            Console.ReadLine();
            
        }
    }
}
