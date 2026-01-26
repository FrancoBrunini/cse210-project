using System;
using System.Collections.Generic;
// Exceeding requirements:
// Added a difficulty selection (easy, medium, hard) that controls
// how many words are hidden each time the user presses Enter.
class Program
{
    static void Main()
    {
        int count = 0;
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        Console.WriteLine("Which difficulty you want? Easy-Medium-Hard");
        string difficulty = Console.ReadLine();
        difficulty = difficulty.ToLower();
        while (true)
        {
            if (difficulty == "easy")
            {
                count = 1;
                break;
            }
            else if (difficulty == "medium")
            {
                count = 2;
                break;
            }
            else if (difficulty == "hard")
            {
                count = 3;
                break;
            }
            else
            {
                System.Console.WriteLine("Put a valid option.");
                Console.WriteLine("Which difficulty you want? Easy-Medium-Hard");
                difficulty = Console.ReadLine();
                difficulty = difficulty.ToLower();
            }
        }
        while (true)

        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit'");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(count);
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;

            }
        }









    }
}