using System;
using System.Collections.Generic;

    class Program
    {
    static void Main()
    {

        Console.WriteLine("Welcome to MultiSpeak Language Learning App");
        string[] helloArray = { "Hello", "Hola", "Halo", "Bonjour", "Kon'nichiwa" };

        int[] speakingPointsArray = { 10, 20, 30, 40, 50 };

        List<string> languageList = new List<string>();
        languageList.Add("English");
        languageList.Add("Spanish");
        languageList.Add("Bahasa Indonesia");
        languageList.Add("French");
        languageList.Add("Japanese");

        bool continueProgram;

        do
        {
            Console.WriteLine("Please enter a number between 0 and 4, including those numbers:");
            string userNum = Console.ReadLine();
            int selectedIndex = Convert.ToInt32(userNum);
            // selectedIndex has to be greater than or equal to 0 and also less than or equal to 4
            bool index = selectedIndex >= 0 && selectedIndex <= 4;

            if (index)
            {
                Console.WriteLine("Word selected: " + helloArray[selectedIndex]);
                Console.WriteLine("Language of Origin: " + languageList[selectedIndex]);
                Console.WriteLine("Points earned for learning this word: " + speakingPointsArray[selectedIndex]);
                Console.ReadLine();
                continueProgram = false;
            }
            else
            {
                Console.WriteLine("Sorry, that index doesn't exist.");
                Console.ReadLine();
                continueProgram = true;
            }
        }
        while (continueProgram);
   
    }

    }

