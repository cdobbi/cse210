using System;
using System.Collections.Generic;


class Program
{

    static void Main(string[] args)
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
        Console.WriteLine($"The Sum is {sum}.");
                if (numbers.Count > 0)
                {
                    double average = (double)sum / numbers.Count;
                    Console.WriteLine($"The average is {average}.");
                }
            }

            int largestNumber = int.MinValue;
            foreach (int number in numbers)
            {
                if (number > largestNumber)
                {
                    largestNumber = number;
                }
            }
            Console.WriteLine($"The largest number is {largestNumber}.");

            int smallest = int.MaxValue;
            foreach (int number in numbers)
            {
                if (number > 0 && numberEntered < smallest)
                {
                    smallest = number;
                }
                if (smallest != int.MaxValue)
                {
                    Console.WriteLine($"The smallest positive number entered is: {smallest}.");
                }
            }
            numbers.Sort();
            Console.WriteLine("The sorted list is: ");
            foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
