using System;

public class Product
{
    private string _name;
    private string _id;
    private decimal _price;
    private int _quantity;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public decimal Price
    {
        get { return _price; }
        set { _price = value; }
    }
    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }
    public Product(string name, string id, decimal price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    public decimal TotalCost()
    {
        return _price * _quantity;
    }
}

// Product
// Contains the name, product id, price, and quantity of each product.
// The total cost of this product is computed by multiplying the price per unit and the quantity. (If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)