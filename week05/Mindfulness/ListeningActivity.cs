using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;

public class ListeningActivity : Activity
{
    private readonly Random _random = new Random();
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    public ListeningActivity() : base("Listening Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. \n This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }

    public void Run()
    {
        DisplayStartMessage();

        int duration = GetDuration();

        Console.WriteLine("");
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.Clear();
        Console.WriteLine("");

        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        ShowSpinner(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        List<string> entries = new List<string>();
        int entryCount = 0;
        Console.WriteLine("Reflect on some questions that go along with the prompt. (ex: Why was this experience meaningful to you?)");

        while (DateTime.Now < endTime)
        {
            GetListFromUser();
            entryCount++;

            ShowSpinner(5);
            Console.Clear();
            Console.WriteLine(" ");
        }
        Console.Clear();

        LogActivity();
        DisplayEndingMessage();
        Console.WriteLine($"You listed {entryCount} items in {duration} amount of time.");
    }

    public string GetRandomPrompt()
    {
        //Random random = new Random();
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
       // prompt = _prompts[index];
        //ShowSpinner(5);
        //Console.WriteLine("");
    }

    public string GetListFromUser()
    {
        return Console.ReadLine();
    }
}
