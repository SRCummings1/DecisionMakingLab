using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            string userContinue = "y";
            while (userContinue == "y")

            {
                int Number1;

                Console.WriteLine("Please enter a number between 1-100:");
                Number1 = int.Parse(Console.ReadLine());
                {
                    if
                           (Number1 % 2 != 0)
                    {
                        Console.WriteLine("Your number is Odd.");
                    }
                    else if
                            (Number1 % 2 == 0 && Number1 > 25)
                    {
                        Console.WriteLine("Your number is even and less than 25.");
                    }

                    else if
                        (Number1 % 2 == 0 && Number1 > 60)
                    {
                        Console.WriteLine("Your number is even.");
                    }
                    else if
                       (Number1 % 2 == 0 && Number1 < 60)
                    {
                        Console.WriteLine("Your number is even.");
                    }
                    else if
                    (Number1 % 2 != 0 && Number1 < 60)
                    {
                        Console.WriteLine("Your number is odd.");
                    }

                    else if 
                    (Number1 > 1 || Number1 < 100)
                    {
                        Console.WriteLine("Nope!");
                    }
                    Console.WriteLine($"Your number was {Number1}");

                    userContinue = "";
                    while (userContinue != "y" && userContinue != "n")
                    {
                        Console.WriteLine("Continue? Press 'y' to continue, 'n' to stop.");
                        userContinue = Console.ReadLine().ToLower();
                    }
                }
            }
        }
    }
}     
