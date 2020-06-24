using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance2
{
    // Create a class called Employee and have it inherit from the Person class
    public class Employee : Person
    {
        // Implement the SayName() method
        public override void SayName()
        {
            base.SayName();
        }
    }
}
