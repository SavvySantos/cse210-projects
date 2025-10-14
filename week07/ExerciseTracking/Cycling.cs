using System;
using System.Net.Http.Headers;

class Cycling : Activity
{
    private double _distance;
    public Cycling(int distance, int time) : base("Cycling", time)
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
        Console.WriteLine("Cycling activity recorded!");
    }
}