
using System; // Imports the System namespace, which contains fundamental classes and base classes.

namespace game // Defines a namespace called 'game'.
{
    class Program // Defines a class named 'Program' within the 'game' namespace.
    {
        static void Main(string[] args) // The entry point of the application.
        {
            Console.WriteLine("Hello World!"); // Prints "Hello World!" to the console.
            Console.WriteLine("This is in C#."); // Prints "This is in C#." to the console.
        }
    }

    class Player // Defines a class named 'Player'.
    {
        public string Name { get; set; } // Defines a public property 'Name' of type string with a getter and setter.
        public int Score { get; set; } // Defines a public property 'Score' of type int with a getter and setter.

        public void DisplayInfo() // Defines a public method 'DisplayInfo'.
        {
            Console.WriteLine($"Player: {Name}, Score: {Score}"); // Prints the player's name and score to the console.
        }
    }

   class Enemy // Defines a class named 'Enemy'.
    {
        public string Type { get; set; } // Defines a public property 'Type' of type string with a getter and setter.
        public int Health { get; set; } // Defines a public property 'Health' of type int with a getter and setter.

        public void Attack() // Defines a public method 'Attack'.
        {
         Console.WriteLine($"{Type} attacks with {Health} health!"); // Prints the enemy's type and health to the console.
        }
    }
}