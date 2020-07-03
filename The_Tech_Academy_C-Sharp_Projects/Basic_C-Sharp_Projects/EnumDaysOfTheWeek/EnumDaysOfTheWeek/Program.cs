using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDaysOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;
            while (continueProgram)
            {
                try
                {
                    Console.WriteLine("Please enter the day of the week:");
                    string weekday = FirstCharToUpper(Console.ReadLine());

                    // Assign the value to a variable of that enum data type
                    object result = Enum.Parse(typeof(DaysOfTheWeek), weekday);

                    Console.WriteLine(result);
                    continueProgram = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong. Please enter an actual day of the week.");
                }
            }
            Console.ReadLine();

        }
        // The method takes in a string parameter 
        // This method is static and therefore the class doesnt need to be instanciated
        public static string FirstCharToUpper(string s)
        {
            // Check for empty string.  
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.  
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
