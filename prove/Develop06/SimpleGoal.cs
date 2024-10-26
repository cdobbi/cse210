using System;

public class SimpleGoal : Goal // Ensure the SimpleGoal class inherits from the Goal class.
{
    // Define private attributes for the goal's completion status.
    private bool _isComplete;

    // Constructor to handle loading goals from file
    public SimpleGoal(string name, string description, int points, bool isComplete) 
        : base(name, description, points)
    {
        _isComplete = isComplete;
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
        return $"\n=> {_shortName}: {_description}\n-- {_points} points\n-- Completed: {_isComplete}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{_isComplete}";
    }

    public void CheckOff()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"{_shortName} has been checked off!");
        }
        else
        {
            Console.WriteLine($"Goal '{_shortName}' has already been checked off.");
        }
    }
}