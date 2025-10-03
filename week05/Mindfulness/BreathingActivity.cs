using System;
using System.Data;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by \nwalking you through breathing in and out slowly. \nClose your eyes, clear your mind, and focus on your breathing.")
    {

    }
    public void Run()
    {
        DisplayStartMessage();

        int duration = GetDuration();

        Console.WriteLine("");
        Console.WriteLine("Starting soon...");
        ShowSpinner(5);
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in through the nose...");
            ShowCountDown(5);
            Console.WriteLine("");

            Console.Write("Breathe out through your mouth...");
            ShowCountDown(5);
            Console.WriteLine("");
        }
        LogActivity();
        DisplayEndingMessage();
    }
}