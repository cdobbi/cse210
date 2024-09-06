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

// Overview
// Ensure that your tools are installed and that you can compile and run a basic program in C#.

// C# (pronounced C-Sharp)is very similar to other procedural or objected-oriented programming languages, so if you have learned to program in one of them, you should be able to leverage the core concepts that you already know, and focus on the slight differences in syntax.

// You should already be familiar with programming. This course assumes you are very comfortable with variables, loops, lists, conditionals (if statements), and functions. If you are not, you are not prepared to start this course.

// Preparation Material
// This material will outline some of the major differences between C# and Python, highlighting the pieces you'll need to complete this assignment.

// In addition to the text here, you should consider the Web as a primary source for learning. Once you know what to do, but just not how to do it in a certain language, it's easy to search for "C# print statement" or "C# for loop" or even something more complicated like, "C# open file and read line by line". StackOverflow in particular is a great site to help you with these kinds of questions.

// C# Language Fundamentals
// C# uses the same concepts as Python, in terms of variables, loops, expressions, and so forth. Here are a few differences you need to be aware of:

// Defined types
// In C#, when a variable is declared, its data type must be specified. The computer then knows how much memory to allocate for it. Once a variable's type is defined, it cannot be changed later.

// You declare a variable, by specifying the type. Later, when you use the variable, you do not need to specify the type again.


// int x;
// x = 5;
// Console.WriteLine(x);
// You can also declare a variable an initialize it in one statement:


// int x = 5;
// Console.WriteLine(x);
// Common built-in variable types are:

// int - Integers (whole numbers, positive and negative)
// string - Strings (a sequence of characters, including letters, numbers, or symbols)
// float - Floating point numbers (numbers that use decimals)
// double - Double precision floating point numbers (just like a float, except it takes up twice as much memory, so it can hold larger numbers or numbers with more decimal places)
// bool - Boolean variables (true or false)
// Input and Output
// In C#, to print, or write something as output to the console, you use the Console.WriteLine("") function.

// Python


// print("Hello World!")
// C#


// Console.WriteLine("Hello World!");
// Console.WriteLine("") will print, or write, a full line, including the new line. If you do not want a new line at the end, you can use Console.Write("") to display the text with no newline afterward.

// Console.Write("There will not be a newline after this.");
// To get input from the user in C#, use the Console.ReadLine() function, which will return a string that comes from whatever the user typed. Please note that it is a string (not an integer or floating point number), and that you need to use Console.ReadLine() not Console.Read().

// Also, please be aware that, unlike input in Python, you do not provide the text of the prompt to the Console.ReadLine() function in C#, so you must display it first with Console.Write("").

// Python


// color = input("What is your favorite color? ")
// C#


// Console.Write("What is your favorite color? ");
// string color = Console.ReadLine();
// Curly braces define blocks
// In C#, curly braces {} define the body of an if statement or a function. In Python, the body is defined by indenting. In C#, you still indent the body, but this is only a convention, the actual mechanism to define the body is the curly braces {}.

// Also, in C#, you do not use a colon : to start the body, and when using if statements, you must always put the condition in parentheses ().

// C#


// if (x > y)
// {
//   Console.WriteLine("greater");
// }
// Python


// if x > y:
//   print("greater")
// Statements end in semicolons
// As you may have noticed above, in C#, statements end with the semicolon ; character. Typically one statement will be one line, however, sometimes you may have a long statement that extends on multiple lines until the semicolon ; is reached.

// The rule to end statements with semicolons applies to statements such as calling a function, declaring a variable, setting a variable, and so forth. You do not put a semicolon between the condition of an if statement and its body, or the name of a function and its body.

// String Interpolation
// In C#, if you would like to use a variable inside a string, you start the string with a dollar sign $ in the same way that in Python, you start a format string with an f.

// Python


// school = "BYU-Idaho"
// print(f"I am studying at {school}.")
// C#


// string school = "BYU-Idaho";
// Console.WriteLine($"I am studying at {school}.");
// Video Demo
// These fundamentals are demonstrated in the following video:

// These videos mention using the dotnet new command to start a project, which can be done. However, in this course, you are provided with a project shell already in the GitHub template repository, so you don't have to worry about that.

// Also, as you'll see, the dotnet new command inserts a namespace around your code. This is important for larger projects, but to keep things simple the starting templates we will use in this class will not use namespaces.


// What is all that other stuff? (Optional)
// Assignment Instructions
// Learning activities
// As you will see, each learning activity in this course will have two components, they begin with preparation material to read or watch, and then there is a small programming assignment where you practice the concepts you have just read.

// You need to finish this assignment and then return to Canvas to report on your work.

// Now that you have seen basic C# syntax, complete the following assignment. This was a program you completed earlier in CSE 110, but in this case, you will write the program in C#.

// Getting the Project Template
// If you haven't already done so, please refer to the instructions on the Development Environment Setup page to make sure that your computer is prepared for this course and that you have cloned the project template to your computer.
// Open your project in VS Code.
// Then, in VS Code, navigate to the csharp-prep/Prep1 folder and click on Program.cs. This is the file you will be editing for this project.
// On the "Run and Debug" menu, select "C# Prep 1" from the dropdown menu and click the green play button to run the program. In the terminal window, it should display the text Hello Prep 1 World!.
// Program Specification
// Here are the instructions that you saw previously in CSE 110 that we will use as our program specification:

// Overview
// An iconic line from the James Bond movies is that he would introduce himself as "Bond, James Bond." For this assignment you will write a program that asks for your name and repeats it back in this way.

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

// Warning: Do not ever click "Debug Anyway".

// If you have an error in your program and try to run it, VS Code will tell you that it cannot build a new version of your program to run. But, it may find an old version from the last time it successfully built the program. If you click "Debug Anyway" it will run the old version.

// If you "Debug Anyway" you will be running a program that is different from your current code. This leads to lots of confusion, because you might make changes to your code, but the program does not show the changes.

// To avoid these pitfalls, you should never click "Debug Anyway" instead, click "Abort" and track down your errors, or click "Show Errors" to go directly to them.

// Sample solution
// When you have finished the program, please compare your approach to the one from this sample solution:

// C# Prep 01 Sample Solution
// If you are having difficulty with this and future programs, you are welcome to look at the sample solution to help you finish it. Remember, though that the goal is for you to learn how to write code on your own, and often we learn this best by working through a number of things that don't work, before we find the one that does work. So don't jump in here too quickly.

// Also, you should make sure that you type every line of code yourself. Do not copy and paste this code. It is important for your learning that you practice writing every line of code.

// Getting Help
// If you need help, please ask questions in MS Teams!

// Also, if you are still having difficulty, the following video walks through this complete assignment from start to finish including pushing it to GitHub.

// Direct Link: C# Prep 1 Walkthrough (9 minutes)


// Submitting
// Return to Canvas and complete the corresponding quiz.

// Copyright © Brigham Young University-Idaho | All rights reserved