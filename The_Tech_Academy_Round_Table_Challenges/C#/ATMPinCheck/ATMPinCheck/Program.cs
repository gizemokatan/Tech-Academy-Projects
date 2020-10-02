using System;

namespace ATMPinCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, please enter a 4 or 6 digit pin number: ");
            string userPin = Console.ReadLine();
            Program program = new Program();
            program.MyFunction(userPin);
        }

        public void MyFunction(string userPin)
        {
            bool pinValid = true;
            int pinLen = userPin.Length;

            if (userPin == "")
            {
                pinValid = false;
            }
            else if (userPin != "")
            {
                for (int i = 0; i < userPin.Length; i++)
                {
                    if (pinLen == 4 || pinLen == 6)
                    {
                        if (userPin[i] >= 'a' && userPin[i] <= 'z')
                        {
                            pinValid = false;
                        }
                    }
                    else if (pinLen != 4 || pinLen != 6)
                    {
                        pinValid = false;
                    }
                    else
                    {
                        pinValid = true;
                    }
                }
            }
            if (pinValid == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
