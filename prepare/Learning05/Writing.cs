using System;

public class Writing : Assignment
// Create the class and set up the inheritance relationship.

{
    // Add the member variables and set up the constructor as you did for the MathAssignment class.
    private string _title;
    
    public Writing(string studentName, string topic, string title) : base(studentName, topic)
    {
        // set Math specific variables
        _title = title;
    }
    // Add the GetWritingInformation() method.
    public string GetWritingInfo()
    {
        string studentName = GetSummary();

        return $"{_title} by {studentName}";

    }
}

// Create the class and set up the inheritance relationship.
// Add the member variables and set up the constructor as you did for the MathAssignment class.
// Add the GetWritingInformation() method.
// Notice that this method needs to access the _studentName variable defined in the base class. Even though WritingAssignment class inherited this attribute, it is private, so you cannot access it directly in the derived class.

// To get the data you need for the method you can either make the variable protected in the base class, or you can create a public GetStudentName method to return it.