using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance1
{
    // Create a class called Person
    public class Person
    {
        // Assign properties of type string 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Create a void method called SayName() that takes no parameters 
        // and writes the person's full name to the console
        public void SayName()
        {
            string fullname = FirstName + LastName;
            Console.WriteLine("Name: " + fullname);
            Console.ReadLine();
        }
    }
}
