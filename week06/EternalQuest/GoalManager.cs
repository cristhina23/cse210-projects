class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _level = 1;

    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            Console.Clear();
            Console.WriteLine($"\nCurrent Score: {_score}  |  Level: {_level}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": Console.WriteLine("Goodbye!"); break;
                default: Console.WriteLine("Invalid option"); break;
            }
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nWhich type of goal do you want to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string type = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter a short description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1": _goals.Add(new SimpleGoal(name, description, points)); break;
            case "2": _goals.Add(new EternalGoal(name, description, points)); break;
            case "3":
                Console.Write("Enter target count to complete: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
        }
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("\nYour Goals:");
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("\nWhich goal did you accomplish?");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
        Console.Write("Choose goal number: ");
        int choice = int.Parse(Console.ReadLine());
        int points = _goals[choice - 1].RecordEvent();
        _score += points;
        Console.WriteLine($"Great job! You earned {points} points.");
        UpdateLevel();
    }

    private void UpdateLevel()
    {
        int newLevel = (_score / 500) + 1;
        if (newLevel > _level)
        {
            _level = newLevel;
            Console.WriteLine($"\n🎉 Congratulations! You leveled up to Level {_level}!");
        }
    }

  private void SaveGoals()
  {
    Console.Write("Enter the name you want for the file (e.g., mygoals.txt): ");
    string fileName = Console.ReadLine();

    using (StreamWriter writer = new StreamWriter(fileName))
    {
        writer.WriteLine(_score);
        foreach (Goal goal in _goals)
        {
            writer.WriteLine(goal.GetStringRepresentation());
        }
    }

    Console.WriteLine("Goals saved successfully in " + fileName);
  }

  private void LoadGoals()
  {
    Console.Write("Enter the name of the file to load (e.g., mygoals.txt): ");
    string fileName = Console.ReadLine();

    _goals.Clear();
    
    if (File.Exists(fileName))
    {
        string[] lines = File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            switch (parts[0])
            {
                case "SimpleGoal":
                    SimpleGoal sg = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    sg.LoadState(parts);
                    _goals.Add(sg);
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "ChecklistGoal":
                    ChecklistGoal cg = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                    cg.LoadState(parts);
                    _goals.Add(cg);
                    break;
            }
        }

        Console.WriteLine("Goals loaded successfully from " + fileName);
    }
    else
    {
        Console.WriteLine("The file \"" + fileName + "\" was not found.");
    }
  }

}

