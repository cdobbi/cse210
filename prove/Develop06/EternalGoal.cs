using System;

public class EternalGoal : Goal
{   // Implement a constructor that initializes the name, description, and points.
    public EternalGoal(string name, string description, int points) : base(name, description, points) {} //Call the base class constructor to initialize the standard attributes (name, description, points).

    public override void RecordEvent()
    {
        // Since it's an eternal goal, we might not need to do anything here.
    }

    public override bool IsComplete()
    {
        // Since it's an eternal goal, it is never complete.
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName} | {_description} | {_points}";
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} - {_points} points"; 
    }
}

// EternalGoal
// RecordEvent() : void (Override)
// IsComplete() : bool (Override)
// GetStringRepresentation() : string (Override)

// Notice that the EternalGoal class does not define any member variables. What is a reason to still have this class, even though it does not define any member variables?
// EternalGoal(name : string, description : string, points : int)
