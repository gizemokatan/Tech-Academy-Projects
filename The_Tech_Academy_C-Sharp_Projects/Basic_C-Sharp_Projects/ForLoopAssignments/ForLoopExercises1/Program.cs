using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
    {
        static void Main(string[] args)
        {

        /************************************************************************************************************************
             * 1. Create a one-dimensional Array of strings. Ask the user to input some text. Create a loop that goes through each
             * string in the Array, adding the user’s text to the string. Then create a loop that prints off each string 
             * in the Array on a separate line.
         ***********************************************************************************************************************/

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


        /***************************************
             * 2.Create an infinite loop.
         ****************************************/

        Console.WriteLine("A broken Buzz Lightyear with his button pressed once...\n");

        for (int i = 0; i >= 0; i++)
        {
            Console.WriteLine("To infinity and beyond!...\n");
        }
        Console.ReadLine();


        /******************************************************
             * 3. Fix the infinite loop so it will execute.
         ******************************************************/

        Console.WriteLine("A fixed Buzz Lightyear with his button pressed once...\n");

        for (int i = 0; i <= 0; i++)
        {
            Console.WriteLine("To infinity and beyond!...\n");
        }
        Console.ReadLine();


        /*******************************************************************************************************
            * 4. Create a loop where the comparison used to determine whether to continue iterating the loop 
            * is a “<” operator.
         *******************************************************************************************************/

        int[] ages = { 18, 19, 29, 31, 26, 22, 20, 23 };

        foreach (int age in ages)
        {
            if (age < 21)
            {
                Console.WriteLine(age + " years old is not old enough to enter the bar.\n");
            }
        }

        Console.ReadLine();


        /*********************************************************************************************************
             * 5. Create a loop where the comparison used to determine whether to continue iterating the loop 
             * is a “<=” operator.
         ********************************************************************************************************/

        Console.WriteLine("Wishing you a very...\n");

        for (int k = 0; k <= 2; k++)
        {
            Console.Write("HAPPY ");
        }
        Console.WriteLine("Birthday!");
        Console.ReadLine();


        /********************************************************************************************************
             * 6. Create a List of strings where each item in the list is unique. Ask the user to select text 
             * to search for in the List. Create a loop that iterates through the list and then displays the 
             * index of the array that contains matching text on the screen.
         ********************************************************************************************************/

        Console.WriteLine("Here is a list of colors:\n \t");

        List<string> colors = new List<string>();
        colors.Add("Red");
        colors.Add("Orange");
        colors.Add("Yellow");
        colors.Add("Green");
        colors.Add("Blue");
        colors.Add("Violet");

        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }

        Console.WriteLine("\nPlease write a color from the list as is, to find out the associated index:");
        string userInput = Console.ReadLine();

        bool colorInList = false;

        for (int i = 0; i < colors.Count; i++)
        {
            if (userInput == colors[i])
            {
                colorInList = true;
                if (colorInList)
                {
                    Console.WriteLine("\nThe color " + userInput + " is at index " + i + " in the list of colors.");

                }
            }

        }

        if (colorInList == false)
        {
            Console.WriteLine("\nThe color " + userInput + " is NOT in the list of colors.");
        }
        Console.ReadLine();



        /**************************************************************************************************
            * 7. Add code to that above loop that tells a user if they put in text that isn’t in the List.
         **************************************************************************************************/

        // Refer to assignment number 6 above


        /**************************************************************************************************
            * 8. Add code to that above loop that stops it from executing once a match has been found.
         **************************************************************************************************/

        // Refer to assignment number 6 above
        // I've added the Boolean value to indicate if a condition is false to display a message in the console to the user
        // if the user put in text that isn't in the list.


        /**************************************************************************************************
            * 9. Create a List of strings that has at least two identical strings in the List. Ask the 
            * user to select text to search for in the List. Create a loop that iterates through the 
            * list and then displays the indices of the array that contain matching text on the screen.
         **************************************************************************************************/

        Console.WriteLine("Look at the list below:\n");

        List<string> fruits = new List<string>();
        fruits.Add("Blueberries");
        fruits.Add("Tangerine");
        fruits.Add("Banana");
        fruits.Add("Kiwi");
        fruits.Add("Blueberries");
        fruits.Add("Blackberries");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine("\nPlease type a fruit to see what index its in:");
        string userTyped = Console.ReadLine();

        bool fruitInList = false;

        for (int f = 0; f < fruits.Count; f++)
        {
            if (userTyped == fruits[f])
            {
                fruitInList = true;
                if (fruitInList)
                {
                    Console.WriteLine("Index: " + f);
                }
            }

        }

        if (!fruitInList)
        {
            Console.WriteLine("\nSorry, no match found based on what you typed.");
        }

        Console.ReadLine();


        /**************************************************************************************************
            * 10. Add code to that above loop that tells a user if they put in text that isn’t in the List.
         **************************************************************************************************/

        // Refer to assignment number 9 above
        // I've added the Boolean value to indicate if a condition is false, to display a message in the console to the user
        // if the user put in text that isn't in the list.

        /**************************************************************************************************
             * 11. Create a List of strings that has at least two identical strings in the List. Create 
             * a foreach loop that evaluates each item in the list, and displays a message showing the 
             * string and whether or not it has already appeared in the list.
         **************************************************************************************************/

        Console.WriteLine("Names List\nHere's a list of names:\n");

        List<string> namesList = new List<string>();

        namesList.Add("Courtney");
        namesList.Add("Karen");
        namesList.Add("Chiquita");
        namesList.Add("Courtney");

        List<string> namesAppearedList = new List<string>();


        foreach (string name in namesList)
        {
            // If we see a name already on namesAppearedList, print it with a message.
            // Look at namesAppeared list, if name from namesList is not on the namesAppearedList, print it
            // then add it to namesAppeared list.

            if (namesAppearedList.Contains(name))
            {
                Console.WriteLine(name + " is in the list more than once.");
            }
            else
            {
                Console.WriteLine(name);
                namesAppearedList.Add(name);
            }
          
        }

        Console.ReadLine();























    }
}