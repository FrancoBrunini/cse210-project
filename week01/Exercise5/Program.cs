using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();

        int squared = SquareNumber(number);
        DisplayResult(name, squared);
        static void DisplayWelcome()
        {
            System.Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            System.Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }
        static int PromptUserNumber()
        {
            System.Console.Write("Please enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        }
        static int SquareNumber(int number)
        {
            return number * number;
        }
            static void DisplayResult(string name, int squared)
        {
            Console.WriteLine($"Brother {name}, the square of your number is {squared}.");
        }
    }

    }
