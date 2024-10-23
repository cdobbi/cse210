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
    }
    public void LoadFromEntry(string filePath)
    {
        if (File.Exists(filePath))
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

            Console.WriteLine($"{entries.Count} entries retrieved successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }

    }

    public int CountEntries(string date)
    {
        int count = 0;
        foreach (Entry entry in entries)
        {
            {
                count++;
            }
        }

        if (count == 0)
        {
            Console.WriteLine();
        }

        return count;
    }
}

