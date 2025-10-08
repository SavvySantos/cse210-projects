using System;
using System.ComponentModel;

class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, bool isComplete = false) : base(name, description, 50)
    {
        _isComplete = isComplete;
    }
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You earned {GetPoints()} points!");
        }
        else
        {
            Console.WriteLine("This goal has already been completed");
        }
    }
    public override bool IsComplete() => _isComplete;
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {GetShortName()} ({GetDescription()})";
    }
    public override string ToFileFormat()
    {
        return $"Simple Goal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{IsComplete()}";
    }

    public override string GetStringRepresentation() => ToFileFormat();
}
