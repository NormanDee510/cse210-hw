using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<JournalEntry> Entries { get; private set; }

    public Journal()
    {
        Entries = new List<JournalEntry>();
    }

    public void AddEntry(JournalEntry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in Entries)
        {
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine($"Date: {entry.Date}\n");
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in Entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            Entries.Clear();
            foreach (var line in File.ReadLines(filename))
            {
                var parts = line.Split(new string[] { "~|~" }, StringSplitOptions.None);
                if (parts.Length == 3)
                {
                    var entry = new JournalEntry(parts[0], parts[1], parts[2]);
                    Entries.Add(entry);
                }
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
}
