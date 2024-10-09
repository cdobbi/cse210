using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        entries.Add(newEntry);
    }
    public void DisplayEntries()
    {
        foreach (var newEntry in entries)
        {
            newEntry.Display();
        }
    }
    public void SaveEntry(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var newEntry in entries)
            {
                writer.WriteLine($"{newEntry._date}|{newEntry._topic}|{newEntry._journalEntry}");
            }     
        }
        entries.Clear();
    }
    public void LoadFromEntry(string filePath)
    {
        if (File.Exists(filePath))
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
                        entries.Add(newEntry);
                        // Console.WriteLine($"Loaded entry: {newEntry._date}|{newEntry._topic}|{newEntry._journalEntry}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry");
                    }
                }
            }
            if (entries.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("No entries loaded.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"{entries.Count} entries loaded successfully.");
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
    public int CountEntriesByDate(string date)
    {
        int count = 0;
        foreach (Entry entry in entries)
        {
            if (entry._date == date)
            {
                count++;
            }
        }
        return count;
    }
}
