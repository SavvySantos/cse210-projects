using System;
using System.ComponentModel;

class EternalGoal : Goal
{
        public EternalGoal(string name, string description) : base(name, description, 100)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"You recorded '{GetShortName()}' and earned {GetPoints()} points!");
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString()
    {
        return $"[∞] {GetShortName()} ({GetDescription()})";
    }

    public override string ToFileFormat()
    {
        return $"Eternal Goal|{GetShortName()}|{GetDescription()}|{GetPoints()}";
    }

    public override string GetStringRepresentation() => ToFileFormat();
}