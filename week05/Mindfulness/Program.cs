using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string option = "";
        while (option != "4")
        {
            System.Console.WriteLine("Menu option: \n 1. Start breathing activity. \n 2. Start Reflecting activity. \n 3. Start Listing Activity. \n 4. Quit.");
            Console.Write("Select a choice from the menu: ");

            option = Console.ReadLine();
            if (option == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (option == "2")
            {

                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
            }
            else if (option == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if (option == "4")
            {
                System.Console.WriteLine("Goodbye.");
            }
            else
            {
            Console.WriteLine("Invalid option. Please try again.");

            }
        }
        
    }
}
