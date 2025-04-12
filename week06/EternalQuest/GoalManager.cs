public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score;
    private int _count = 0;

    public GoalManager()
    {

    }

    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            Console.Clear();
            DisplayPlayerPoints();

            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalsDetails(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
            }
        }
    }

    private void DisplayPlayerPoints()
    {
        Console.WriteLine($"You have {_score} points");
    }

    private void ListGoalNames()
    {
        if (_goals.Count != 0)
        {
            foreach (Goal goal in _goals)
            {
                _count++;
                Console.WriteLine($"{_count}. {goal.GetGoalName()}");
            }
            _count = 0;
        }
        else 
        {
            Console.WriteLine("0 goals");
        }
    }

    private void ListGoalsDetails()
    {
        if (_goals.Count != 0)
        {
            foreach (Goal goal in _goals)
            {
                _count++;
                Console.WriteLine($"{_count}. {goal.GetDetailsString()}");
            }
            _count = 0;
        }
        else 
        {
            Console.WriteLine("0 Goals");
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        string input = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (input)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, desc, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("Target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
        }
    }

    private void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you achieve? ");
    if (int.TryParse(Console.ReadLine(), out int goalCompleteIndex) &&
        goalCompleteIndex > 0 && goalCompleteIndex <= _goals.Count)
    {
        Goal goalAccomplished = _goals[goalCompleteIndex - 1];
        goalAccomplished.RecordEvent();
        _score += goalAccomplished.GetCurrentPoint();

        Console.WriteLine($"Event recorded! You gained {goalAccomplished.GetCurrentPoint()} points.");
        DisplayPlayerPoints();
    }
    else
    {
        Console.WriteLine("Invalid input. Try again.");
    }
    }

    private void SaveGoals()
    {
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            sw.WriteLine(_score);
            foreach (Goal g in _goals)
                sw.WriteLine(g.GetStringRepresentation());
        }
        Console.WriteLine("Goals saved.");
    }

    private void LoadGoals()
    {
       if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved goals.");
            return;
        }

        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

        switch (parts[0])
        {
            case "SimpleGoal":
                var sg = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                if (bool.Parse(parts[4])) sg.SetIsCompleteToTrue();
                _goals.Add(sg);
                break;

            case "EternalGoal":
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                break;

            case "ChecklistGoal":
                var cg = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[4]));
                cg.AddSaveAmountCompleted(int.Parse(parts[6]));
                if (bool.Parse(parts[7])) cg.SetIsCompleteToTrue();
                _goals.Add(cg);
                break;
        }
    }

    Console.WriteLine("Goals loaded.");
}
}