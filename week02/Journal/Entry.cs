using System;

public class Entry
{
    List<string> journalEntry = new List<string>();

    public string _date;
    public string _promptText;
    public string _entryText;
    public void Display()
    {
        DateTime currentDateTime = DateTime.Now;
        Console.WriteLine($"{currentDateTime}");
        Console.WriteLine("");
        Console.WriteLine($"{_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}