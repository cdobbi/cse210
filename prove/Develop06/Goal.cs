using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    

    public Goal(string name, string descripton, int points)
    {
        _shortName = name;
        _description = descripton;
        _points = points;
    }

    public int GetPoints()
    {
        return _points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}


// Goal
// RecordEvent() : void (Abstract)
// IsComplete() : bool (Abstract)
// GetDetailsString() : string
// GetStringRepresentation() : string (Abstract)

// _shortName : string
// _description : string
// _points : int

// Goal(name : string, description : string, points : int)


// As with the previous assignment, there is a natural application of inheritance in this program with a base class of Goal that defines the common responsibilities, behaviors, and attributes. Then, you should have derived classes that override any behaviors necessary from the base class and add any additional unique responsibilities that they have.

// One of the core pieces of functionality for each of these classes is that each goal needs to provide a way to record the event (in other words, mark that is has been accomplished another time). In addition, each one needs to provide a check to see if it is complete. Because these methods exist for all classes, they should be defined in the base class. However, because they all have different functionality, they should be overridden in the derived classes:

// RecordEvent - This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).

// IsComplete - This method should return true if the goal is completed. The way you determine if a goal is complete is different for each type of goal.
// In addition to recording the event and checking if it is complete. Each goal will need to be shown in a list (with the checkbox etc), and also each one will need a string representation that can be saved to a text file. These should also be declared in the base class and overridden in the derived classes as needed:

// GetDetailsString - This method should return the details of a goal that could be shown in a list. It should include the checkbox, the short name, and description. Then in the case of the ChecklistGoal class, it should be overridden to shown the number of times the goal has been accomplished so far.

// GetStringRepresentation - This method should provide all of the details of a goal in a way that is easy to save to a file, and then load later.

// The following is a summary of the behaviors listed:

// Goal
// RecordEvent() : void (Abstract)
// IsComplete() : bool (Abstract)
// GetDetailsString() : string
// GetStringRepresentation() : string (Abstract)
// SimpleGoal
// RecordEvent() : void (Override)
// IsComplete() : bool (Override)
// GetStringRepresentation() : string (Override)
// EternalGoal
// RecordEvent() : void (Override)
// IsComplete() : bool (Override)
// GetStringRepresentation() : string (Override)
// ChecklistGoal
// RecordEvent() : void (Override)
// IsComplete() : bool (Override)
// GetDetailsString() : string (Override)
// GetStringRepresentation() : string (Override)
// In addition to these behaviors for the goals, the goal manager class will need behaviors related to the menu system such as the following:

// Start - This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
// DisplayPlayerInfo - Displays the players current score.
// ListGoalNames - Lists the names of each of the goals.
// ListGoalDetails - Lists the details of each goal (including the checkbox of whether it is complete).
// CreateGoal - Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
// RecordEvent - Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
// SaveGoals - Saves the list of goals to a file.
// LoadGoals - Loads the list of goals from a file.
// In addition to the methods described here, you might find it helpful to create other private methods to help perform steps of these goals.