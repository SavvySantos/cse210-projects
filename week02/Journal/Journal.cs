using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    public void AddEntry(string prompt, string newEntry)
    {
        entries.Add(new Entry(prompt, newEntry));
    }

    public void DisplayAll()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries have been written yet.");
            return;
        }
        else
        {
            foreach (var entry in entries)
            {
                Console.WriteLine(entry);
            }
        }
    }

    public void SaveToFile(string fileName)
    {
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine(entry.ToFileFormat());
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"Journal saved to {fileName}");
    }
    public void LoadFromFile(string fileName)
    {   
        entries.Clear();
            Console.WriteLine("----- Journal Entries ----- ");
            foreach (var entry in File.ReadAllLines(fileName))
            {
                Console.WriteLine("");
                Console.WriteLine(entry);
            }
    }
}

