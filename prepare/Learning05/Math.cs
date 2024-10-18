using System;

public class Math : Assignment
{
    private string _textBookSection;
    private string _problems;

    public Math(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        // set Math specific variables
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomework()
    {
        return $"Section: {_textBookSection}\nProblems: {_problems}";

    }
}


// Create a new file for the MathAssignment class.
// Create this class and make sure to specify that it inherits from the base Assignment class.
// Add the attributes as private member variables. Make sure that you do not create new member variables for the ones you inherited from the base class.
// Create a constructor for your class that accepts all four parameters, have it call the base class constructor to set the base class attributes that way.
// Add the GetHomeworkList() method.
// Test your class by returning to the Main method and creating a new MathAssignment object and set its values. Make sure to test both the GetSummary() and the GetHomeworkList() methods.