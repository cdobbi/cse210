using System;

public class SimpleGoal : Goal // Ensure the SimpleGoal class inherits from the Goal class.

{   // Define private attributes for the goal's completion status.
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"=> {_shortName}: {_description}\n-- {_points} points\n-- Completed: {_isComplete}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName} | {_description} | {_points} | {_isComplete}";
    }
}

// SimpleGoal
// RecordEvent() : void (Override)
// IsComplete() : bool (Override)
// GetStringRepresentation() : string (Override)

// 
// SimpleGoal(name : string, description : string, points : int) - This should also set the the variables for if it is complete to be false.


// Constructor:

// Set the completion status to false.
// Override Methods:

// Implement the RecordEvent method to mark the goal as complete.
// Implement the IsComplete method to return the completion status.
// Implement the GetStringRepresentation method to return a string representation of the goal. 
// Class Definition:

// Ensure the SimpleGoal class inherits from the Goal class.
// Attributes:

// Define a private attribute _isComplete to track whether the goal is complete.
// Constructor:

// Implement a constructor that takes name, description, and points as parameters.
// Call the base class constructor to initialize these attributes.
// Set _isComplete to false.
// Override Methods:

// Implement the RecordEvent method to set _isComplete to true.
// Implement the IsComplete method to return the value of _isComplete.
// Implement the GetStringRepresentation method to return a string that includes the goal's name, description, points, and completion status.
// Example Implementation
// Class Definition:

// Ensure the SimpleGoal class inherits from the Goal class.
// Attributes:

// Define a private attribute _isComplete.
// Constructor:

// Implement a constructor that initializes the name, description, and points.
// Set _isComplete to false.
// Override Methods:

// Implement the RecordEvent method to mark the goal as complete.
// Implement the IsComplete method to return the completion status.
// Implement the GetStringRepresentation method to return a string representation of the goal.