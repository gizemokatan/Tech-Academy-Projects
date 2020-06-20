using System;
using System.Collections.Generic;
using System.Linq;

class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Let us know your favorite ice cream flavor from this list.\n");
        string[] iceCreamFlavors = { "Chocolate", "Vanilla", "Strawberry", "Mint Chip", "Chunky Monkey" };

        foreach (string flavor in iceCreamFlavors)
        {
            Console.WriteLine(flavor);
        }
       
        Console.WriteLine("\nPlease type one of the flavors from the list above:\n");
  
        string userFlavor = Console.ReadLine();
        Console.WriteLine();

        for (int i = 0; i < iceCreamFlavors.Length; i++)
        {
            //if the flavor equalls what the user input, then concatenate at that index
            if (userFlavor == iceCreamFlavors[i]) 
            {
                iceCreamFlavors[i] = iceCreamFlavors[i] + " is your favorite flavor!";
            }
        }

        foreach (string flavor in iceCreamFlavors)
        {
            Console.WriteLine(flavor);
        }
        Console.ReadLine();

    }
    }