using System;
using System.Diagnostics;

class Running : Activity
{
    private double _distance;
    public Running(int distance, int time) : base("Running", time)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (GetTime() / 60.0);
    }

    public override double GetPace()
    {
        return GetTime() / _distance;
    }
    public override void RecordActivity()
    {
        Console.WriteLine("Running activity recorded!");
    }
}