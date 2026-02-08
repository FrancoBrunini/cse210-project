class BreathingActivity : Activity
{
    public BreathingActivity()
    : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. " +
            "Clear your mind and focus on your breathing.", 0)
    {
    }
    public void Run()
    {
        DisplayStartingMessage();
        int timeRemaining = _duration;
        while (timeRemaining > 0)
        {
            Console.Write("Breathe in... \n");
            ShowCountDown(4);
            timeRemaining -= 4;
            Console.Write("Breath out... \n");
            ShowCountDown(4);
            timeRemaining -= 4;




        }
        DisplayEndMessage();
    }
}