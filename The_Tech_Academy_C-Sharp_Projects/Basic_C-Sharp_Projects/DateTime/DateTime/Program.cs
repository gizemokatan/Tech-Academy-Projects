using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    static void Main()
    {
        Console.WriteLine("The current date and time is:");
        DateTime currentDateTime = DateTime.Now;
        Console.WriteLine(currentDateTime);

        Console.WriteLine("Please enter a number:\nWe will then check the time it will be 'x' number of hours from now. ");
        int userNumber = Convert.ToInt32(Console.ReadLine());
        TimeSpan numberHours = new TimeSpan(userNumber, 0, 0);

        DateTime timeInXHours = currentDateTime + numberHours;
        Console.WriteLine(timeInXHours);
        Console.ReadLine();
    }
}
