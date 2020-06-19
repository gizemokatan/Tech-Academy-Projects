using System;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;

namespace ComparisonDoWhileStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the $25 dollar Store");
            Console.WriteLine("How much money do you have?:");
            double wallet = Convert.ToDouble(Console.ReadLine());
            bool continueProgram;
            int itemsBought = 0;
            const int itemCost = 25;
            bool continueShopping = true;

            do
            {
                if (wallet >= 25)
                {
                    continueProgram = true;
                    Console.WriteLine("Would you like to buy an item? (Please enter 'true' if yes or 'false; if no.)");
                    bool buyItem = Convert.ToBoolean(Console.ReadLine());

                    if (buyItem == true)
                    {
                        itemsBought += 1;

                        // Boolean comparison using a while statement
                        bool countMoney = true;
                        int counter = 0;
                        while (countMoney) 
                        {
                            
                            wallet -= 1;
                            counter += 1;
                            if (counter == itemCost)
                            {
                                countMoney = false;
                            }
                            /* This line will write the amount of money in the wallet that the user input first, 
                             then it shows the wallet amount at a specific time.*/
                            Console.WriteLine("Wallet: " + wallet);
                        }

                    }
                    else
                    {
                        continueShopping = false;
                        continueProgram = false;

                    }
                }
                // if you don't have enough money then continueProgram becomes false
                else
                {
                    continueProgram = false;
                }
            }

            while (continueProgram);


            if (itemsBought >= 1)
            {
                Console.WriteLine("Thank you for coming to the 25 dollar Store.");
                Console.WriteLine("Today you bought " + itemsBought + " item(s)");
                Console.WriteLine("Your remaining balance in your wallet is: $" + wallet);
            }
            // Here, the user didn't decide to stop shopping, because the user didn't even start shopping.
            // because continueShopping is true by default.
            else if (continueProgram == false && continueShopping == true)
            {
                Console.WriteLine("Sorry, try the 99 cent Store.");
            }
            // The user decided they didnt want to continueShopping
            else if (continueProgram == false && continueShopping == false)
            {
                Console.WriteLine("Thank you for coming to the 25 dollar Store.");
                Console.WriteLine("Today you bought " + itemsBought + " item(s)");
                Console.WriteLine("Your remaining balance in your wallet is: $" + wallet);
            }
            Console.ReadLine();
        }
            
    }
}