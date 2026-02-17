using System;

class Program
{
    List<Activity> activities = new List<Activity>();

    static void Main(string[] args)
    {
    List<Activity> activities = new List<Activity>();

    activities.Add(new Running(30, DateTime.Now, 5));
    activities.Add(new Cycling(45, DateTime.Now, 15));
        activities.Add(new Swimming(40, DateTime.Now, 20));
    foreach(Activity activity in activities)
        {
            System.Console.WriteLine(activity.GetSummary());
        }
    }
}