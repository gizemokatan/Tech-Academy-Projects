using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use polymorphism to create an object of type IQuittable
            IQuittable employee = new Employee()
            {
                FirstName = "John ",
                LastName = "Doe"
            };
            Console.WriteLine("Using the employee object of type IQuittable...");
            // Call the Quit method
            employee.Quit();
        }
    }
}
