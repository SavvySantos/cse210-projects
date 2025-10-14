using System;
using System.ComponentModel.DataAnnotations;

abstract class Activity
{
    private DateTime _date;
    private string _activity;
    private int _time;

    public Activity(string activity, int time)
    {
        _date = DateTime.Now;
        _activity = activity;
        _time = time;
    }
    public string GetActivity() => _activity;
    public int GetTime() => _time;
    public DateTime GetDate() => _date;
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string ActivitySummary()
    {
        return $"{GetDate():dd MMM yyyy}: {GetActivity()}({GetTime()} min) - " +
        $"Distance: {GetDistance():0.00} mile, Speed: {GetSpeed():0.00} mph, Pace: {GetPace():0.00} min/mile";
    }
    public abstract void RecordActivity();
}