using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prep5");
        Console.WriteLine("");
        // returnType FunctionName(dataType parameter1, dataType parameter2)
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquaredNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
        Console.WriteLine("");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("");

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        return number;
    }

    static int SquaredNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine("");
    }
}

// PromptUserName - Asks for and returns the user's name (as a string)
// PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
// SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
// DisplayResult - Accepts the user's name and the squared number and displays them.
// Your Main function should then call each of these functions saving the return values and passing data to them as necessary.

// Welcome to the program!
// Please enter your name: Brother Burton
// Please enter your favorite number: 42
// Brother Burton, the square of your number is 1764

// Version control is a place that retains and organizes versions of a developing program. Kind of like a file cabinet that holds files dedicated to a specific project that everyone in the office has access to. When you want to work on your assigned file, you can pull it to look at it, make changes to it, improve it, then put it back for everyone else to access. It's useful because the project in progress can be accessed at the same time from anyone, contributing to it. An application of this is, a team here all those contributing to it are in different locations around the world, they can collaborate from their own locations, make their contributions to their branch of the same project simultaneiously. A Git command example is git add . git commit -m "Added new feature to the homepage.: