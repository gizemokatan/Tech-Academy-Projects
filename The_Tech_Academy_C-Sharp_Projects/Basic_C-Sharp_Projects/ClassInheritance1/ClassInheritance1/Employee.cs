using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance1
{
    // Create a class called Employee and have it inherit from the Person class 
    // Give the Employee class a property called Id of data type int
    public class Employee : Person
    {
        public int Id { get; set; }
    }
}
