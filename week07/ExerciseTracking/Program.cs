using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = new List<Activity>();

        Console.WriteLine("");

        activities.Add(new Running(5, 30));
        activities.Add(new Swimming(20, 40));
        activities.Add(new Cycling(15, 60));
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.ActivitySummary());
            activity.RecordActivity();
            Console.WriteLine("");
        }
    }
}