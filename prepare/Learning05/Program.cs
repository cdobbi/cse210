using System;

class Program
{
    static void Main(string[] args)
    {
        // create the base assignment object.
        Assignment assignment1 = new Assignment("name Name", "Subjects");
        // Call the method to get the summary.
        Console.WriteLine(assignment1.GetSummary());

        Math assignment2 = new Math("name Name", "Maths", "digit.digit", "digit.digit");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomework());

        Writing assignment3 = new Writing("name Name", "Writing", "Topics");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInfo());
    }
}   

// Test your class by returning to the Main method in the Program.cs file. Create a simple assignment, call the method to get the summary, and then display it to the screen.