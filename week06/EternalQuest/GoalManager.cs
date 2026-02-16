using System.IO;
using System.Runtime;

class GoalManager

{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    public GoalManager(int score)
    {
        _score = 0;
    }
    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
                CreateGoal();
            else if (choice == 2)
                ListGoalDetails();
            else if (choice == 5)
                RecordEvent();
            else if (choice == 3)
                SaveGoals();
            else if (choice == 4)
                LoadGoals();

        }

    }

    public void DisplayPlayerInfo()
    {
        System.Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].Show()}");
        }
    }
    public void CreateGoal()
    {
Console.WriteLine("The types of Goals are:");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");

    Console.Write("Which type of goal would you like to create? ");
    int choice = int.Parse(Console.ReadLine());

    Console.Write("What is the name of your goal? ");
    string name = Console.ReadLine();

    Console.Write("What is a short description of it? ");
    string description = Console.ReadLine();

    Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }
        if (choice == 2)
        {
            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }
       if (choice == 3)
        {
        Console.Write("How many times does this goal need to be accomplished? ");
        int target = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for completing it? ");
        int bonus = int.Parse(Console.ReadLine());
        CheckListGoal goal = new CheckListGoal(name, description, points, 0, target, bonus);
        _goals.Add(goal);
    }
    }
    public void RecordEvent()
    {
        ListGoalDetails();

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        Goal goal = _goals[choice - 1];
        goal.RecordEvent();
        _score += goal.GetPoints();
        Console.WriteLine("Event recorded!");


    }
    public void SaveGoals()
    {
       Console.Write("What is the filename? ");
        string filename = Console.ReadLine();


        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);
                    foreach (Goal goal in _goals)
        {
            output.WriteLine(goal.Save());
        }

        }

    }
    public void LoadGoals()
    {
Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();
        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split("|");

            string type = parts[0];
            if (type == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);
                SimpleGoal goal = new SimpleGoal(name, description, points);
                if (isComplete)
                {
                    goal.RecordEvent();
                }
            _goals.Add(goal);

            }
            else if (type == "EternalGoal")

            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);

            }




            else if (type == "CheckListGoal")
            {
string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int amountCompleted = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);
                CheckListGoal goal = new CheckListGoal(name, description, points, amountCompleted, target, bonus);
            _goals.Add(goal);
            }
        }
      
    }
}