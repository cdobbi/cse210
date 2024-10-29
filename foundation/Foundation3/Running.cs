using System;

public class Running : Activity
{
    private double _distance;
    public Running(DateTime date, int length, double distance)
        :base(date, length)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / (Length / 60.0);
    }
    public override double GetPace()
    {
        return Length / _distance;
    }
        public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Running ({Length} min): Distance {GetDistance()} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
        // return $"Biking: {Name}\nBy: {Title}\nDistance: {GetDistance()} miles\nSpeed: {GetSpeed()} mph\nPace: {GetPace()} min/mile\nDate: {Date}\nLength: {Length} minutes";
    }
}

// public class Product
// {
//     private string _name;
//     private string _id;
//     private decimal _price;
//     private int _quantity;

//     public string Name
//     {
//         get { return _name; }
//         set { _name = value; }
//     }
//     public string Id
//     {
//         get { return _id; }
//         set { _id = value; }
//     }
//     public decimal Price
//     {
//         get { return _price; }
//         set { _price = value; }
//     }
//     public int Quantity
//     {
//         get { return _quantity; }
//         set { _quantity = value; }
//     }
//     public Product(string name, string id, decimal price, int quantity)
//     {
//         _name = name;
//         _id = id;
//         _price = price;
//         _quantity = quantity;
//     }
//     public decimal TotalCost()
//     {
//         return _price * _quantity;
//     }


// Use method overriding for the calculation methods.
