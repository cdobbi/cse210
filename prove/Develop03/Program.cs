using System;
using System.Collections.Generic;
// Stretch: added a line for debugging, and "As a stretch challenge, try to randomly select from only those words that are not already hidden." They program only hides words that are not already hidden.
//I received quidance fro my husband, a classmate and looked online for answers that I couldn't find in the class material. I also looked at my code from my python class to help me understand the concepts and structure of the code. I copy and pasted some of my code from my Python class but I had to change it to fit the C# language. I also used the code helps from the assignment and asked Copilot a ton of questions and for claifications when I was stuck and could't figure out what to do next. Any explanations you have for me would be greatly appreciated. I've spent about 25 hours just on week 03 material and assignments and am still struggling to understand a few things such as Constructors.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to Scripture Flashcards!");
        Console.Write("Press Enter to begin: ");
        Console.ReadLine();

        List<string> verses = new List<string>
        {
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding.",
            "In all thy ways acknowledge him, and he shall direct thy paths."
        };
        
        Scripture scripture = new Scripture("Proverbs 3:5-6", verses);
        Console.WriteLine();
        Console.WriteLine("Proverbs 3:5-6");
        Console.WriteLine(scripture.GetWords());

        string input = "";
        while (input.ToLower() != "quit")
        {
            Console.WriteLine();
            Console.Write("Press Enter to hide the next word, or type 'quit' to exit: ");
            input = Console.ReadLine();

            if (input.ToLower() != "quit")
            {
                Console.WriteLine("Hiding a word...");
                scripture.HideRandomWord();
                Console.Clear();
                Console.WriteLine("Proverbs 3:5-6");
                Console.WriteLine(scripture.GetWords());

                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("All words have been hidden. Goodbye!");
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
} 

// Week 03 Develop:Reference Memorizer

// Write a program that displays the full scripture and then hides a few words at a time until the complete scripture is hidden.

// Specification
// Functional requirements
// Your program must do the following:

// Store a scripture, including both theReference (for example "John 3:16") and the text of the scripture.
// Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".
// Clear the console screen and display the complete scripture, including theReference and the text.
// Prompt the user to press the enter key or type quit.
// If the user types quit, the program should end.
// If the user presses the enter key (without typing quit), the program should hide a few random words in the scripture, clear the console screen, and display the scripture again.
// The program should continue prompting the user and hiding more words until all words in the scripture are hidden.
// When all words in the scripture are hidden, the program should end.
// When selecting the random words to hide, for the core requirements, you can select any word at random, even if the word was already hidden. (As a stretch challenge, try to randomly select from only those words that are not already hidden.)
// Design Requirements
// In addition your program must:

// Use the principles of Encapsulation, including proper use of classes, methods, public/private access modifiers, and follow good style throughout.
// Contain at least 3 classes in addition to the Program class: one for the scripture itself, one for theReference (for example "John 3:16"), and to represent a word in the scripture.
// Provide multiple constructors for the scriptureReference to handle the case of a single verse and a verse range ("Proverbs 3:5" or "Proverbs 3:5-6").
// Showing Creativity and Exceeding Requirements
// Meeting the core requirements makes your program eligible to receive a 93%. To receive 100% on the assignment, you need to show creativity and exceed these requirements.

// Here are some ideas you might consider:

// Think of other challenges that people find when trying to memorize a scripture. Find a way to have your program help with these challenges.
// Have your program work with a library of scriptures rather than a single one. Choose scriptures at random to present to the user.
// Have the program to load scriptures from a files.
// Anything else you can think of!
// Report on what you have done to exceed requirements by adding a description of it in a comment in the Program.cs file.

// Video Demo
// The following video demonstrates the way this program should work:

// Direct link:Reference Memorizer Demo (2 minutes)


// Code Helps
// You might find the following code helps useful in this project:

// Clearing the Console
// In the demo video, you can see that when the user pressed the enter key, words on the screen "disappeared" or were replaced by underscores. In reality, what happened is the console was cleared, and then the scripture was printed out again, but this time with underscores in place of certain words.

// You can clear the console with the Console.Clear() method.


// // This will start by displaying "AAA" and waiting for the user to press the enter key
// Console.WriteLine("AAA");
// Console.ReadLine();

// // This will clear the console
// Console.Clear();

// // This will show "BBB" in the console where "AAA" used to be
// Console.WriteLine("BBB");
// Design
// You will work with your team to create a design for this program. Then, you will each write the code for the program individually.

// In order to understand the decisions that led to this design, make sure to walk through the design activity step by step before using this design to start your code.

//Reference program class diagram
// Develop the Program
// In the course repository, find the Develop03 project in the Prove folder and write your program there.
    
//     When you have completed the program, submit it to I-Learn.