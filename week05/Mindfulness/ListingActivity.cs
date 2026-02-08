using System.Numerics;
using System.Security.Cryptography.X509Certificates;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    }; public ListingActivity()
        : base("Listing activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    { }

    public string getRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return $"{_prompts[index]}";
    }
    public void DisplayPrompt()
    {
        System.Console.WriteLine("Consider to the following prompt.");
        System.Console.WriteLine();
        string prompt = getRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();


    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (endTime > DateTime.Now)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            items.Add(input);
        }
        int total = items.Count;
        return items;

    }
    public void Run()
    {
        DisplayStartingMessage();
        System.Console.WriteLine(_description);
        DisplayPrompt();
        ShowSpinner(4);
        List<string> items = GetListFromUser();
        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items.");
        DisplayEndMessage();
    }
}