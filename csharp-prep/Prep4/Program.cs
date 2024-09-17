using System;
using System.Collections.Generic;
class Program
{    static void Main(string[] args)
    {
        Console.WriteLine("Prep4");
        Console.WriteLine("");
        List<int> numbers = new List<int>();
        int numberEntered = -1;
        while (numberEntered != 0)
        {
            Console.Write("Enter a number (type 0 to quit): ");
            string answer = Console.ReadLine();
            numberEntered = int.Parse(answer);
            if (numberEntered != 0)
            {
                numbers.Add(numberEntered);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The Sum is: {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largestNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        Console.WriteLine($"The largest number is: {largestNumber}");

        int smallest = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallest)
            {
                smallest = number;
            }
        }

        if (smallest != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number entered is: {smallest}")
        ;
        }
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

// CSE 210: Programming with Classes

// Assignment
// Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.

// Once you have a list, have your program do the following:

// Core Requirements
// Work through these core requirements step-by-step to complete the program. Please don't skip ahead and do the whole thing at once, because others on your team may benefit from building the program up slowly.

// Compute the sum, or total, of the numbers in the list.

// Compute the average of the numbers in the list.

// Find the maximum, or largest, number in the list.

// The following shows the expected output:


//   Enter a list of numbers, type 0 when finished.
//   Enter number: 18
//   Enter number: 36
//   Enter number: 2
//   Enter number: 48
//   Enter number: 6
//   Enter number: 12
//   Enter number: 9
//   Enter number: 0
//   The sum is: 131
//   The average is: 18.714285714285715
//   The largest number is: 48
  
// Stretch Challenge
// Have the user enter both positive and negative numbers, then find the smallest positive number (the positive number that is closest to zero).

// Sort the numbers in the list and display the new, sorted list. Hint: There are C# libraries that can help you here, try searching the internet for them.

// The following shows the expected output after completing the stretch challenges:

//   Enter a list of numbers, type 0 when finished.
//   Enter number: 3
//   Enter number: 5
//   Enter number: 7
//   Enter number: 3
//   Enter number: 2
//   Enter number: -1
//   Enter number: -4
//   Enter number: -8
//   Enter number: 0
//   The sum is: 7
//   The average is: 0.875
//   The largest number is: 7
//   The smallest positive number is: 2
//   The sorted list is:
//   -8
//   -4
//   -1
//   2
//   3
//   3
//   5
//   7
