using System;

public class Cycling : Activity
{
    private double _speed;
    // private double _time;
    public Cycling(DateTime date, int length, double speed) 
        : base(date, length)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return (_speed * Length) / 60.0;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return  60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Cycling ({Length} min): Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}

// Use method overriding for the calculation methods.
