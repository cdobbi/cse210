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
    public void SaveEntry(string filePath )
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var newEntry in _entries)
            {
                writer.WriteLine($"{newEntry.Date}|{newEntry.EntryText}|{newEntry.RandomTopic}");
            }
        }
    }
    public void LoadFromEntry(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine();
            Console.WriteLine($"File not found: {filePath}");
            Console.WriteLine();
            return;
        }
        using (StreamReader reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split("|");
                if (parts.Length == 3)
                {
                    Entry newEntry = new Entry(parts[0], parts[1], parts[2]);
                    _entries.Add(newEntry);
                    Console.WriteLine($" Loaded entry: {newEntry.Date} {newEntry.RandomTopic} {newEntry.EntryText}");
                }
                else
                {
                    Console.WriteLine($"Invalid entry format: {line}");
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
        foreach (var entry in _entries)
        {
            if (entry.Date == date)
            {
                count++;
            }
        }
        return count;
    }
}
