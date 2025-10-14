using System;
using System.IO.Pipes;
using System.Reflection.Metadata.Ecma335;

class Swimming : Activity
{
    private int _laps;
    public Swimming(int laps, int time) : base("Swimming", time)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double meters = _laps * 50;
        double kilometers = meters / 1000;
        double miles = kilometers * 0.62;
        return miles;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (GetTime() / 60.0);
    }

    public override double GetPace()
    {
        return GetTime() / GetDistance();
    }

    public override void RecordActivity()
    {
        Console.WriteLine("Swimming activity recorded!");
    }
}