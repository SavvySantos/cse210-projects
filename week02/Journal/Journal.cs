using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public List<string> _journal = new List<string>();


    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        //foreach (Journal myEntries in )
        foreach (Entry entry in _entries) //object = Entry, name = entry, list name = _entries
        {
            Console.WriteLine(entry._date);
            Console.WriteLine(entry._promptText);
            Console.WriteLine(entry._entryText);
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (string entry in _journal)
            {
                outputFile.WriteLine(entry);
            }
        }
        Console.WriteLine("Your entries have been saved!");
    }

    public void LoadFromFile(string file)
    {
        Console.WriteLine("Here are your journal entries: ");
        List<Journal> journalFiles = new List<Journal>();
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}