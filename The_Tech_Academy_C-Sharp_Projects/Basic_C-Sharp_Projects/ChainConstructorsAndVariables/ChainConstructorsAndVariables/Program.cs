using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainConstructorsAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TechCo Co\nYou're a new employee");
            Console.WriteLine("We need to collect some information from you.");
            Console.WriteLine("Please input your first name:");
            var firstName = Console.ReadLine();
            Console.WriteLine("Do you have a middle name? Please input 'true' or 'false'.");
            var hasMiddleName = Convert.ToBoolean(Console.ReadLine().ToLower());
            string middleName = null;
            if (hasMiddleName)
            {
                Console.WriteLine("Please input your middle name:");
                middleName = Console.ReadLine();
            }
            Console.WriteLine("Please input your last name:");
            var lastName = Console.ReadLine();
            Console.WriteLine("Please input your desired employee id number:");
            var idNumber = Convert.ToInt32(Console.ReadLine());

            Employee employee = null;
            if (hasMiddleName)
            {
                employee = new Employee(firstName, middleName, lastName, idNumber);
                Console.WriteLine("Employee info:\n");
                Console.WriteLine("{0}, {1}, {2}, {3}", employee.Firstname, employee.MiddleName, employee.LastName, employee.Id);
                Console.WriteLine("Successful! Your info has been added to our employee database.");
            }
            else
            {
                employee = new Employee(firstName, lastName, idNumber);
                Console.WriteLine("Employee info:\n");
                Console.WriteLine("{0}, {1}, {2}", employee.Firstname, employee.LastName, employee.Id);
                Console.WriteLine("Successful! Your info has been added to our employee database.");

            }
            Console.ReadLine();

        }
    }
}
