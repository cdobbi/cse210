using System;

class Program
{
    static void Main(string[] args)
    
    {
        Console.Write("What is your grade as a percentage? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);

        
        
        if (percent >= 90)
        {
            Console.WriteLine("You earned an: A");
        }
        else if (percent >= 80)
        {
            Console.WriteLine("You earned a: B");
        }
        else if (percent >= 70)
        {
            Console.WriteLine("You earned a: C");
        }
        else if (percent >= 60)
        {
            Console.WriteLine("You earned a: D");
        }
        else
        {
            Console.WriteLine("You earned a: F");
            Console.WriteLine("Keep trying!");

        }
    }
}
