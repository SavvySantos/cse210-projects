using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _level = 1;
    public void Start()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Level: {_level} | Score: {_score}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");

            Console.WriteLine("Choose one of the options below...");
            Console.WriteLine("");

            Console.WriteLine("-----Menu Options-----");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("");

            string userInput = Console.ReadLine();

            if (userInput == "1") CreateGoal();
            else if (userInput == "2") ListGoalDetails();
            else if (userInput == "3") SaveGoals();
            else if (userInput == "4") LoadGoals();
            else if (userInput == "5") RecordEvent();
            else if (userInput == "6") break;

            else
            {
                Console.WriteLine("Not a valid input. Please try again");
                Console.ReadKey();
            }
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("");
        string goalType = Console.ReadLine();

        Console.WriteLine("Goal Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("");

        Console.WriteLine("Description: ");
        string description = Console.ReadLine();
        Console.WriteLine("");

        Goal goal = null;

        if (goalType == "1") goal = new SimpleGoal(name, description);
        else if (goalType == "2") goal = new EternalGoal(name, description);
        else if (goalType == "3")
        {
            Console.WriteLine("Enter amount of times goal is to be completed:");
            int target = int.Parse(Console.ReadLine());
            goal = new ChecklistGoal(name, description, target);
        }

        if (goal != null)
        {
            _goals.Add(goal);
            Console.WriteLine("Goal created successfully!");
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }
    private void ListGoals()
    {
        Console.Clear();
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");

        }
        else
        {
            int i = 1;
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{i}. {goal.GetDetailsString()}");
                i++;
            }
        }
    }
    public void ListGoalDetails()
    {
        Console.Clear();
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found. Create and save a goal, then try again.");
        }
        else
        {
            Console.WriteLine("---Goal Details---");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }
    }
    public void RecordEvent()
    {
        Console.Clear();
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            return;
        }
        ListGoalDetails();

        Console.WriteLine("\nSelect goal number: ");

        if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > _goals.Count)
        {
            Console.WriteLine("Invalid Selection.");
            return;
        }

        Goal goal = _goals[index - 1];
        goal.RecordEvent();

        _score += goal.GetPoints();

        if (goal is ChecklistGoal checklist && checklist.IsComplete())
        {
            _score += checklist.GetBonus();
        }

        Console.WriteLine($"\nTotal Score: {_score}");
        UpdateLevel();
    }

    public void SaveGoals()
    {
        Console.WriteLine("Enter the name of the file to save to (ex: goals.txt): ");
        string filename = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(filename, false))
        {
            sw.WriteLine($"{_score} | {_level}");
            foreach (Goal goal in _goals)
                sw.WriteLine(goal.ToFileFormat());
        }
        Console.WriteLine("Goals saved successfully!");
    }
    public void LoadGoals()
    {
        Console.WriteLine("Enter the name of the file to load (ex: goals.txt): ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found. Please make sure the file exists and try again.");
            return;
        }
        string[] lines = File.ReadAllLines(filename);

        if (lines.Length == 0)
        {
            Console.WriteLine("File is empty. Create and save a goal, then try again.");
            return;
        }

        _goals.Clear();
        string[] parts = lines[0].Split("|");
        _score = int.Parse(parts[0].Trim());
        _level = int.Parse(parts[1].Trim());

        if (!int.TryParse(parts[0].Trim(), out _score) || !int.TryParse(parts[1].Trim(), out _level))
        {
            Console.WriteLine("Error reading score or level from file. File may be corrupted.");
        }
        for (int i = 1; i < lines.Length; i++)
        {
            string[] part = lines[i].Split("|");
            string goalType = part[0];
            Goal goal = null;

            if (goalType == "SimpleGoal" || goalType == "Simple Goal")
            {
                bool isComplete = bool.Parse(part[4]);
                goal = new SimpleGoal(part[1], part[2], isComplete);
            }
            else if (goalType == "EternalGoal" || goalType == "Eternal Goal")
            {
                _goals.Add(new EternalGoal(part[1], part[2]));
            }
            else if (goalType == "ChecklistGoal" || goalType == "Checklist Goal")
            {
                int points = int.Parse(part[3]);
                int bonus = int.Parse(part[4]);
                int target = int.Parse(part[5]);
                int amountCompleted = int.Parse(part[6]);

                goal = new ChecklistGoal(part[1], part[2], target, points, bonus, amountCompleted);
            }
            if (goalType != "1" && goalType != "2" && goalType != "3")
            {
                Console.WriteLine("Invalid selection. Please enter 1, 2, or 3.");
            }
 
            if (goal != null)
                _goals.Add(goal);
        }

        Console.WriteLine("Goals loaded successfully!");
        UpdateLevel();
    }

    private void UpdateLevel()
    {
        int previousLevel = _level;
        _level = (_score / 1000) + 1;
        if (_level > previousLevel)
        {
            Console.WriteLine($"Level up! You made it to Level {_level}!");
        }
    }
}