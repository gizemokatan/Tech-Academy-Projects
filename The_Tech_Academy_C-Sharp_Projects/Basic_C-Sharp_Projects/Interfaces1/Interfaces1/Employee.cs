using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    // Create a class called Employee and have it inherit from the Person class
    public class Employee : Person, IQuittable
    {
        // Implement the SayName() method
        public override void SayName()
        {
            base.SayName();
        }
        // The Employee class will inherit the interface and implement the Quit() method
        public void Quit()
        {
            Console.WriteLine("...We have just used the Quit method implemented by the Employee class!");
            Console.ReadLine();
        }
    }
}
