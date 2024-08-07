using System;
using System.Collections.Generic;

namespace Prep5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 5");
            Console.WriteLine();
            DisplayMessage();
            string name = PromptUserName();
            int number = PromptFavoriteNumber();
            int squared = NumberSquared(number);
            DisplayResult(name, squared);
            Console.WriteLine();
        }
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Enter your first and last name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");

            return name;
        }
        static int PromptFavoriteNumber()
        {
            Console.Write("Enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }
        static int NumberSquared(int number)
        {
            int square = number * number;

            return square;
        }
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {square}.");
        }
    }
}

