using System;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Grade Calculator!");
        Console.Write("What is your grade as a percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string sign = "";
        int lastDigit = grade % 10;
        string letter = "";

        if (grade >= 90)
            letter = "A";
        else if (grade >= 80)
            letter = "B";
        else if (grade >= 70)
             letter = "C";
        else if (grade >= 60)
            letter = "D";
        else
            letter = "F";
        

        if (grade >= 93)
        {
            sign = " ";
            Console.WriteLine($"You earned an: {letter}{sign}");
            Console.WriteLine("Congratulations! You passed the class!");
            Console.WriteLine();
        }
        else if (grade >= 90)
        {
            if (lastDigit >= 7)
                sign = "+";
            else if (lastDigit < 3)
                sign = "-";
            else
                sign = " ";
            Console.WriteLine($"You earned an: {letter}{sign}");
            Console.WriteLine("Congratulations! You passed the class!");
            Console.WriteLine();
        }
        else if (grade >= 80)
        {
            if (lastDigit >= 7)
                sign = "+";
            else if (lastDigit < 3)
                sign = "-";
            else
                sign = " ";
            Console.WriteLine($"You earned a: {letter}{sign}");
            Console.WriteLine("Congratulations! You passed the class!");
            Console.WriteLine();

        }
        else if (grade >= 70)
        {
            if (lastDigit >= 7)
                sign = "+";
            else if (lastDigit < 3)
                sign = "-";
            else
                sign = " ";
            Console.WriteLine($"You earned a: {letter}{sign}");
            Console.WriteLine("Congratulations! You passed the class!");
            Console.WriteLine();

        }
        else if (grade >= 60)
        {
            if (lastDigit >= 7)
                sign = "+";
            else if (lastDigit < 3)
                sign = "-";
            else
                sign = " ";
            Console.WriteLine($"You earned a: {letter}{sign}");
            Console.WriteLine("You didn't pass this time. Keep trying!");
            Console.WriteLine();
        }
        else
        {
            if (grade <= 59)
                sign = " ";
            Console.WriteLine($"You earned a: {letter}{sign}");
            Console.WriteLine("You didn't pass this time. Keep trying!");
            Console.WriteLine();
        }
    }
}

// CSE 210: Programming with Classes

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
