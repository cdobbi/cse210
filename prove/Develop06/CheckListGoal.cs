using System;

public class CheckListGoal : Goal
{
    //Define the private attributes. These attributes should be private and of type int.
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;

    // Define a constructor for the ChecklistGoal class.
    // The constructor should take parameters for name, description, points, target, and bonus.
    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points) //Call the base class constructor to initialize the standard attributes (name, description, points).
    { //Initialize _target and _bonus with the provided parameters.Set _amountCompleted to 0.
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            _points += _bonus;
        }
    }
    //Implement the RecordEvent method. This method should increment _amountCompleted. If _amountCompleted reaches _target, it should add the bonus points to the goal's points.
    public override bool IsComplete()
    //Implement the IsComplete method. This method should return true if _amountCompleted is greater than or equal to _target. Otherwise, it should return false.
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    //This method should return a string representation of the goal's details, including the amount completed and the target.
    {
        return $"{_shortName}: {_description} - {_points} points - Completed: {_amountCompleted}/{_target} - Bonus: {_bonus}";
    }
    public override string GetStringRepresentation()
    //This method should return a string representation of the goal, suitable for saving to a file.
    {
        return $"{_shortName}| {_description} | {_points} | {_amountCompleted}/{_target}) | {_bonus}";
    }
  
}




// ChecklistGoal
// RecordEvent() : void (Override)
// IsComplete() : bool (Override)
// GetDetailsString() : string (Override)
// GetStringRepresentation() : string (Override)

// _amountCompleted : int
// _target : int
// _bonus : int

// CheckListGoal(name : string, description : string, points : int, target : int, bonus : int) - In addition to the standard attributes, a checklist goal also needs the target and the bonus amounts. Then, it should set the amount completed to begin at 0.