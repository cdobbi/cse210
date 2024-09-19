using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    private List<Entry> _entries;
    public Journal()
    {
        _entries = new List<Entry>();
    }
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayEntries()
    {
        foreach (var newEntry in _entries)
        {
            newEntry.Display();
        }
    }
    public void SaveEntry(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var newEntry in _entries)
            {
                writer.WriteLine($"{newEntry._date}|{newEntry._topic}|{newEntry._journalEntry}");
            }     
        }
    }
    public void LoadFromEntry(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[]categories = line.Split("|");
                if (categories.Length == 3)
                {
                    Entry newEntry = new Entry(categories[0],categories[1],categories[2]);
                    _entries.Add(newEntry);
                    Console.WriteLine($" Loaded entry: {newEntry._date} {newEntry._topic} {newEntry._journalEntry}");
                }
                else
                {
                    Console.WriteLine("Invalid entry");
                }
            }
        }
    if (_entries.Count == 0)
    {
        Console.WriteLine();
        Console.WriteLine("No entries loaded.");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"{_entries.Count} entries loaded successfully.");
    }
}
public int CountEntriesByDate(string date)
{
    int count = 0;
    foreach (var journalEntry in _entries)
    {
        if (journalEntry._date == date)
        {
            count++;
        }
    }
    return count;
}
}

