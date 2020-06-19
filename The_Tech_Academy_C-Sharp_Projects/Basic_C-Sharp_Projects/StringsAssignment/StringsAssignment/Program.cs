using System;
using System.Text;

namespace StringsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Courtney";
            string favColor = "green";
            string hobby = "cooking and baking";

            Console.WriteLine(name + " enjoys " + hobby + " and her favorite color is " + favColor + ".");
            Console.ReadLine();

            Console.WriteLine(name.ToUpper());
            Console.ReadLine();

            StringBuilder storyTime = new StringBuilder();
          
            storyTime.Append("Michelle Obama said it well that, \n \t \"You may not always have a comfortable life");
            storyTime.Append("\n \t and you will not always be able to solve all of the world's problems at once");
            storyTime.Append("\n \t but don't ever underestimate the impotance you can have...\"");

            Console.WriteLine(storyTime);
            Console.ReadLine();
        }
    }
}
