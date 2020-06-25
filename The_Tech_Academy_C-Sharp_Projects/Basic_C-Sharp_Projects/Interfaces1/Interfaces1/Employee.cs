using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    // Create a class called Employee and have it inherit from the Interface
    public class Employee : IQuittable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Implement the Quit() method
        public void Quit()
        {
            Console.WriteLine("...We have just used the Quit method implemented by the Employee class!");
            Console.ReadLine();
        }
    }
}
