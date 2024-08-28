using System;

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
            string answered = Console.ReadLine();
            numberEntered = int.Parse(answered);

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

        Console.WriteLine($"The sume is: {sum}");

    }
}