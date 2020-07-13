using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello there! Please enter a number: ");
            string userNumber = Console.ReadLine();
            // Log that number to a text file.
            File.WriteAllText(@"C:\Users\marti\Logs\log1.txt", userNumber);

            //Print the text file back to the user.
            string userNumber1 = File.ReadAllText(@"C:\Users\marti\Logs\log1.txt");

            Console.WriteLine("Here is whats in the text file: ");
            Console.WriteLine(userNumber1);
            Console.ReadLine();
        }
        
    }
}
