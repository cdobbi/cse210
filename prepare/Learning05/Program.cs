using System;

class Program
{
    static void Main(string[] args)
    {
        // create the base assignment object.
        Assignment assignment1 = new Assignment("Bunnicula Bunny", "Lagamorph Literature");
        // Call the method to get the summary.
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        Math assignment2 = new Math("Sir Hops-A-Lot", "Hurdles 101", "Chapters 25-32,", "1-21 odd");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomework());
        Console.WriteLine(); // creates a space between the two assignments.    

        Writing assignment3 = new Writing("Lyra Constellation", "Astronomy", "Colorful Clusters In The Night Sky");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInfo());
    }
}   


// Test your class by returning to the Main method in the Program.cs file. Create a simple assignment, call the method to get the summary, and then display it to the screen.