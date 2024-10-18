using System;

// create a new file and a class for your base Assignment class
public class Assignment
// add attributes for private member variables.
{
    private string _studentName;
    private string _topic;
    // create a constructor that takes two paramaters and sets the member variables.
    public Assignment(string studentName, string topic) // constructor that receives a studen name and topic
    {
        _studentName = studentName; // sets member variables
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    // Add the method for GetSummary() to return the student's name and the topic.
    public string GetSummary()
    {
        return $"Student: {_studentName}\nTopic: {_topic}"; // returns student name and topic.
    }
}


// Begin by creating a new file and a class for your base Assignment class.
// Add the attributes as private member variables.
// Create a constructor for this class that receives a student name and topic and sets the member variables.
// Add the method for GetSummary() to return the student's name and the topic.
// Test your class by returning to the Main method in the Program.cs file. Create a simple assignment, call the method to get the summary, and then display it to the screen.