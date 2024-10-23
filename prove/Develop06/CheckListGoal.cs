using System;

public class CheckListGoal : Goal
{

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