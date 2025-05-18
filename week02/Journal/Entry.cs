using System;

public class Entry
{
    public DateTime _date { get; set;}
    public string _promptText { get; set;}
    public string _entryText { get; set;}
    public void Display()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine("");
        Console.WriteLine($"{_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}