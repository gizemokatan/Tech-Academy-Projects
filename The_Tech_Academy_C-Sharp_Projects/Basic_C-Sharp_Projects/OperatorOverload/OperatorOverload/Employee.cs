using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    public class Employee
    {
        // Create a property called Id
        public int Id { get; set; }

        public static Employee operator== (Employee employee, Employee Id)
        {
            employee.Equals(Id);
            return employee;
        }
        // operator ' == ' required there be the ' != ' operator also defined
        public static Employee operator!= (Employee employee, Employee Id)
        {
            employee.Equals(Id);
            return employee;
        }
    }
}
