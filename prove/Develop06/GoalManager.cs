using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    protected List<Goal> _goals;
    protected int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        Console.WriteLine("Welcome to the Goal Manager!");
        DisplayPlayerInfo();
        bool running = true;
        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Goal Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals (save and load goals before listing them.");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Completed Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Enter a number to choose an activity: ");
            string activity = Console.ReadLine();

            switch (activity)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals("goals.txt");
                    break;
                case "4":
                    LoadGoals("goals.txt");
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    
    
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Players points: {_score}");
    }

    public void CreateNewGoal()
    {
        
        Console.Write("Enter goal type (1. Simple, 2. CheckList, 3. Eternal): ");
        string type = Console.ReadLine();
        Console.Write("Enter a very short goal name: ");
        string name = Console.ReadLine();
        Console.Write("Goal description: ");
        string description = Console.ReadLine();
        Console.Write("How many points is this goal worth? ");
        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            Console.WriteLine("Invalid input for points. Enter a valid integer.");
            return;
        }
        Goal newGoal = null;
        switch (type)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points, false);
                break;
            case "2":
                Console.Write("Enter goal target-completion date(int format): ");
                if (!int.TryParse(Console.ReadLine(), out int target))
                {
                    Console.WriteLine("Invalid target date.");
                    return;
                }
                Console.Write("Enter goal bonus amount(int format): ");
                if (!int.TryParse(Console.ReadLine(), out int bonus))
                {
                    Console.WriteLine("Invalid bonus amount.");
                    return;
                }
                newGoal = new CheckListGoal(name, description, points, target, bonus);
                break;
            case "3":
                newGoal = new EternalGoal(name, description, points);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }
            _goals.Add(newGoal);
            Console.WriteLine("Goal created successfully!\n");
            Console.WriteLine($"You have {_score} points.");
    }
    
    public void ListGoals()
    {
        Console.WriteLine("The goals are:");
        int index = 1;
        foreach (var goal in _goals)
        {
            if (goal is SimpleGoal simpleGoal)
            {
                string status = simpleGoal.IsComplete() ? "[X]" : "[ ]";
                Console.WriteLine($"{index}. {status} {simpleGoal.GetDetailsString()}");
            }
            else if (goal is EternalGoal eternalGoal)
            {
                string status = "[ ]";
                Console.WriteLine($"{index}. {status} {eternalGoal.GetDetailsString()}");
            }
            else if (goal is CheckListGoal checkListGoal)
            {
                Console.WriteLine($"{index}. {checkListGoal.GetDetailsString()}");
            }
            index++;
            Console.WriteLine($"You have {_score} points.");
        }
    }

    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!\n");
        Console.WriteLine($"You have {_score} points.");
    }

    public void LoadGoals(string filePath)
    {
        if (File.Exists(filePath))
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader(filePath))
            {
                _score = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 4)
                    {
                        Goal goal = new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]), bool.Parse(parts[3]));
                        _goals.Add(goal);
                    }
                    else if (parts.Length == 6)
                    {
                        Goal goal = new CheckListGoal(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]));
                        _goals.Add(goal);
                    }
                    else if (parts.Length == 3)
                    {
                        Goal goal = new EternalGoal(parts[0], parts[1], int.Parse(parts[2]));
                        _goals.Add(goal);
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully!\n");
            Console.WriteLine($"You have {_score} points.");

        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void RecordEvent()
    {
        Console.Write("Enter the goal name you completed: ");
        string name = Console.ReadLine();
        Goal goal = _goals.Find(g => g.GetDetailsString().Contains(name));
        if (goal != null)
        {
            if (goal is SimpleGoal simpleGoal)
            {
                simpleGoal.CheckOff();
                _score += goal.GetPoints();
            }
            else
            {
                goal.RecordEvent();
                _score += goal.GetPoints();
            }
            Console.WriteLine("Event recorded!\n");
            Console.WriteLine($"You have {_score} points.");

        }
        
        else
        {
            Console.WriteLine($"I couldn't find the goal you're referring to: {name}");
        }
    }
}


// In addition to these behaviors for the goals, the goal manager class will need behaviors related to the menu system such as the following:

// Start - This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
// DisplayPlayerInfo - Displays the players current score.
// ListGoalNames - Lists the names of each of the goals.
// ListGoalDetails - Lists the details of each goal (including the checkbox of whether it is complete).
// CreateGoal - Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
// RecordEvent - Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
// SaveGoals - Saves the list of goals to a file.
// LoadGoals - Loads the list of goals from a file.

// _goals : List<Goal>
// _score : int

// GoalManager() - Initializes and empty list of goals and sets the player's score to be 0.


//     private static int _points = 0;

//     static void Main(string[] args)
//     {
//         Console.WriteLine("Welcome to Goal program!");
//         Console.WriteLine($"You have {_points} points.");
        
//         while (true)
//         {
//             Console.WriteLine("Choose an activity from the following menu:");
//             Console.WriteLine("1. Create New Goal");
//             Console.WriteLine("2. List Goals");
//             Console.WriteLine("3. Save Goals");
//             Console.WriteLine("4. Load Goals");
//             Console.WriteLine("5. Record Event");
//             Console.WriteLine("6. Quit");
//             Console.Write("Which one would you like to work on? ");
//             string activity = Console.ReadLine();

//             if (activity == "6")
//             {
//                 Console.WriteLine("It was nice to make goals with you. Come again!");
//                     break;
//             }
            
//             switch (activity)
//             {

//             case "1":
//                 CreateGoal creategoal= new CreateGoal
//                 {
//                     Console.WriteLine("Select one of these goal types: ");
//                     Console.WriteLine("1. Simple Goal");
//                     Console.WriteLine("2. Eternal Goal");
//                     Console.WriteLine("3. Checklist Goal");
//                     Console.WriteLine("4. Exit");
//                     Console.Write("Which one would you like to work on? ");                    
//                     string goalType = Console.ReadLine();

//                     if (goalType == "4")
//                     {
//                         Console.WriteLine("Keep up the good work!");
//                             break;
//                     }

//                     switch (goalType)
//                     {
//                         case "1":
//                             SimpleGoal simpleGoal = new SimpleGoal();
//                             simpleGoal.Run();
//                             break;

//                         case "2":
//                             EternalGoal eternalGoal = new EternalGoal();
//                             eternalGoal.Run();
//                             break;
//                         case "3":
//                             CheckListGoal checklistGoal = new CheckListGoal();
//                             checklistGoal.Run();
//                             break;
//                         default:
//                             Console.WriteLine("Invalid choice.");
//                             break;
//                     }


//             case "2":
//                 ReflectingActivity reflectingActivity = new ReflectingActivity(
//                     "Reflecting Exercise",
//                     "This activity will take you through a series of prompts for you to reflect on.",
//                     0,
//                     new List<string>
//                     {
//                         "Think of a time you were brave.",
//                         "Think of a time when you stood up for someone else.",
// "
//                     },
//                     new List<string>
//                     {   
//                         "Is this something you do often and to what benefit?",
//                         "Why was this experience meaningful to you?",
//                         "At that time, had you ever done anything like it before?",
//                     }
//                 );
//                 reflectingActivity.Run();
//                 break;

//             case "3":
//                 ListingActivity listingActivity = new ListingActivity(
//                     "Listing Exercise",
//                     "Much like the effect that counting your blessings has, this activity will help you to see the good in your life by listing.",
//                     0,
//                     5, // count
//                 new List<string>
//                 {
//                     "Who are people you appreciate? ",
//                     "What are personal strengths of yours? ",
//                     "In what ways would you like to improve? ",
//                     "How many ways can you show gratitude? ",
//                     "What blessing did you have yesterday? "
//                 }
//             );
//                 listingActivity.Run();
//                 break;

//             default:
//                 Console.WriteLine("Invalid choice.");
//                 break;
//             }
//         }
//     }
// }


//     private List<Goal> Goalsies = new List<Goal>();
//     public void AddGoal(Goal newGoal)
//     {
//         Goalsies.Add(newGoal);
//     }
//     public void GetStringRepresentation()
//     {
//         foreach (var newGoal in Goalsies)
//         {
//             newGoal.GetStringRepresentation();
//             return ();
//         }
//     }
//     public void SaveGoal(string filePath)
//     {
//         using (StreamWriter writer = new StreamWriter(filePath))
//         {
//             foreach (var newGoal in Goalsies)
//             {
//                 writer.WriteLine($"{_name}|{_description}|{_points}");
//             }
//         }
//     }

//     public string GetDetailsString()
//     {
//         return "Details string not implemented yet.";
//     }
    
//     public void LoadGoalFromManager(string filePath)
//     {
//         if (File.Exists(filePath))
//         {
//             Goalsies.Clear();
//             using (StreamReader reader = new StreamReader(filePath))
//             {
//                 string line;
//                 while ((line = reader.ReadLine()) != null)
//                 {
//                     string[] categories = line.Split("|");
//                     if (categories.Length == 3)
//                     {
//                         Goal newGoal = new EternalGoal(categories[0], categories[1], categories[2]);
//                         Goalsies.Add(newGoal);
//                         // Console.WriteLine($"Loaded Goal: {newGoal._shortName}|{newGoal._description}|{newGoal._points}");
//                     }
//                     else
//                     {
//                         Console.WriteLine("Invalid Goal format");
//                     }
//                 }
//             }

//             Console.WriteLine($"{Goalsies.Count()} Goales retrieved successfully.");
//         }
//         else
//         {
//             Console.WriteLine("Goals not found.");
//         }

//     }

//     public int CountGoalsies(string date)
//     {
//         int count = 0;
//         foreach (Goal Goal in Goalsies)
//         {
//             {
//                 count++;
//             }
//         }

//         if (count == 0)
//         {
//             Console.WriteLine();
//         }

//         return count;
//     }
