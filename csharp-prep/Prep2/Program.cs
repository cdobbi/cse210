using System;

class Program
{
    static void Main(string[] args)

    {
        Console.Write("What is your grade as a percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string sign = "";
        int lastDigit = grade % 10;

        if (grade >= 93)
        {
            sign = " ";
            Console.WriteLine($"You earned an: A{sign}");
        }
        else if (grade >= 90)
        {
            if (lastDigit >= 7)
                sign = "+";
            else if (lastDigit < 3)
                sign = "-";
            else
                sign = " ";
            Console.WriteLine($"You earned an: A{sign}");
        }
        else if (grade >= 80)
        {
            if (lastDigit >= 7)
                sign = "+";
            else if (lastDigit < 3)
                sign = "-";
            else
                sign = " ";

            Console.WriteLine($"You earned a: B{sign}");
        }
        else if (grade >= 70)
        {
            if (lastDigit >= 7)
                sign = "+";
            else if (lastDigit < 3)
                sign = "-";
            else
                sign = " ";
            Console.WriteLine($"You earned a: C{sign}");
        }
        else if (grade >= 60)
        {
            if (lastDigit >= 7)
                sign = "+";
            else if (lastDigit < 3)
                sign = "-";
            else
                sign = " ";
            Console.WriteLine($"You earned a: D{sign}");
        }
        else
        {
            if (grade <= 59)
                sign = " ";
            Console.WriteLine($"You earned a: F{sign}");
            Console.WriteLine("Keep trying!");
        }
    }
}

// CSE 210: Programming with Classes

// Overview
// This activity will help you learn to work with variables and conditional statements in C#.

// Preparation Material
// Conditionals
// C# uses if statements just Python, but the syntax is slightly different.

// If Statements
// First, the condition of the if statement must be put in parentheses (). Then, to define the body of the if statement, you still indent by convention, but it is the curly braces {} that define the body. (You also do not use the colon : that Python does to start the block.)

// C#


// if (x > y)
// {
//     Console.WriteLine("greater than");
// }
// Python


// if x > y:
//     print("greater than")
// Notice that the convention in C# is to put the curly braces {} on their own lines. There are religious debates about "the one true bracing style," but putting them on their own line is the defined convention for C#, so that's what you should follow.

// If you put one block of code inside another, it should be indented as follows:


// if (x > y)
// {
//     if (x > z)
//     {
//         Console.WriteLine("greater than both");
//     }
// }
// Else and Else If
// C# supports else and else if, similar to else and elif in Python.

// The else condition defines a body, just like the if condition:

// C#


// if (x > y)
// {
//     Console.WriteLine("greater than");
// }
// else
// {
//     Console.WriteLine("less than");
// }
// Python


// if x > y:
//     print("greater than")
// else:
//     print("less than")
// The else if condition also defines its body in the same fashion. Please note that in C#, the keywords are else if not elif:

// C#


// if (x > y)
// {
//     Console.WriteLine("greater than y");
// }
// else if (x > z)
// {
//     Console.WriteLine("greater than z");
// }
// else
// {
//     Console.WriteLine("less than both");
// }
// Python


// if x > y:
//     print("greater than y")
// elif x > z:
//     print("greater than z")
// else:
//     print("less than both")
// Operators
// C# uses the == operator to check if two variables are equal, just like in Python. It also supports other operators you are familiar with, such as !=, >=, <=, and so forth:


// if (name == "John")
// {
//     Console.WriteLine("The name is John");
// }

// if (color != favoriteColor)
// {
//     Console.WriteLine("That color is not my favorite");
// }
// And, Or, and Not Operators
// In C#, the and operator is && the or operator is || and the not operator is ! which can be combined together with other expressions and parentheses.


// if (name == "Peter" || name == "James" || name == "John")
// {
//     Console.WriteLine("This is a biblical name.");
// }

// if (firstName == "Brigham" && lastName == "Young")
// {
//     Console.WriteLine("Welcome Brother Brigham!");
// }

// if (!(name == "Peter" || name == "James" || name == "John"))
// {
//     Console.WriteLine("This is a not one of those three");
// }
// Variables and Types
// In C#, the naming convention for variables is to use "camel case." This means that the variable starts with a lower case letter and then additional words in the variable start with an upper case letter like humps on a camel:


// string color;
// string firstName;
// string lastName;
// int velocityBeforeImpactWasMade;
// Converting Types
// As mentioned before, in C#, all variables must have their data type defined when the variable is first declared. Once defined, variables cannot change type, so you cannot set a variable to an integer first and later reassign it to a string.

// You can, however convert a the value of a variable to a different type. For example, you can create an integer from the digits stored in a string using the int.Parse() function.


// string valueInText = "42";
// int number = int.Parse(valueInText);
// This is especially important if the value comes from the user via a Console.ReadLine() statement, which always returns a string:


// Console.Write("What is your favorite number? ");
// string userInput = Console.ReadLine();
// int number = int.Parse(userInput);
// If the user typed in something other than a number, this would result in type of error called a Runtime Exception.

// Numbers to Strings
// Similarly, an integer can be converted to a string using the .ToString() function of the variable.


// int number = 42;
// string textVersion = number.ToString();
// Video Demo
// These fundamentals are demonstrated in the following video:


// Assignment Instructions
// For this assignment, you will complete another assignment that you did previously in CSE 110, but in this case, write the program in C#:

// Program Specification
// Here are the instructions that you saw previously in CSE 110 that we will use as our program specification:

// Overview
// Write a program that determines the letter grade for a course according to the following scale:

// A >= 90
// B >= 80
// C >= 70
// D >= 60
// F < 60
// Assignment
// Start by completing the core requirements, then when that part is complete, if you have time, see if you can complete some of the stretch challenges as well.

// Please work through the requirements in order rather than jumping ahead to more complicated steps, to ensure that everyone is following the concepts.

// Core Requirements
// Ask the user for their grade percentage, then write a series of if-elif-else statements to print out the appropriate letter grade. (At this point, you'll have a separate print statement for each grade letter in the appropriate block.)

// Assume that you must have at least a 70 to pass the class. After determining the letter grade and printing it out. Add a separate if statement to determine if the user passed the course, and if so display a message to congratulate them. If not, display a different message to encourage them for next time.

// Change your code from the first part, so that instead of printing the letter grade in the body of each if, elif, or else block, instead create a new variable called letter and then in each block, set this variable to the appropriate value. Finally, after the whole series of if-elif-else statements, have a single print statement that prints the letter grade once.

// Stretch Challenge
// Add to your code the ability to include a "+" or "-" next to the letter grade, such as B+ or A-. For each grade, you'll know it is a "+" if the last digit is >= 7. You'll know it is a minus if the last digit is < 3 and otherwise it has no sign.

// After your logic to determine the grade letter, add another section to determine the sign. Save this sign into a variable. Then, display both the grade letter and the sign in one print statement.

// Hint: To get the last digit, you could divide the number by 10, and get the remainder. You might review the standard math operators and find the one that does division and gives you the remainder.

// At this point, don't worry about the exceptional cases of A+, F+, or F-.

// Recognize that there is no A+ grade, only A and A-. Add some additional logic to your program to detect this case and handle it correctly.

// Similarly, recognize that there is no F+ or F- grades, only F. Add additional logic to your program to detect these cases and handle them correctly.

// Write and Test the program
// Write and test the program as described above.
// You should complete the 3 Core Requirements.
// The stretch challenges are optional.
// Make sure to use the same project template that you did for the C# Prep 1 activity. However, this time, you should add your code in Program.cs file in the the Prep 2 project.
// Sample Solution
// When you have finished the program, please compare your approach to the one from this sample solution:

// C# Prep 02 Sample Solution
// Getting Help
// If you get stuck, please ask questions in MS Teams.

// Submitting
// Return to Canvas and complete the corresponding quiz.

// Copyright © Brigham Young University-Idaho | All rights reserved