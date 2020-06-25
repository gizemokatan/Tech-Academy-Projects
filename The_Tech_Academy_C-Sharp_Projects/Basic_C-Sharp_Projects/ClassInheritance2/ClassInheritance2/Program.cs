using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object
            Employee employee = new Employee
            {
                FirstName = "Sample ",
                LastName = "Student"
            };
            Console.WriteLine("This is an example of a virtual method being called...");
            // Call the SayName() method on the Employee object
            employee.SayName();

        }
    }
}
