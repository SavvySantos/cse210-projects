using System;

class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int target) : base(name, description, 30)
    {
        _target = target;
        _bonus = 200;
        _amountCompleted = 0;
    }
    public ChecklistGoal(string name, string description, int target, int points, int bonus, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;

    }
    public override void RecordEvent()
    {

        if (!IsComplete())
        {
            _amountCompleted++;
            Console.WriteLine($"You earned {GetPoints()} points! You earned a bonus of {_bonus} points!");
    
            if (IsComplete() && _amountCompleted == _target)
            {
                Console.WriteLine($"Congratulations! You completed the checklist!");
            }
        }
        else
        {
            Console.WriteLine("This checklisst goal is already complete!");
        }
    }
    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string ToFileFormat()
    {
        return $"Checklist Goal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_bonus}|{_target}|{_amountCompleted}";
    }
    public int GetBonus()
    {
        return _bonus;
    }

    public override string GetStringRepresentation() => ToFileFormat();
}