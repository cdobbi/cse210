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
        using (StreamWriter witer = new StreamWriter(filePath))
        {
            foreach (var newEntry in _entries)
            {
                Console.WriteLine($"{newEntry._date}|{newEntry._entryText}|{newEntry._randomTopic}");
                Console.WriteLine();
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
                Entry newEntry = new Entry(parts[0], parts[1], parts[2]);
                _entries.Add(newEntry);
            }
        }
    }
}
