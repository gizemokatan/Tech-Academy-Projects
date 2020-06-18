using System;

namespace CarInsuranceApprovalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age? (Please enter a number):");
            string UserAge = Console.ReadLine();
            int UserAgeNum = Convert.ToInt32(UserAge);

            Console.WriteLine("Have you ever had a DUI? (Please enter 'true' for yes or 'false' for no):");
            string HadDUI = Console.ReadLine();
            bool HadDUITrue = Convert.ToBoolean(HadDUI);

            Console.WriteLine("How many speeding tickets have you had? If none, enter 0. (Please enter the number of speeding tickets as a number):");
            string HadSpeedingTicket = Console.ReadLine();
            int HadSpeedingTicketTrue = Convert.ToInt32(HadSpeedingTicket);

            Console.WriteLine("Applicant qualifies for car insurance?: ");
            bool Qualifies = UserAgeNum > 15 && HadDUITrue == false && HadSpeedingTicketTrue <= 3;
            Console.WriteLine(Qualifies);
            Console.ReadLine();

        }
    }
}
