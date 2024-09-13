using System;

public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string filePath = "myjournal.txt";

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Choose an option from the menu below: ");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Random topic entry");
            Console.WriteLine("3. Display journal entries");
            Console.WriteLine("4. Save journal entries");
            Console.WriteLine("5. Load journal entries");
            Console.WriteLine("6. Count entries by date");
            Console.WriteLine("7. Exit");
            Console.WriteLine();
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine();
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
                Console.Write("Enter file path to save journal entries to: ");
                filePath = Console.ReadLine();
                journal.SaveEntry(filePath);
                Console.WriteLine("Journal entries saved.");
            }
            else if (choice == "5")
            {
                Console.WriteLine();
                Console.Write("Enter file path to load journal entries from: ");
                string loadPath = Console.ReadLine();
                journal.LoadFromEntry(loadPath);
                Console.WriteLine();
            }
            else if (choice == "6")
            {
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

// Video Demo
// The following video demonstrates the way this program should work:

// Direct link: Journal Program Demo (3 minutes)


// Code Helps
// You might find the following code helps useful in this project:

// Reading Text Files in C#
// Writing Text Files in C#
// Working with Dates in C#
// Still having difficulty reading and writing files?
// The following video walks through through the development of a program that reads and writes a list of objects to a file in a similar way that you will need to for your program:

// CSV Reading and Writing Demo (20 Minutes)
// Remember: Do not ever click "Debug Anyway".

// If you have an error in your program and try to run it, VS Code will tell you that it cannot build a new version of your program to run. But, it may find an old version from the last time it successfully built the program. If you click "Debug Anyway" it will run the old version.

// If you "Debug Anyway" you will be running a program that is different from your current code. This leads to lots of confusion, because you might make changes to your code, but the program does not show the changes.

// To avoid these pitfalls, you should never click "Debug Anyway" instead, click "Abort" and track down your errors, or click "Show Errors" to go directly to them.

// Design
// You will work with your team to create a design for this program. Then, you will each write the code for the program individually.

// Final Design (Do not open until after your design meeting)
// Develop the Program
// In the course repository, find the Develop02 project in the Prove folder and write your program there.

// Submission
// Develop the program using the principle of Abstraction as described above.
// Make sure to describe anything you have done to exceed the requirements in comments in the Program.cs file.
// Commit your source code and push it to GitHub.
// Verify that you can see your updated code at GitHub.
// In Canvas, submit a link to your GitHub repository. In the submission comment, describe anything you have done to show creativity and exceed the core requirements.
// Working with Others
// In this course you are encouraged to help and teach one another. But keep in mind that the goal is for you to learn how to write these programs yourself, not simply to turn in a working program.

// Because the goal is for you to learn to write these programs on your own, you should NOT copy and paste any code from another student or from a repository you find online. Similarly, you should NOT look at their code and type it in directly from a picture or from what you see on your screen. This is a violation of the University Honor Code, will result in a 0 on the assignment or failing the class, and will not help you learn.

// Instead, when you get help from another person, you should try to understand the principle of what they are doing, and then, use that to help you write your own code.

// If you get help from a web page, include a link to that web page in your comments.

// If you have any questions about this, please talk with your instructor.

// Copyright © Brigham Young University-Idaho | All rights reserved