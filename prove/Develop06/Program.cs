using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop06 World!");
    }
}

// CSE 210: Programming with Classes
// BYU-I logo
// Home
// W1
// W2
// W3
// W4
// W5
// W6
// W7
// Week 06 Develop: Eternal Quest Program
// Problem Overview
// Many people set goals for areas they want to improve in their lives. These goals can be very important to help us in our growth, such as highlighted in the Church's Children and Youth program. But despite our best intentions, we often struggle to follow through with these goals.

// Think for a minute about what are the biggest challenges that keep someone from reaching the goals they have set?

// There are many different reasons you might come up with that apply generally such as forgetting, not having enough time, and programs or applications could help with many of those. In addition to these general challenges, some that are specific to goals could include:

// Many goals repeat and are never finished, such as studying the scriptures.
// Many goals have to be completed a number of times before they can be finished, such as attending the temple 10 times.
// While we recognize the value of our goals in the eternal sense, sometimes we need some shorter term "rewards" to help excite us along the way.
// Solution Idea
// Gamification is the idea of turning something into a game. It could include a number of different concepts, but often involves getting badges or awards, as you "level up" with more points.

// Consider a program that keeps track of various kinds of goals that people have, which are goals in their real life, such as studying the scriptures each day, finishing a project, or even stopping a bad habit. This program could be set up to keep track of your progress on these goals and offer points, awards, or other celebrations to keep you encouraged to keep working.

// A program like this could be more serious, and just keep track of goal progress, or it could be as funny and personal as you would want (for example, a level 13 Ninja Unicorn). The idea is to engage the part of our brain that loves seeing these "wins" and accomplishments as we work on our goals.

// No matter what the exact format is, this program could help each of us on our "Eternal Quest" of returning to be with our Father in Heaven.

// Specification
// Write an Eternal Quest program to track various kinds of goals.

// Your program can include whatever kinds of "gamification" components you like, but each program should have the following base functionality.

// Functional requirements
// Your program must do the following:

// Provide for simple goals that can be marked complete and the user gains some value.
// For example, if you run a marathon you get 1000 points.
// Provide for eternal goals that are never complete, but each time the user records them, they gain some value.
// For example, every time you read your scriptures you get 100 points.
// Provide for a checklist goal that must be accomplished a certain number of times to be complete. Each time the user records this goal they gain some value, but when they achieve the desired amount, they get an extra bonus.
// For example, if you set a goal to attend the temple 10 times, you might get 50 points each time you go, and then a bonus of 500 points on the 10th time.
// Display the user's score.
// Allow the user to create new goals of any type.
// Allow the user to record an event (meaning they have accomplished a goal and should receive points).
// Show a list of the goals. This list should show indicate whether the goal has been completed or not (for example [ ] compared to [X]), and for checklist goals it should show how many times the goal has been completed (for example Completed 2/5 times).
// Allow the user's goals and their current score to be saved and loaded.
// Design Requirements
// In addition your program must:

// Use inheritance by having a separate class for each kind of activity with a base class to contain any shared attributes or behaviors.
// Use polymorphism by having derived classes override base class methods where appropriate.
// Follow the principles of encapsulation and abstraction by having private member variables and putting related items in the same class.
// Showing Creativity and Exceeding Requirements
// Meeting the core requirements makes your program eligible to receive a 93%. To receive 100% on the assignment, you need to show creativity and exceed these requirements.

// Here are some ideas you might consider:

// Add your own ideas for gamification. This could include leveling up, earning certain bonuses, or other "fun" aspects to the quest.
// Add additional kinds of goals, such as the ability to make progress towards a large goal (such as getting value for working towards running a marathon), or "negative goals" where they lose points for bad habits.
// There are lots of ways to show creativity in this assignment. Pick anything that sounds fun to you!
// Report on what you have done to exceed requirements by adding a description of it in a comment in the Program.cs file.

// Video Demo
// The following video demonstrates the way this program should work:

// Direct link: Eternal Quest Demo (9 minutes)


// Code Helps
// You might find the following code helps useful in this project:

// Reading Text Files in C#
// The easiest way to read a text file in C# is to read the entire file into an array of strings (one per line) using the System.IO.File.ReadAllLines() function. Then, you can iterate through each string as you would with any list.

// As you go through each string, you can split it based on a separator character and get the pieces you need by their index.

// The following shows an example of reading a file and splitting up the strings.


// string filename = "myFile.txt";
// string[] lines = System.IO.File.ReadAllLines(filename);

// foreach (string line in lines)
// {
//     string[] parts = line.Split(",");

//     string firstName = parts[0];
//     string lastName = parts[1];
// }
// There are many other ways to work with files in C# some of which would be more efficient if the file is very large and you don't want to store it all in memory at once, but this approach will work just fine for this project.

// Writing Text Files in C#
// You can create or write a text file in C# using a class the System.IO.StreamWriter class. When you create an object of this class you can use the Write() and WriteLine() methods in the same way as the Console.Write() methods, except that they will write the strings to the file instead of to the Console.

// To make sure the file gets closed and cleaned up appropriately when you are done, it is best practice to put the StreamWriter object in a using() block. This works the same as a "with" block in Python and ensures that the resources are cleaned up when you leave that area of the code.

// The following shows an example of writing text to a new file


// // Don't forget to put this at the top, so C# knows where to find the StreamWriter class
// using System.IO; 

// ...

// string fileName = "myFile.txt";

// using (StreamWriter outputFile = new StreamWriter(filename))
// {
//     // You can add text to the file with the WriteLine method
//     outputFile.WriteLine("This will be the first line in the file.");
    
//     // You can use the $ and include variables just like with Console.WriteLine
//     string color = "Blue";
//     outputFile.WriteLine($"My favorite color is {color}");
// }
// Saving and Loading objects in C#
// Turning an object into a string so that you can save it, load it, or send it to another program on the internet, is called "Serializing" and "Deserializing" it. Depending on how complicated your object is, this can require you to be somewhat clever in how it is done. There are libraries of functions that others have written to help serialize and deserialize objects into various formats (for example, JSON, XML, etc.). While you are welcome to use one of these if you would like, they can often take a fair amount of work to configure correctly, so for our simple case, it is probably easier to not use one of them.

// Instead, consider creating a method that returns a string containing the pieces of data that you need for your object, such as: GetStringRepresentation(). This might include the type of the object first (so you'll know later which one you should be using), and then any details of the object. For example, if you had a Person object, it might return a string like this: "Person:Brigham,Young".

// Then, if you wanted to save a whole list of people, you could iterate through them and for each one, call the GetStringRepresentation() method and then save the string out to a file.

// Similarly, when it is time to load the file, you could read in the line, and first split it based on the colon : to get the type of the object (Person) and the details ("Brigham,Young"). Then, you could create a method called CreatePerson that would accept the string of details ("Brigham,Young"). This method could split the string on the commas to get the various items. Then, it could create a new Person object, set all the values, and return it.

// As a side note, this pattern of creating a method (or a class) to help create objects for you is common enough that it has a name: The Factory Pattern. In future courses, you will learn more about the Factory Pattern, and how to handle many of the complexities that could arise when creating objects.

// Design
// You will work with your team to create a design for this program. Then, you will each write the code for the program individually.

// Final Design (Do not open until after your design meeting)
// For reference purposes, here is a copy of the design that was created during the design activity.

// In order to understand the decisions that led to this design, make sure to walk through the design activity step by step before using this design to start your code.

// Eternal Quest program class diagram
// Develop the Program
// In the course repository, find the Develop06 project in the Prove folder and write your program there.

// Submission
// Develop the program using the principle of Polymorphism as described above.
// Make sure to describe anything you have done to exceed the requirements in comments in the Program.cs file.
// Commit your source code and push it to GitHub.
// Verify that you can see your updated code at GitHub.
// In Canvas, submit a link to your GitHub repository. In the submission comment, describe anything you have done to show creativity and exceed the core requirements.
// Copyright © Brigham Young University-Idaho | All rights reserved