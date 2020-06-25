using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    // Create an abstract class called Person with two properties
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Create a method to be implemented in Employee Class
        public virtual void SayName()
        {
            string fullname = FirstName + LastName;
            Console.WriteLine("Name: " + fullname);
            Console.ReadLine();
        }
    }
}
