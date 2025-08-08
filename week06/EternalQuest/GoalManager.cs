using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Display score");
            Console.WriteLine("2. Create new goal");
            Console.WriteLine("3. List goals");
            Console.WriteLine("4. Record an event");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    CreateGoal();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    RecordEvent();
                    break;
                case "5":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    SaveGoals(saveFile);
                    break;
                case "6":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    LoadGoals(loadFile);
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score} points");
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Select an action: ");
        string option = Console.ReadLine();

        Console.Write("Goal name: ");
        string name = Console.ReadLine();

        Console.Write("Goal description: ");
        string description = Console.ReadLine();

        Console.Write("Points awarded: ");
        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            Console.WriteLine("Invalid points input.");
            return;
        }

        Goal goal = null;

        switch (option)
        {
            case "1":
                goal = new SimpleGoal(name, description, points);
                break;
            case "2":
                goal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("Number of times to complete: ");
                if (!int.TryParse(Console.ReadLine(), out int targetCount))
                {
                    Console.WriteLine("Invalid number input.");
                    return;
                }

                Console.Write("Bonus points upon completion: ");
                if (!int.TryParse(Console.ReadLine(), out int bonusPoints))
                {
                    Console.WriteLine("Invalid bonus input.");
                    return;
                }

                goal = new ChecklistGoal(name, description, points, targetCount, bonusPoints); // ✅ Aquí está bien
                break;
            default:
                Console.WriteLine("Invalid option.");
                return;
        }

        _goals.Add(goal);
        Console.WriteLine("Goal successfully created.");
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            var goal = _goals[i];
            string status = goal.IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {status} {goal.GetName()} - {goal.GetDescription()}");
            Console.WriteLine($"{goal.GetDetailsString()}");
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record events for.");
            return;
        }

        Console.WriteLine("Available goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
        Console.Write("Select the number of the goal you completed/progressed: ");
        if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > _goals.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }
        index--;

        _goals[index].RecordEvent();

        if (_goals[index].IsComplete())
        {
            _score += _goals[index].GetPoints();
            Console.WriteLine($"Goal completed! You earned {_goals[index].GetPoints()} points.");
        }
        else
        {
            Console.WriteLine("Event recorded. Goal is not yet complete.");
        }
    }

    public void SaveGoals(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals and score saved.");
    }

    public void LoadGoals(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("No save file found.");
            return;
        }

        _goals.Clear();

        using (StreamReader reader = new StreamReader(file))
        {
            string scoreLine = reader.ReadLine();
            if (!int.TryParse(scoreLine, out _score))
            {
                Console.WriteLine("Invalid score format.");
                return;
            }

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts.Length < 4)
                {
                    Console.WriteLine("Invalid goal format.");
                    continue;
                }

                string type = parts[0];
                string name = parts[1];
                string description = parts[2];

                if (!int.TryParse(parts[3], out int points))
                {
                    Console.WriteLine("❌ Invalid points value.");
                    continue;
                }

                Goal goal = null;

                if (type == "SimpleGoal")
                {
                    goal = new SimpleGoal(name, description, points);
                }
                else if (type == "EternalGoal")
                {
                    goal = new EternalGoal(name, description, points);
                }
                else if (type == "ChecklistGoal")
                {
                    if (parts.Length < 7 ||
                        !int.TryParse(parts[4], out int amountCompleted) ||
                        !int.TryParse(parts[5], out int target) ||
                        !int.TryParse(parts[6], out int bonus))
                    {
                        Console.WriteLine("Invalid checklist goal format.");
                        continue;
                    }

                    goal = new ChecklistGoal(name, description, points, amountCompleted, target, bonus);
                }
                else
                {
                    Console.WriteLine($"Unknown goal type: {type}");
                    continue;
                }

                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals and score loaded successfully.");
        DisplayPlayerInfo();
        ListGoalDetails();
    }
}
