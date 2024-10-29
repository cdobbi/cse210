using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private string filePath = "myjournal.txt";

    public Journal()
    {
        if (File.Exists(filePath))
        {
            LoadEntries();
        }
    }    
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }
    public void DisplayEntries()
    {
        foreach (var newEntry in entries)
        {
            newEntry.Display();
        }
    }
    public void SaveEntries()
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry._date}|{entry._topic}|{entry._journalEntry}");
            }
        }
    }
    public void LoadEntries()
    {
        entries.Clear();
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] categories = line.Split("|");
                if (categories.Length == 3)
                {
                    Entry newEntry = new Entry(categories[0], categories[1], categories[2]);
                    entries.Add(newEntry);
                    // Console.WriteLine($"Loaded entry: {newEntry._date}|{newEntry._topic}|{newEntry._journalEntry}");
                }
                else
                {
                    Console.WriteLine("Invalid entry format");
                }
            }
        }
        // Console.WriteLine($"{entries.Count} entries retrieved successfully.");
    }
    public int CountTotalEntries()
    {
        // int count = 0;
        // foreach (var entry in entries)
        // {
        //     if (entry._date == date)
        //     {
        //         count++;
        //     }
        // }
        return entries.Count;
    }
}

