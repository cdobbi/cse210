using System;

public class Swimming : Activity
{
    private int _laps;
    // private double _time;
    public Swimming(DateTime date, int length, int laps)
        : base(date, length)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0 * 0.62;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / Length) / 60.0;
    }
    public override double GetPace()
    {
        return Length / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Swimming ({Length} min): Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}


// Use method overriding for the calculation methods.
    // private double _laps;
    // private double _time;
