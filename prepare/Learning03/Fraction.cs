using System.Data;

// public class Fraction
public class Fraction
{
    private int _numerator;
    private int _denominator;

    // default constructor
    // Noun: In object-oriented programming, a constructor is a special method of a class that is automatically invoked when an instance of the class is created. It is used to initialize the object, often by setting initial values for its attributes or performing setup tasks.
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // constructor for whole number
    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }

    // constructor for numerator and denominator    
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }
    
    // method to get fraction as a string
    public string GetFractionString()
    {
        string text = $"{_numerator}/{_denominator}";
        return text;
    }

    // method (function) to get decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
