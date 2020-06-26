using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsList
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> courtney = new Employee<string>();
            List<string> ThingsList = new List<string>()
            {
                "car",
                "pen",
                "paper"
            };
            courtney.Things = ThingsList;
            
            Employee<int> karen = new Employee<int>();
            List<int> ThingsList1 = new List<int>()
            {
                12,
                24,
                48
            };
            karen.Things = ThingsList1;

            Console.WriteLine("Here we are printing things in a list of type string and of type int...");
            foreach (string thing in courtney.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in karen.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
