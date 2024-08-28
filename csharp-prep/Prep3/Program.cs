using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Prep3");
        Console.WriteLine("Welcome to Guess My Number!");
        Console.WriteLine("I'm thinking of a number between 1 and 20.");
        Console.WriteLine("");
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 20);
        int guess = -1;
        int guessCount = 0;

        while (guess != magicNumber)
        {
            Console.Write("What number am I thinking of? ");
            guess = int.Parse(Console.ReadLine());
            guessCount++;

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {guessCount} guesses.");
                Console.WriteLine("");
                Console.WriteLine("Would you like to play again? (y/n)");
                string playAgain = Console.ReadLine();
                if (playAgain == "y")
                {
                    magicNumber = randomGenerator.Next(1, 10);
                    guess = -1;
                }
                else if (playAgain == "n")
                {
                    Console.WriteLine("Have a fantastic day!! Goodbye.");
                    Console.WriteLine("");
                    break;
                }
            }

        }                    
    }
}
    