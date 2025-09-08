using System;

public class Entry
{
    public DateTime Date { get; set; }
    public string PromptText { get; set; }
    public string Text { get; set; }


    public Entry(string prompt, string newEntry)
    {
        Date = DateTime.Now;
        PromptText = prompt;
        Text = newEntry;
    }
    public override string ToString()
    {
        return $"{Date:g}: {PromptText} - {Text}";
    }
    public string ToFileFormat()
    {
        return $"{Date} {PromptText}: {Text}";
    }

}