using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. What is your name?");
            string userName = Console.ReadLine();


            {
                string userContinue = "y";
                while (userContinue == "y")
                {
                    {
                        Console.WriteLine("Please enter a number between 1-100:");
                        int numberInput = int.Parse(Console.ReadLine());
                        // if number is less than 1 or greater than 100 print Nope! and exit
                        if (numberInput < 1 || numberInput > 100)
                        {
                            Console.WriteLine("Nope!");
                        }
                        // if number is even and less than 25
                        else if (numberInput % 2 == 0 && numberInput < 25)
                        {
                            Console.WriteLine($"{numberInput} Even and less than 25.");
                        }
                        //if number is even and less than or equal to 60
                        else if (numberInput % 2 == 0 && numberInput <= 60)
                        {
                            Console.WriteLine("Even");
                        }
                        //if number is even and greater than 60
                        else if (numberInput % 2 == 0 && numberInput > 60)
                        {
                            Console.WriteLine($"{numberInput} is Even");
                        }
                        // if number is odd and greater than 60
                        else if (numberInput % 2 != 0 && numberInput > 60)
                        {
                            Console.WriteLine($"{numberInput} odd - and greater than 60.");
                        }
                        // if the number is odd
                        else if (numberInput % 2 != 0)
                        {
                            Console.WriteLine($"{numberInput} is Odd.");
                        }
                        userContinue = "";
                        while (userContinue != "y" && userContinue != "n")
                        {
                            Console.WriteLine($"Would you like to continue {userName}? Press 'y' to continue, 'n' to stop.");
                            userContinue = Console.ReadLine().ToLower();
                        }

                    }
                }
            }
        }
    }
}