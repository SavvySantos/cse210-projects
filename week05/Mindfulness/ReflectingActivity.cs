using System;
using System.Security.Cryptography.X509Certificates;

public class ReflectingActivity : Activity 
{
    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }

    public void Run()
    {
        DisplayStartMessage();

        int duration = GetDuration();

        Console.WriteLine("");
        Console.WriteLine("Starting in...");
        ShowSpinner(5);
        Console.WriteLine("");

        DisplayPrompt();
        Console.WriteLine("");
        Console.WriteLine("When you have an answer, hit enter to continue");
        Console.ReadLine();
        Console.WriteLine("");

        Console.WriteLine("Here are a few questions for you to reflect on your experience.");
        ShowCountDown(5);


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Clear();
            DisplayQuestions();
            ShowSpinner(5);
        }
        LogActivity();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        List<string> _prompt = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people tha tyou have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heros?"
        };

        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompt.Count);
        return _prompt[index];
    }

    public string GetRandomQuestion()
    {
               List<string> _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        Random randomQuestion = new Random();
        int question = randomQuestion.Next(_questions.Count);
        return _questions[question];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"{GetRandomPrompt()}");
    }

    public void DisplayQuestions()
    {
        Console.WriteLine($"{GetRandomQuestion()}");
    }
}