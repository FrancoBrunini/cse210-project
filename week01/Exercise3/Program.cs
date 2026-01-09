using System;
using System.Formats.Asn1;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        string answer = "yes";

        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            System.Console.WriteLine("Try to find the magic number");
            int guess = 0;
            int attempts = 0;
            while (guess != number)
            {
                System.Console.WriteLine("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                if (guess > number)
                {
                    System.Console.WriteLine("Try lower");
                }
                else if (guess < number)
                {
                    System.Console.WriteLine("Try higher");
                }
                attempts += 1;
            }

            System.Console.WriteLine("You guessed the number!");
            System.Console.WriteLine($"Your attempts: {attempts}");
            System.Console.Write("Do you want to continue? ");
            answer = Console.ReadLine();
        } while (answer == "yes");
            System.Console.WriteLine("Thanks for playing!");

    }
}
    