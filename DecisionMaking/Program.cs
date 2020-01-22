using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
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

                Console.WriteLine($"Your number was {Number1}");
            }
        }
    }
}
     
