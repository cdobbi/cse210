using System;

public class GoalManager : Goal
{

}



// While it is possible to handle all of the menu system and its related functions, including the saving of points, as static functions in the Program.cs file, because there is enough complexity there, it would be nice to encapsulate all that functionality into a separate "manager" class.
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
