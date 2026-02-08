using System.ComponentModel.DataAnnotations;

class Activity
{

    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        System.Console.WriteLine($"Welcome to the {_name} activity!");
        Console.Write("\nHow long, in seconds, would you like for this activity? ");
        _duration = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Get ready...");
        ShowSpinner(3);

    }
    public void DisplayEndMessage()
    {
        System.Console.WriteLine($"Well done! \n You have complete another {_duration} seconds of the {_name} activity");
    }
    public void ShowSpinner(int seconds)
    {
        int i = 0;
        List<string> animationString = new List<string>
{
    "|",
    "/",
    "-",
    "\\"
};
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;
            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        while (seconds != -1)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds--;
        }
    }

}