using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            RunProgram();

            int userAge = 0;
            int birthYear;

            void RunProgram()
            {
                Console.WriteLine("Please enter your age you'll be this year:");
                try
                {
                    userAge = Convert.ToInt32(Console.ReadLine());

                    if (userAge <= 0)
                    {
                        Console.WriteLine("An error has occurred. No zero or negative numbers.");
                        RunProgram();
                    }
                    else
                    {
                        birthYear = DateTime.Now.Year - userAge;
                        Console.WriteLine("If you already had your birthday this year, then you were born in {0}.", birthYear);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    RunProgram();
                }

            }

            Console.ReadLine();
            

            //int userAge = 0;
            //int birthYear;

            //bool isAsking = true;

            //while (isAsking)
            //{
            //    Console.WriteLine("Please enter your age you'll be this year:");
            //    try
            //    {
            //        userAge = Convert.ToInt32(Console.ReadLine());

            //        if (userAge > 0)
            //        {
            //            birthYear = DateTime.Now.Year - userAge;
            //            Console.WriteLine("If you already had your birthday this year, then you were born in {0}.", birthYear);
            //            isAsking = false;
            //        }
            //        else
            //        {
            //            Console.WriteLine("No zero or negative numbers.");
            //        }

            //    }
            //    catch(Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
                
            //}
            //Console.ReadLine();
        }
    }
}
