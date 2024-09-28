using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(1, 1);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(6, 1);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Fraction fraction4 = new Fraction(6, 7);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());
    }    
}


// CSE 210: Programming with Classes
// Prepare
// Encapsulation is the act of enclosing something, as if it were in a capsule. It means thinking carefully about the behaviors your classes need and then hiding the details of how they perform those behaviors, even making it so other code cannot see or manipulate these details.

// Previously, you learned about the power and value of abstraction in writing programs that can handle change. One of the main principles was to let a class be responsible for the details of a particular task. Then, the other parts of the program do not have to worry about those details, as long as they know how to interact with the class itself.

// With encapsulation, we push this idea further by preventing other parts of the program from accessing those details. The idea is that a class should completely encapsulate, or contain, all of the data and logic surrounding the task. If other parts of the program need to perform the task or something related to it, they should not try to access the data directly. Instead, they should communicate with the class in question, and it can access the data as necessary. If the class has well-designed methods, other parts of the program shouldn't need direct access to the internal data, they can rely on the methods provided.

// In this way, a major component encapsulation in programming involves information hiding or controlling access to internal data.

// Why Encapsulation Matters
// At first glance, it may seem a little silly to hide information or restrict access to parts of the code from other places of the program, but it turns out to be critical for two main reasons:

// If something is broken, any code that has access might be to blame.
// If something needs to change, any code that has access might need to change.
// Consider the following code.


// public class Account
// {
//     public int _balance = 0;

//     public void Deposit(int amount)
//     {
//         _balance = _balance + amount;
//     }
// }

// Account savings = new Account();
// savings._balance = 50;
// savings.Deposit(100);  
// What would happen if we decided to change the balance attribute in the Account class to a list of transactions? On one hand, we'd be able to keep track of individual deposits. On the other hand, we'd break a different part of the program.


// public class Account
// {
//     public List<int> _transactions = new List<int>(); // if we change this to a list...

//     public void Deposit(int amount)
//     {
//         transactions.Add(amount);
//     }
// }

// Account savings = new Account();
// savings._balance = 50; // if we make the change above, this doesn't work anymore!
// savings.Deposit(100); // however, this approach would continue to work
// In this case, the details of the Account class are not well encapsulated. We need a way of hiding the class attributes so that other code does not attempt to change them directly. If we can, it will allow us to minimize the interdependencies between different parts of our code and protect them from breaking changes.

// Video Example
// Please watch the following video that highlights this example of Encapsulation.

// Direct Link: Encapsulation (6 minutes)


// Using Access Modifiers
// Some programming languages, like C#, use access modifiers, or special keywords, to specify which attributes and methods are public or private. Public class members are accessible from anywhere in the program. Private class members are only accessible by methods in the class that contains them. Other languages, like Python, use coding conventions to indicate how a class member should be treated.

// In C#, Any class members that should be kept private or hidden from other parts of the program should begin with the private keyword. Any class members that should be available for use in other parts of the program should begin with the public keyword. These are called access modifiers.


// public class Account
// {
//     private List<int> _transactions = new List<int>(); 

//     public void Deposit(int amount)
//     {
//         _transactions.Add(amount);
//     }
// }
// Sometimes it's difficult to decide what class members should be public or private. A good rule of thumb is to restrict access to class members as much as possible.

// Hiding information from who?
// Keep in mind that when we talk about making data private or hiding it, we are not talking about encrypting sensitive data like credit card numbers to hide it from the user or from hackers. Instead, we are limiting the parts of our program than can directly access a variable. So we are hiding it from ourselves in other parts of the program.

// The idea is to limit access to only those parts of the code they really need it.

// Attributes
// As a general rule, attributes (or member variables) should be made private. Other classes should not know the details of how the class stores its information. Instead, the other parts of the program should ask the class to perform tasks related to that information through public methods.

// The following example shows how to declare private member variables:


// public class Person
// {
//     private string _title;
//     private string _firstName;
//     private string _lastName;

//     ...
// }
// Methods
// Many methods (or member functions) of a class are public. This is the interface that other parts of the program can use to perform the tasks they need.

// Are there ever private methods? Yes! Often, a public method will have internal steps or computations to perform to help it do its job. These "helper functions" are often private, because the only code that needs to access them is in the class.

// As stated above, the general rule to follow is: restrict access as much as possible. Only make an attribute or method public if there is a specific need.

// Example
// The following example shows how to declare public and private member functions. It gives examples of getting two kinds of email signatures, one that is formal ("Sincerely"), and one that is informal ("Thanks"). The formal one makes use of the person's full name.

// In order to get the full name from a class that stores the first and last names separately, the class might make use of a private, helper function to prepare the full name. This function could be made private initially, because others only need access to the email signature. (If it is later determined that others need access to the full name itself, you could consider making it public as well. But in all cases you are keeping the variables private.)


// public class Person
// {
//     private string _title;
//     private string _firstName;
//     private string _lastName;

//     public string GetInformalSignature()
//     {
//         return "Thanks, " + _firstName;
//     }

//     public string GetFormalSignature()
//     {
//         return "Sincerely, " + GetFullName();
//     }

//     private string GetFullName()
//     {
//         return _title + " " + _firstName + " " + _lastName;
//     }
//     ...
// }
// Getters and Setters
// Sometimes you may feel that other parts of the program need access to a member variable. If this is the case, instead of making the variable public, you should create methods to get and set the value. This ensures that the class still controls access to the variables and that the variables themselves are hidden.

// These functions are called "getters" and "setters" or accessors and mutators, and they are very common.

// The following example shows how to create a getter and setter for the _firstName variable:

// public class Person
// {
//     private string _title;
//     private string _firstName;
//     private string _lastName;

//     public string GetFirstName()
//     {
//         return _firstName;
//     }

//     public void SetFirstName(string firstName)
//     {
//         _firstName = firstName;
//     }

//     ...
// }
// This would then be called from another part of the program as follows:

// Person p = new Person();
// p.SetFirstName("Peter");

// Console.WriteLine(p.GetFirstName());
// Notice that the other part of the program now has the ability to set the first name, and can also access it when needed, but it does so by calling these methods, rather than interacting with the variables directly.

// On Getters and Setters
// Getters and setters are so common that many well known code editors will automatically generate them for you. But they have also been the subject of debate since at least 2003 when Allen Holub published an article called, Why Getter and Setter Methods Are Evil.

// While we encourage you to develop your own opinion we think Mr. Holub's advice is sound. When you're programming with classes, focus on what the class must do rather than how it will do it and many of the getters and setters in your code will naturally disappear. You simply won't have to worry about it.

// Constructors
// In the previous lesson you were introduced to Constructors. Constructors are special methods that are called automatically when an object is created. Their purpose is to help set up the initial state of an object. The name of a constructor must match the class name, and the return type is left empty (not even void). The simplest constructor is a no-argument constructor, that allows an object to be created without specifying any extra information.


// Person p = new Person(); // This calls a no-argument constructor and doesn't need any information
// You can use this constructor to help set default values. For example, the following code specifies a no-argument constructor to set a default name for all new Person objects that are created.


// public class Person
// {
//     private string _title;
//     private string _firstName;
//     private string _lastName;

//     public Person()
//     {
//         _title = "";
//         _firstName = "Anonymous";
//         _lastName = "Unknown";
//     }

//     ...

// }
// In addition to a no-argument constructor you might want to have another one to allow the user to pass in the values for some of the member variables. For example, the following code shows a class with three constructors, one that doesn't require any information, another that accepts values for the first and last names (but not the title), and another that accepts values for all three member variables.


// public class Person
// {
//     private string _title;
//     private string _firstName;
//     private string _lastName;

//     public Person()
//     {
//         _title = "";
//         _firstName = "Anonymous";
//         _lastName = "Unknown";
//     }

//     public Person(string first, string last)
//     {
//         _title = "";
//         _firstName = first;
//         _lastName = last;
//     }

//     public Person(string title, string first, string last)
//     {
//         _title = title;
//         _firstName = first;
//         _lastName = last;
//     }
//     ...

// }
// These three constructors allow you to create a new person object in any of those three ways:


// Person p1 = new Person(); // Don't pass any information to get the default values
// Person p2 = new Person("Jane", "Doe"); // pass the first and last names
// Person p3 = new Person("Mrs.", "Jane", "Doe"); // pass all three variables
// If you don't specify any constructors, C# will provide an empty no-argument constructor for you. However, if you specify another constructor that does receive values, you will not have a default constructor unless you explicitly create it. This is actually nice if you want to force people to always pass in values when creating a new object.

// You can indicate constructors in your class diagram just like methods, but without a return type. For example:

// Person Class Diagram
// Person Class Diagram
// In Summary
// Encapsulation is the second principle of programming with classes. A key component of encapsulation is hiding or controlling access to information. Careful use of access modifiers will help protect you and your coworkers from breaking your programs.

// But also remember that Encapsulation is more than just making member variables private. Building on the principle of Abstraction, Encapsulation is all about making sure that your classes define the appropriate behaviors and then internally take care of the details needed to carry out those behaviors. Well-designed classes make careful use of constructors and provide meaningful methods for anything that needs to be done, rather than simply exposing the internal data with getters and setters.

// The benefits don't stop there though. Practice encapsulation diligently and your abstractions will become more refined, your objects more purposeful, and your classes more understandable. Continue to work at it, and over time, your programs will be vastly more flexible and easy to change.

// Activity Instructions
// Practice the principle of encapsulation by creating classes to hold a fraction, such as 2/3. As you recall from your Math classes, a fraction has a top number (numerator) and a bottom number (denominator). The fraction can be expressed as two integers with a slash between them, such as 3/4 or as a decimal, such as 0.75.

// Design the Classes
// You need to create a class for a fraction that has:

// Attributes for the top and bottom numbers
// Constructors
// Getters and setters for the top and bottom numbers
// Methods to return representations of both the fractional and decimal views.
// A class diagram for this class would then look as follows:

// Fraction Class Diagram
// Fraction Class Diagram
// Start the Project
// Open the class project in VS Code.
// Navigate to the Learning03 project in the prepare folder. Find the Program.cs file, which will be your entry point for the program.
// Verify that you can run the project.
// Create the Fraction class
// Create a class to hold fraction.
// The class should be in its own file.
// The class should have two attributes for the top and bottom numbers.
// Make sure the attributes are private.
// Create the Constructors
// Create the following constructors:
// Constructor that has no parameters that initializes the number to 1/1.
// Constructor that has one parameter for the top and that initializes the denominator to 1. So that if you pass in the number 5, the fraction would be initialized to 5/1.
// Constructor that has two parameters, one for the top and one for the bottom.
// In your Program.cs file, verify that you can create fractions using all three of these constructors. For example, create an instance for 1/1 (using the first constructor), for 6/1 (using the second constructor), for 6/7 (using the third constructor).
// Create the Getters and Setters
// Create getters and setters for both the top and the bottom values.
// In your Program.cs file, verify that you can call all of these methods and get the correct values, using setters to change the values and then getters to retrieve these new values and then display them to the console.
// Create methods to return the representations
// Create a method called GetFractionString that returns the fraction in the form 3/4.
// Create a method called GetDecimalValue that returns a double that is the result of dividing the top number by the bottom number, such as 0.75.
// Verify that you can call each constructor and that you can retrieve and display the different representations for a few different fractions. For example, you could try:
// 1
// 5
// 3/4
// 1/3
// Sample Output

// 1/1
// 1
// 5/1
// 5
// 3/4
// 0.75
// 1/3
// 0.3333333333333333
