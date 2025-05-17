using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

public class Journal
{
    public List<string> _entries = new List<string>();

    public void AddEntry(string newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (string entry in _entries) //object = Entry, name = entry, list name = _entries
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string file)
    {
        string filename = "journal.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string entry in _entries)
            {
                outputFile.WriteLine(_entries);
            }
            Console.WriteLine("Your entries have been saved!");
        }
    }

    public void LoadFromFile(string file)
    {
        List<Journal> journalFiles = new List<Journal>();
        Console.WriteLine("Here are your journal entries: ");
        string filename = "journal.txt";
        //string[] fileContent = File.ReadAllLines("c:\\journal.txt");
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}