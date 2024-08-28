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
