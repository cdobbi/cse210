using System;

namespace Prep3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Generator = new Random();
            string keep_playing = "yes";
            while (keep_playing == "yes")

            {
                int magic_number = Generator.Next(1, 11);
                int guess = 0;
                int guess_count = 0; 

                while (guess != magic_number)
                {
                    Console.Write("Guess the magic number: ");
                    guess = int.Parse(Console.ReadLine());
                    guess_count++;

                    if (guess < magic_number)
                    {
                        Console.WriteLine("Too low!");
                    }
                    else if (guess > magic_number)
                    {
                        Console.WriteLine("Too high!");
                    }
                                            
                }

                Console.Write($"You guessed it. It took you {guess_count} guesses. Would you like to play again? (yes/no) ");

                keep_playing = Console.ReadLine();

                if (keep_playing != "yes")
                {
                    Console.Write("Play again another time.");
                }
            }
        }
    }
}
