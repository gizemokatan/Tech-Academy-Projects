using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of at least 10 employees. Each employee should have a first and last name, as well as an Id. 
            // At least two employees should have the first name "Joe".
            Employee employee1 = new Employee()
            {
                FirstName = "Courtney",
                LastName = "Dart",
                Id = 1

            };
            Employee employee2 = new Employee()
            {
                FirstName = "Becca",
                LastName = "Belz",
                Id = 3

            };
            Employee employee3 = new Employee()
            {
                FirstName = "Lance",
                LastName = "O'Hare",
                Id = 5

            };
            Employee employee4 = new Employee()
            {
                FirstName = "Nelly",
                LastName = "Frank",
                Id = 7

            };
            Employee employee5 = new Employee()
            {
                FirstName = "Abu",
                LastName = "Miraz",
                Id = 9

            };
            Employee employee6 = new Employee()
            {
                FirstName = "Paulina",
                LastName = "Lou",
                Id = 11

            };
            Employee employee7 = new Employee()
            {
                FirstName = "Joe",
                LastName = "Doe",
                Id = 13

            };
            Employee employee8 = new Employee()
            {
                FirstName = "Kristen",
                LastName = "Rally",
                Id = 15

            };
            Employee employee9 = new Employee()
            {
                FirstName = "Joe",
                LastName = "Martinez",
                Id = 17

            };
            Employee employee10 = new Employee()
            {
                FirstName = "Zavior",
                LastName = "Joseph",
                Id = 19

            };

            List<Employee> allEmployeesList = new List<Employee>()
            {
                employee1,
                employee2,
                employee3,
                employee4,
                employee5,
                employee6,
                employee7,
                employee8,
                employee9,
                employee10
            };

            // Using a foreach loop, create a new list of all employees with the first name "Joe".
            List<Employee> joesList = new List<Employee>();

            foreach (Employee employee in allEmployeesList)
            {
                if (employee.FirstName == "Joe")
                {
                    joesList.Add(employee);
                }
            }

            foreach (Employee employee in joesList)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id);
            }

            // Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> idGreaterThan5 = new List<Employee>();

            idGreaterThan5 = allEmployeesList.Where(x => x.Id > 5).ToList();

            foreach (Employee employee in idGreaterThan5)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id);
            }
            Console.ReadLine();

        }
    }
}
