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

// CSE 210: Programming with Classes

// Learning Activity - C# Prep 5
// Overview
// This activity will help you learn to work with Functions in C#.

// Preparation
// Functions
// Like most other languages, functions are an important part of C#.

// Functions in C# are defined and work very similarly to those in Python. In both languages you define the function with a name and list of parameters. The function then has a body that performs tasks and it can potentially return a value.

// One key difference in C# is that in the same way that each variable must define a type, each function must define its return type, for example, whether it will return an int, a string, or nothing (the return type for nothing is void). Also, each parameter must have a data type as well. This is very helpful because, unlike in Python, you will know exactly what kind of data you are receiving.

// The style guidelines for C# say that a function name should use "Title Case" where the name begins with a capital letter and then each subsequent word is capitalized such as: ThisIsALongFunction.

// The general structure of a function definition in C# is:


// returnType FunctionName(dataType parameter1, dataType parameter2)
// {
//     // function_body
// }
// Here is an example of a function that does not have parameters or a return type (hence the use of void):

// C#


// void DisplayMessage()
// {
//     Console.WriteLine("Hello world!");
// }
// Python


// def display_message():
//     print("Hello World")
// The next example shows a function that accepts a single string parameter:

// C#


// void DisplayPersonalMessage(string userName)
// {
//     Console.WriteLine($"Hello {userName}");
// }
// Python


// def display_personal_message(user_name):
//     print(f"Hello {user_name}")
// The next example shows a function that accepts two integers as parameters. It adds them together and returns the result. Notice that the function specifies a return value of int at the beginning of the definition.

// C#


// int AddNumbers(int first, int second)
// {
//     int sum = first + second;
//     return sum;
// }
// Python


// def add_numbers(first, second):
//     sum = first + second
//     return sum
// Functions vs Methods
// From previous courses, you may recall a distinction between standalone functions and member functions, which are called methods. Methods play a very important role in Programming with Classes and they will be discussed at length in the coming lessons.

// In C#, because the language is so dedicated to the principles of Programming with Classes, the default case for all functions is to be methods, which must be called in the context of an object. (Again, more on this later!) But this has an important ramification for you now. If you want to define "regular" standalone function, you need to use the static keyword. This tells C# that you want your functions to be able to be called without any other context.

// To define a standalone function in C#, use the static keyword before the return type:


// static void DisplayMessage()
// {
//     Console.WriteLine("Hello world!");
// }

// static void DisplayPersonalMessage(string userName)
// {
//     Console.WriteLine($"Hello {userName}");
// }

// static int AddNumbers(int first, int second)
// {
//     int sum = first + second;
//     return sum;
// }
// Until we start writing classes, you should put the static keyword in front of all your functions.

// Use static for all of your functions until we start writing classes.

// Variable Scope
// Just like in Python, variables declared and used in the body of a function can only be accessed within that function (they cannot be accessed in main or any other function).

// Other Operations
// There are many other things you can do with functions, but at this point we will starting by focusing on the basics.

// Also, don't forget that you can easily find syntax with a quick Web search!

// Assignment Instructions
// For this assignment, write a C# program that has several simple functions:

// DisplayWelcome - Displays the message, "Welcome to the Program!"
// PromptUserName - Asks for and returns the user's name (as a string)
// PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
// SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
// DisplayResult - Accepts the user's name and the squared number and displays them.
// Your Main function should then call each of these functions saving the return values and passing data to them as necessary.

// Sample output of the program could look as follows:


// Welcome to the program!
// Please enter your name: Brother Burton
// Please enter your favorite number: 42
// Brother Burton, the square of your number is 1764
// Write and Test the program
// Write and test the program as described above.
// Make sure to use the same project template that you did for the previous activities. However, this time, you should add your code in Program.cs file in the the Prep 5 project.
// Sample Solution
// When you have finished the program, please compare your approach to the one from this sample solution:

// C# Prep 05 Sample Solution
// Getting Help
// If you get stuck, please ask questions in MS Teams.

// Submitting
// Return to Canvas and complete the corresponding quiz.

// Copyright © Brigham Young University-Idaho | All rights reserved