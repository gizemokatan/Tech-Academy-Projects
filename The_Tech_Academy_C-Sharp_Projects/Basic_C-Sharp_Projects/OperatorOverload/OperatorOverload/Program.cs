using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate two employee objects 
            Employee john = new Employee();
            Employee cathy = new Employee();
            john.Id = 222;
            cathy.Id = 333;

            // Compare Id properties of employee objects 
            Console.WriteLine("Do employees, John and Cathy, have the same Id...?");
            bool employeesEqual = john.Id == cathy.Id;

            Console.WriteLine(employeesEqual);
            Console.ReadLine();
        }
    }
}
