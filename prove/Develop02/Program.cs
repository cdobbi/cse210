// I added a count entries by a given date and additinal random topic options. The save, load from filepath, count entries, journal entry, and random topic all work as expected. (I think) My husband helped me a lot with this rewrite but did not do it for me. I refrenced online sources and google a lot. I asked copilot a gazziion questions.

using System;
public class Program
{    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string filePath = Path.Combine("journal_entries.txt");
        bool running = true;

        Entry newEntry = new Entry("2222-22-22", "First Entry", "Some kind of journal entry.");
        Entry newEntry2 = new Entry("2024-09-20", "Another Entry", "Another kind of journal entry.");
        Entry newEntry3 = new Entry("2024-10-23", "Writing a novel at this point", "Continue writing journal entries, kind of journal entry.");
        journal.AddEntry(newEntry);
        journal.AddEntry(newEntry2);
        journal.AddEntry(newEntry3);
        journal.DisplayEntries();
        journal.SaveEntry(filePath);
        journal.LoadFromEntry(filePath);
        journal.CountEntries("2024-10-23");

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Choose an option from the menu below: ");
            Console.WriteLine("1. New journal entry");
            Console.WriteLine("2. Random topic journal entry");
            Console.WriteLine("3. Save journal entries");
            Console.WriteLine("4. Load journal entries");
            Console.WriteLine("5. Display journal entry");
            Console.WriteLine("6. Count entries");
            Console.WriteLine("7. Exit");
            Console.WriteLine();
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine();
                    Console.Write("Enter today's date (YYYY-MM-DD): ");
                    string _date = Console.ReadLine();
                    Console.Write("Topic of journal entry: ");
                    string _topic = Console.ReadLine();
                    Console.Write("Write your journal entry: ");
                    string _journalEntry = Console.ReadLine();
                    Entry newJournalEntry = new Entry(_date, _topic, _journalEntry);
                    journal.AddEntry(newJournalEntry);
                    journal.SaveEntry(filePath);
                    Console.WriteLine("Journal entry saved.");
                    break;
                case "2":
                    string randomTopic = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Random topic: {randomTopic}");
                    Console.Write("Enter the journal entry: ");
                    string randomEntryText = Console.ReadLine();
                    Entry randomEntry = new Entry(DateTime.Now.ToString("yyyy-MM-dd"), randomTopic, randomEntryText);
                    journal.AddEntry(randomEntry);
                    journal.SaveEntry(filePath);
                    Console.WriteLine("Journal entry saved.");
                    break;
                case "3":
                    journal.DisplayEntries();
                    Console.WriteLine("Journal entries saved.");
                    break;
                case "4":
                    journal.LoadFromEntry(filePath);
                    break;

                case "5":
                    journal.DisplayEntries();
                    break;

                case "6":
                    Console.Write("Enter the date (yyyy-mm-dd): ");
                    string countDate = Console.ReadLine();
                    int count = journal.CountEntries(countDate);
                    Console.WriteLine($"Number of entries on {countDate}: {count}");
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}



// CSE 210: Programming with Classes
// Week 02 Develop: Journal Program
// Program Specification
// For this assignment you will write a program to help people record the events of their day by supplying prompts and then saving their responses along with the question and the date to a file.
// Functional Requirements
// This program must contain the following features:
// Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
// Display the journal - Iterate through all entries in the journal and display them to the screen.
// Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
// Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal.
// Provide a menu that allows the user choose these options
// Your list of prompts must contain at least five different prompts. Make sure to add your own prompts to the list, but the following are examples to help get you started:
// Who was the most interesting person I interacted with today?
// What was the best part of my day?
// How did I see the hand of the Lord in my life today?
// What was the strongest emotion I felt today?
// If I had one thing I could do over today, what would it be?
// Your interface should generally follow the pattern shown in the video demo below.
// Design Requirements
// In addition, your program must:
// Contain classes for the major components in the program.
// Contain at least two classes in addition to the Program class.
// Demonstrate the principle of abstraction by using member variables and methods appropriately.
// Simplifications
// For the core requirements you do not need to worry about the following:
// Saving your file as a .csv file requires you to handle commas and quotes in the content appropriately. At this point, you can ignore that and just choose a symbol for a separator that you think is unlikely to show up in the content (such as | or ~ or ~|~).
// You do not need to store the date as an actual C# DateTime object in your class or in the file. You can simply store it as a string.
// Showing Creativity and Exceeding Requirements
// Meeting the core requirements makes your program eligible to receive a 93%. To receive 100% on the assignment, you need to show creativity and exceed these requirements.
// Here are some ideas you might consider:
// Think of other problems that keep people from writing in their journal and address one of those.
// Save other information in the journal entry.
// Improve the process of saving and loading to save as a .csv file that could be opened in Excel (make sure to account for quotation marks and commas correctly in your content.
// Save or load your document to a database or use a different library or format such as JSON for storage.
// Report on what you have done to exceed requirements by adding a description of it in a comment in the Program.cs file.
