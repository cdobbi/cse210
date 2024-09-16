\using System;
public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;
        string filePath = "myjournal.txt";

        while (running)
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("Choose an option from the menu below: ");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Random topic entry");
            Console.WriteLine("3. Display journal entries");
            Console.WriteLine("4. Save entry");
            Console.WriteLine("4. Save journal entries");
            Console.WriteLine("5. Load journal entries");
            Console.WriteLine("6. Exit");
            Console.WriteLine("6. Count entries by date");
            Console.WriteLine("7. Exit");
            Console.WriteLine();
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine();
                Console.Write("Enter today's date: ");
                Console.Write("Enter today's date (YYYY-MM-DD): ");
                string date = Console.ReadLine();
                Console.Write("Topic of entry: ");
                string topic = Console.ReadLine();
                Console.Write("Write your entry: ");
                string entry = Console.ReadLine();
                Entry newEntry = new Entry(date, entry, topic);
                journal.AddEntry(newEntry);
                journal.SaveEntry(filePath);
                Console.WriteLine("Entry saved.");
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                Console.Write("Enter today's date: ");
                Console.Write("Enter today's date (YYYY-MM-DD): ");
                string date = Console.ReadLine();
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt} ");
                Console.Write("Write your entry: ");
                string entryText = Console.ReadLine();
                Entry newEntry = new Entry(date, prompt, entryText);
                journal.AddEntry(newEntry);
                journal.SaveEntry(filePath);
                Console.WriteLine("Entry saved.");
            }
            else if (choice == "3")
            {
                journal.DisplayEntries();
                Console.WriteLine();
            }
            else if (choice == "4")
            {
                Console.WriteLine();
                Console.Write("Enter file path to save journal entries: ");
                string filePath = Console.ReadLine();
                Console.Write("Enter file path to save journal entries to: ");
                filePath = Console.ReadLine();
                journal.SaveEntry(filePath);
                Console.WriteLine("Journal entries saved.");
            }
            else if (choice == "5")
            {
                Console.WriteLine();
                Console.Write("Enter file path to load journal entries: ");
                Console.Write("Enter file path to load journal entries from: ");
                string loadPath = Console.ReadLine();
                journal.LoadFromEntry(loadPath);
                Console.WriteLine();
            }
            else if (choice == "6")
            {
                running = false;
                Console.WriteLine();
                Console.Write("Enter the date to count entries (YYYY-MM-DD): ");
                string date = Console.ReadLine();
                int count = journal.CountEntriesByDate(date);
                Console.WriteLine($"Number of entries on {date}: {count}");
            }
            else if (choice == "7")
            {
                Console.WriteLine();
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid option. Please try again.");
            }

       }
        }
    }
}
