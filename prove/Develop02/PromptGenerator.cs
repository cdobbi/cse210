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
@@ -54,30 +59,39 @@ public static void Main(string[] args)
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

@@ -86,27 +100,6 @@ public static void Main(string[] args)
// CSE 210: Programming with Classes

// Week 02 Develop: Journal Program
// Problem Overview
// Many people see the value of keeping a journal to record important events, and many people even set this as a goal. And yet, very few people actually follow through and keep a journal consistently.

// Think to yourself for a moment: What are some reasons people do not follow through with their goal to keep a journal? Could a program or app help with any of these?

// Some of the reasons you thought of might include the following:

// We forget
// It's not convenient to get out our written journal or find the electronic document
// We don't feel like we have anything interesting to say
// We don't feel like we have time for it
// We aren't sure what to write
// We feel overwhelmed with writing every event of the day, so we just don't write anything.
// While it will not solve all of people's problems, a great program or an app could help remove some of these barriers. For example, an app could give you a reminder at a certain time of day or give you a direct link to your document.

// Consider the last challenge mentioned above, that of being overwhelmed because it feels like you must write every event during the day, this seems to be a big problem for many people. Could an app help with this?

// Solution Idea
// What if the Journal app gave people a simple prompt to respond to every day? It could also record the response somewhere for them and even add elements like the data automatically.

// These features could help address some of the challenges that keep people from journaling, and could be included in a mobile app or on a web page. The actual interface is not that critical, but the ability for a program to help solve a real problem is important to recognize.

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
