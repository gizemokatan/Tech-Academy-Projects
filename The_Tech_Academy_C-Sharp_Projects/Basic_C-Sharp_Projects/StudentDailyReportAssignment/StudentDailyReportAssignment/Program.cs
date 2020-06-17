using System;

namespace StudentDailyReportAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report:");
      
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNum = Console.ReadLine();
            int pageNumber = Convert.ToInt32(pageNum);

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            string needHelp = Console.ReadLine();
            bool needAnyHelp = Convert.ToBoolean(needHelp);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string posExperience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudying = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(hoursStudying);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
