using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        
        Console.WriteLine("Activity is about to start...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine(" ");
        Console.WriteLine("Congragulations!");
        ShowSpinner(5);
        Console.WriteLine(" ");
        Console.WriteLine($"You have completed a {_name} activity for {_duration} seconds!");
        ShowSpinner(5);
    }

    public void LogActivity()
    {
        Console.Write("Enter a file name for your activity log (e.g., my_activity.txt): ");
        string logFileName = Console.ReadLine();

        string directoryPath = Path.GetDirectoryName(logFileName);
        string timeStamp = DateTime.Now.ToString("yyyyy-MM-dd HH:mm:ss");
        string logEntry = $"{timeStamp} - Activity: {_name}, Duration: {_duration} seconds{Environment.NewLine}";
        File.AppendAllText(logFileName, logEntry);
        Console.WriteLine($"Activity logged to {logFileName}");
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        char[] spinner = { '|', '/', '-', '\\' };
        int spinnerIndex = 0;

        int originalLeft = Console.CursorLeft;
        int originalTop = Console.CursorTop;

        while (DateTime.Now < endTime)
        {
            Console.SetCursorPosition(originalLeft, originalTop);
            Console.WriteLine(spinner[spinnerIndex]);
            Thread.Sleep(250);
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
        }

        Console.SetCursorPosition(originalLeft, originalTop);
        Console.WriteLine(" ");
        Console.CursorVisible = true;
    }

    public void ShowCountDown(int seconds)
    {
        int currentColumnCursor = Console.CursorLeft;
        int currentLineCursor = Console.CursorTop;
        for (int i = seconds; i > 0; i--)
        {
            Console.SetCursorPosition(currentColumnCursor, currentLineCursor);
            Console.WriteLine($"{i} ");
            Thread.Sleep(1000);
        }

        Console.SetCursorPosition(currentColumnCursor, currentLineCursor);
        Console.Write(new string(' ', seconds.ToString().Length + 1));
        //Console.Write(new string(' ', seconds.ToString().Length));
        //Console.CursorVisible = true;
        //Console.SetCursorPosition(originaCursorlLeft, originalCursorTop);
    }

    public int GetDuration()
    {
        Console.WriteLine("How long, in seconds, would you like your session to be? ");
        _duration = int.Parse(Console.ReadLine());

        return _duration;
    }
}