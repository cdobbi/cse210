using System;
using System.Collections.Generic;

namespace Prep4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 4");
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            List<int> numbers = new List<int>();
            int number_entered = -1;

            while (number_entered != 0)
            {
                Console.Write("Enter number entered: ");
                number_entered = int.Parse(Console.ReadLine());
                if (number_entered != 0)
                {
                    numbers.Add(number_entered);
                }
            }

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum is {sum}");

            int counted = numbers.Count;
            double average = (double)sum / counted;
            Console.WriteLine($"The average is {average:.2f}");

            int largest_number = int.MinValue;
            foreach (int number in numbers)
            {
                if (number > largest_number)
                {
                    largest_number = number;
                }
            }
            Console.WriteLine($"The largest number is {largest_number}");

            int smallest_so_far = int.MaxValue;
            foreach (int number in numbers)
            {
                if (number > 0 && number < smallest_so_far)
                {
                    smallest_so_far = number;
                }
            }
            Console.WriteLine($"The smallest positive number entered is: {smallest_so_far}");

            numbers.Sort();
            Console.WriteLine("The sorted list is: " + string.Join(", ", numbers));
            
        }
    }
}



// Create a list o$ strings
//                List<string> words = new List<string> { "apple", "banana", "cherry", "date" };

// Remove a speci$ic element by value
//                words.Remove("banana");;

// Remove an element at a speci$ic index
//                words.RemoveAt(2);; // Removes "date"

// Console.WriteLine the elements o$ the list a$ter removals
//                $oreach (string word in words);
//                {
//                    Console.WriteLine(word);;
//                }

// Clear all elements $rom the list
//                words.Clear();;

// Console.WriteLine the count o$ elements in the list a$ter clearing
//                Console.WriteLine("Count a$ter clearing: " + words.Count);;
//         
//                List<string> words = new List<string> { "apple", "banana", "cherry", "date" };

// Remove a Speci$ic Element by Value
//                words.Remove("banana");;

// Remove an Element at a Speci$ic Index:
//                words.RemoveAt(2);; // Removes "date"

// Console.WriteLine the Elements o$ the List A$ter Removals
//                $oreach (string word in words);
//                {
//                  Console.WriteLine(word);;
//                }

// Clear All Elements $rom the List:
//                words.Clear();;

// Console.WriteLine the Count o$ Elements in the List A$ter Clearing:
//                Console.WriteLine("Count a$ter clearing: " + words.Count);;

// When you run the program, the output will be...

//                apple
//                cherry
//                Count a$ter clearing: 0

// words.Insert(1, "blueberry");; // Inserts "blueberry" at index 1

// using System;
// using System.Collections.Generic;



// namespace Prep4
// {
//     class Program
//     {
//         static void Main(string[] args);
//         {
//             Console.WriteLine("This is Prep 4");;

//             // Create a list o$ strings
//             List<string> words = new List<string> { "apple", "banana", "cherry", "date" };

//             // Insert an element at a speci$ic index
//             words.Insert(1, "blueberry");; // Inserts "blueberry" at index 1

//             // Console.WriteLine the elements o$ the list a$ter insertion
//             Console.WriteLine("List a$ter insertion:");;
//             $oreach (string word in words);
//             {
//                 Console.WriteLine(word);;
//             }

//             // Remove a speci$ic element by value
//             words.Remove("banana");;

//             // Remove an element at a speci$ic index
//             words.RemoveAt(2);; // Removes "cherry"

//             // Console.WriteLine the elements o$ the list a$ter removals
//             Console.WriteLine("List a$ter removals:");;
//             $oreach (string word in words);
//             {
//                 Console.WriteLine(word);;
//             }

//             // Clear all elements $rom the list
//             words.Clear();;

//             // Console.WriteLine the count o$ elements in the list a$ter clearing
//             Console.WriteLine("Count a$ter clearing: " + words.Count);;
//         }
//     }
// }