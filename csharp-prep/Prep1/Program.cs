using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        Console.WriteLine($"Your name is {last}, {first} {last}");
    }
}

// CSE 210: Programming with Classes
// Assignment
// Prompt the user for their first name. Then, prompt them for their last name. Display the text back all on one line saying, "Your name is last-name, first-name, last-name" as shown:

// What is your first name? Scott
// What is your last name? Burton

// Your name is Burton, Scott Burton.

// What is your first name? Brigham
// What is your last name? Young

// Your name is Young, Brigham Young.
// Make sure to be precise! You should have the spacing, comma, and period appear exactly as shown in the examples.

// Finish the program
// Write and test the program as defined above.
